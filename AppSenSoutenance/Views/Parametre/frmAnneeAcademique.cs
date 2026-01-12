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
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
        }

        // Contexte de la base de données utilisé pour les opérations CRUD
        private BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        // Chargement du formulaire
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            try
            {
                btnSelect.Visible = true;
                RafraichirInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RafraichirInterface()
        {
            dgAnneeAcademique.DataSource = db.anneeAcademiques.Select(a => new {
                Id = a.IdAnneeAcademique,
                Libelle = a.LibelleAnneeAcademique,
                Valeur = a.AnneeAcademiqueVal
            }).ToList();

            ConfigurerDataGridView();
        }

        private void ConfigurerDataGridView()
        {
            if (dgAnneeAcademique.Columns["Id"] != null)
            {
                dgAnneeAcademique.Columns["Id"].HeaderText = "ID";
                dgAnneeAcademique.Columns["Id"].Width = 80;
            }
            if (dgAnneeAcademique.Columns["Libelle"] != null)
                dgAnneeAcademique.Columns["Libelle"].HeaderText = "Libellé de l'Année";
            
            if (dgAnneeAcademique.Columns["Valeur"] != null)
                dgAnneeAcademique.Columns["Valeur"].HeaderText = "Valeur Numérique";
        }

        // Méthode utilitaire pour réinitialiser les champs
        public void effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            RafraichirInterface();
            txtLibelleAnneeAcademique.Focus();
        }

        // Ajout d'une nouvelle année académique
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Text) || string.IsNullOrWhiteSpace(txtAnneeAcademiqueVal.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AnneeAcademique anneeAcademique = new AnneeAcademique()
                {
                    LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text.Trim(),
                    AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
                };
                db.anneeAcademiques.Add(anneeAcademique);
                db.SaveChanges();
                MessageBox.Show("Année académique ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Modification
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgAnneeAcademique.CurrentRow == null) return;

                int id = (int)dgAnneeAcademique.CurrentRow.Cells["Id"].Value;
                AnneeAcademique anneeAcademique = db.anneeAcademiques.Find(id);
                
                if (anneeAcademique != null)
                {
                    anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text.Trim();
                    anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
                    db.SaveChanges();
                    MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    effacer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Suppression
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgAnneeAcademique.CurrentRow == null) return;

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette année ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dgAnneeAcademique.CurrentRow.Cells["Id"].Value;
                    AnneeAcademique anneeAcademique = db.anneeAcademiques.Find(id);
                    if (anneeAcademique != null)
                    {
                        db.anneeAcademiques.Remove(anneeAcademique);
                        db.SaveChanges();
                        MessageBox.Show("Suppression réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        effacer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sélection
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgAnneeAcademique.CurrentRow != null)
                {
                    txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells["Libelle"].Value.ToString();
                    txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells["Valeur"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurerEffetsBoutons()
        {
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            btnEdit.MouseEnter += (s, e) => btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.MouseLeave += (s, e) => btnEdit.BackColor = Color.FromArgb(52, 152, 219);

            btnRemove.MouseEnter += (s, e) => btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.MouseLeave += (s, e) => btnRemove.BackColor = Color.FromArgb(231, 76, 60);

            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void txtAnneeAcademiqueVal_TextChanged(object sender, EventArgs e) { }
        private void dgAnneeAcademique_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
