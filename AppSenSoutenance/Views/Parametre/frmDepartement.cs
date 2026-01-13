using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        private BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private int idSelectionne = 0;

        public frmDepartement()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
        }

        #region Chargement et Rafraîchissement

        /// <summary>
        /// Charge tous les départements dans le DataGridView
        /// </summary>
        private void ChargerDepartements()
        {
            try
            {
                dvgDepartement.DataSource = db.Departements.Select(d => new
                {
                    Id = d.IdDepartement,
                    Nom = d.LibelleDepartement,
                    Code = d.Code ?? "N/A"
                }).OrderBy(d => d.Nom).ToList();

                ConfigurerDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configure l'affichage du DataGridView
        /// </summary>
        private void ConfigurerDataGridView()
        {
            if (dvgDepartement.Columns["Id"] != null)
                dvgDepartement.Columns["Id"].Visible = false;

            if (dvgDepartement.Columns["Nom"] != null)
            {
                dvgDepartement.Columns["Nom"].HeaderText = "Nom du Département";
                dvgDepartement.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dvgDepartement.Columns["Code"] != null)
            {
                dvgDepartement.Columns["Code"].HeaderText = "Code";
                dvgDepartement.Columns["Code"].Width = 150;
            }
        }

        /// <summary>
        /// Rafraîchit l'interface après une opération CRUD
        /// </summary>
        private void RafraichirInterface()
        {
            ChargerDepartements();
            ClearFields();
        }

        #endregion

        #region Événements de chargement

        private void FormDepartement_load(object sender, EventArgs e)
        {
            ChargerDepartements();
            btnSelectionner.Visible = true;
        }

        /// <summary>
        /// Libération des ressources lors de la fermeture
        /// </summary>
        private void frmDepartement_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }

        #endregion

        #region Opérations CRUD

        /// <summary>
        /// Ajoute un nouveau département
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidationFormulaire())
                    return;

                // Vérifier si le département existe déjà
                bool existe = db.Departements.Any(d => 
                    d.LibelleDepartement.Trim().ToLower() == txtNom.Text.Trim().ToLower() ||
                    (!string.IsNullOrEmpty(txtCode.Text) && d.Code != null && d.Code.Trim().ToLower() == txtCode.Text.Trim().ToLower())
                );

                if (existe)
                {
                    MessageBox.Show("Un département avec ce nom ou ce code existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Departement departement = new Departement()
                {
                    LibelleDepartement = txtNom.Text.Trim(),
                    Code = string.IsNullOrWhiteSpace(txtCode.Text) ? null : txtCode.Text.Trim()
                };

                db.Departements.Add(departement);
                db.SaveChanges();

                MessageBox.Show("Département ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RafraichirInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifie un département existant
        /// </summary>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSelectionne == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un département à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidationFormulaire())
                    return;

                Departement dept = db.Departements.Find(idSelectionne);
                if (dept != null)
                {
                    // Vérifier si un autre département a le même nom ou code
                    bool existe = db.Departements.Any(d => 
                        d.IdDepartement != idSelectionne &&
                        (d.LibelleDepartement.Trim().ToLower() == txtNom.Text.Trim().ToLower() ||
                         (!string.IsNullOrEmpty(txtCode.Text) && d.Code != null && d.Code.Trim().ToLower() == txtCode.Text.Trim().ToLower()))
                    );

                    if (existe)
                    {
                        MessageBox.Show("Un autre département avec ce nom ou ce code existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dept.LibelleDepartement = txtNom.Text.Trim();
                    dept.Code = string.IsNullOrWhiteSpace(txtCode.Text) ? null : txtCode.Text.Trim();
                    db.SaveChanges();

                    MessageBox.Show("Département modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RafraichirInterface();
                }
                else
                {
                    MessageBox.Show("Département introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RafraichirInterface();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime un département après confirmation
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSelectionne == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un département à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Departement dept = db.Departements.Find(idSelectionne);
                if (dept != null)
                {
                    // Vérifier si le département est utilisé ailleurs (par exemple dans ChefDepartement)
                    bool estUtilise = db.chefDepartements.Any(c => c.IdDepartement == idSelectionne);

                    if (estUtilise)
                    {
                        MessageBox.Show("Ce département ne peut pas être supprimé car il est utilisé par un ou plusieurs chefs de département.", 
                            "Impossible de supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        $"Êtes-vous sûr de vouloir supprimer le département \"{dept.LibelleDepartement}\" ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Departements.Remove(dept);
                        db.SaveChanges();

                        MessageBox.Show("Département supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RafraichirInterface();
                    }
                }
                else
                {
                    MessageBox.Show("Département introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RafraichirInterface();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Sélection

        /// <summary>
        /// Sélectionne un département dans le DataGridView
        /// </summary>
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgDepartement.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une ligne dans le tableau.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var current = dvgDepartement.CurrentRow;
                if (current.Cells["Id"].Value != null)
                {
                    idSelectionne = Convert.ToInt32(current.Cells["Id"].Value);
                    txtNom.Text = current.Cells["Nom"].Value?.ToString() ?? "";
                    txtCode.Text = current.Cells["Code"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sélection automatique lors du clic sur une cellule
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dvgDepartement.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dvgDepartement.Rows[e.RowIndex];
                    if (row.Cells["Id"].Value != null)
                    {
                        idSelectionne = Convert.ToInt32(row.Cells["Id"].Value);
                        txtNom.Text = row.Cells["Nom"].Value?.ToString() ?? "";
                        txtCode.Text = row.Cells["Code"].Value?.ToString() ?? "";
                    }
                }
                catch (Exception ex)
                {
                    // Erreur silencieuse pour ne pas perturber l'utilisateur
                }
            }
        }

        #endregion

        #region Méthodes utilitaires

        /// <summary>
        /// Réinitialise les champs du formulaire
        /// </summary>
        private void ClearFields()
        {
            txtNom.Clear();
            txtCode.Clear();
            idSelectionne = 0;
            txtNom.Focus();
        }

        /// <summary>
        /// Valide les données saisies
        /// </summary>
        /// <returns>True si la validation réussit, sinon False</returns>
        private bool ValidationFormulaire()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du département.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            if (txtNom.Text.Trim().Length < 3)
            {
                MessageBox.Show("Le nom du département doit contenir au moins 3 caractères.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Effets visuels

        private void ConfigurerEffetsBoutons()
        {
            btnAjouter.MouseEnter += (s, e) => btnAjouter.BackColor = Color.FromArgb(39, 174, 96);
            btnAjouter.MouseLeave += (s, e) => btnAjouter.BackColor = Color.FromArgb(46, 204, 113);

            btnModifier.MouseEnter += (s, e) => btnModifier.BackColor = Color.FromArgb(41, 128, 185);
            btnModifier.MouseLeave += (s, e) => btnModifier.BackColor = Color.FromArgb(52, 152, 219);

            btnSupprimer.MouseEnter += (s, e) => btnSupprimer.BackColor = Color.FromArgb(192, 57, 43);
            btnSupprimer.MouseLeave += (s, e) => btnSupprimer.BackColor = Color.FromArgb(231, 76, 60);

            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        #endregion

        #region Événements

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
