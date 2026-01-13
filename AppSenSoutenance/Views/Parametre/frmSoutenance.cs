using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
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
    public partial class frmSoutenance : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filler = new FilerList();

        public frmSoutenance()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
            this.Load += FrmSoutenance_Load;
            
            // Attacher les événements aux boutons
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            //btnClose.Click += btnClose_Click;
            dgSoutenance.CellClick += dgSoutenance_CellClick;
        }

        /// <summary>
        /// Chargement des soutenances et actualisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSoutenance_Load(object sender, EventArgs e)
        {
            ChargerMemoires();
            ActualiserGrid();
            btnSelect.Visible = true;
        }

        /// <summary>
        /// Charger les memoires
        /// </summary>
        private void ChargerMemoires()
        {
            cbbMemoire.DataSource = filler.FillMemoire();
            cbbMemoire.DisplayMember = "Text";
            cbbMemoire.ValueMember = "Value";
            
        }

        /// <summary>
        /// Actualisation
        /// </summary>
        private void ActualiserGrid()
        {
            dgSoutenance.DataSource = db.soutenances.Select(s => new
            {
                Id = s.IdSoutenance,
                Date = s.DateSoutenance,
                Lieu = s.LieuSoutenance,
                Resultat = s.ResultatSoutenance ?? "N/A",
                Mention = s.MentionSoutenance ?? "N/A",
                Memoire = s.Memoire != null ? s.Memoire.SujetMemoire : "N/A"
            }).ToList();

            if (dgSoutenance.Columns["Id"] != null)
                dgSoutenance.Columns["Id"].Visible = false;
            
            // Configurer les en-têtes des colonnes
            if (dgSoutenance.Columns["Resultat"] != null)
                dgSoutenance.Columns["Resultat"].HeaderText = "Résultat";
            if (dgSoutenance.Columns["Memoire"] != null)
                dgSoutenance.Columns["Memoire"].HeaderText = "Mémoire";
            if (dgSoutenance.Columns["Date"] != null)
                dgSoutenance.Columns["Date"].HeaderText = "Date";
            if (dgSoutenance.Columns["Lieu"] != null)
                dgSoutenance.Columns["Lieu"].HeaderText = "Lieu";
            if (dgSoutenance.Columns["Mention"] != null)
                dgSoutenance.Columns["Mention"].HeaderText = "Mention";
        }

        /// <summary>
        /// Configuration des effets boutons
        /// </summary>
        private void ConfigurerEffetsBoutons()
        {
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            btnEdit.MouseEnter += (s, e) => btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.MouseLeave += (s, e) => btnEdit.BackColor = Color.FromArgb(52, 152, 219);

            btnRemove.MouseEnter += (s, e) => btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.MouseLeave += (s, e) => btnRemove.BackColor = Color.FromArgb(231, 76, 60);

            //btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            //btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        /// <summary>
        /// Ajouter une soutenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Soutenance soutenance = new Soutenance()
            {
                LieuSoutenance = txtLieu.Text,
                ResultatSoutenance = cbbResultat.Text,
                MentionSoutenance = txtMention.Text,
                ObservationsSoutenance = txtObservations.Text,
                IdMemoire = Convert.ToInt32(cbbMemoire.SelectedValue)
            };
            db.soutenances.Add(soutenance);
            db.SaveChanges();
            MessageBox.Show("Fonctionnalité d'ajout à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualiserGrid();
            Effacer();
        }

        /// <summary>
        /// Modifier les informations d'une soutenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSoutenance.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une soutenance à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)dgSoutenance.CurrentRow.Cells["Id"].Value;
                Soutenance soutenance = db.soutenances.Find(id);

                if (soutenance != null)
                {
                    soutenance.LieuSoutenance = txtLieu.Text;
                    soutenance.ResultatSoutenance = cbbResultat.Text;
                    soutenance.MentionSoutenance = txtMention.Text;
                    soutenance.ObservationsSoutenance = txtObservations.Text;
                    soutenance.IdMemoire = Convert.ToInt32(cbbMemoire.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserGrid();
                    Effacer();
                }
                else
                {
                    MessageBox.Show("Soutenance introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprimer une soutenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSoutenance.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une soutenance à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer cette soutenance ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = (int)dgSoutenance.CurrentRow.Cells["Id"].Value;
                    Soutenance soutenance = db.soutenances.Find(id);

                    if (soutenance != null)
                    {
                        db.soutenances.Remove(soutenance);
                        db.SaveChanges();
                        MessageBox.Show("Suppression réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualiserGrid();
                        Effacer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgSoutenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgSoutenance.CurrentRow != null)
            {
                try
                {
                    int id = (int)dgSoutenance.CurrentRow.Cells["Id"].Value;
                    Soutenance soutenance = db.soutenances.Find(id);
                    if (soutenance != null)
                    {
                        txtLieu.Text = soutenance.LieuSoutenance ?? "";
                        txtMention.Text = soutenance.MentionSoutenance ?? "";
                        txtObservations.Text = soutenance.ObservationsSoutenance ?? "";
                        
                        // Sélectionner le résultat
                        if (!string.IsNullOrEmpty(soutenance.ResultatSoutenance))
                        {
                            int index = cbbResultat.FindStringExact(soutenance.ResultatSoutenance);
                            if (index >= 0)
                            {
                                cbbResultat.SelectedIndex = index;
                            }
                            else
                            {
                                cbbResultat.Text = soutenance.ResultatSoutenance;
                            }
                        }
                        
                        // Recharger et sélectionner le mémoire
                        cbbMemoire.DataSource = filler.FillMemoire();
                        cbbMemoire.DisplayMember = "Text";
                        cbbMemoire.ValueMember = "Value";
                        
                        if (soutenance.IdMemoire.HasValue)
                        {
                            cbbMemoire.SelectedValue = soutenance.IdMemoire.Value.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Ne pas afficher d'erreur pour éviter de perturber l'utilisateur
                    // L'erreur sera gérée lors du clic sur le bouton Sélectionner
                }
            }
        }

        private void Effacer()
        {
            txtLieu.Clear();
            txtMention.Clear();
            txtObservations.Clear();
            cbbResultat.SelectedIndex = 0;
            cbbMemoire.SelectedIndex = 0;
            //dtpDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Selectionner une ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgSoutenance.CurrentRow != null)
                {
                    int id = (int)dgSoutenance.CurrentRow.Cells["Id"].Value;
                    Soutenance soutenance = db.soutenances.Find(id);
                    if (soutenance != null)
                    {
                        txtLieu.Text = soutenance.LieuSoutenance;
                        txtMention.Text = soutenance.MentionSoutenance;
                        txtObservations.Text = soutenance.ObservationsSoutenance;
                        
                        // Sélectionner le résultat (c'est un string, donc on utilise Text ou SelectedItem)
                        if (!string.IsNullOrEmpty(soutenance.ResultatSoutenance))
                        {
                            // Chercher l'item correspondant dans le ComboBox
                            int index = cbbResultat.FindStringExact(soutenance.ResultatSoutenance);
                            if (index >= 0)
                            {
                                cbbResultat.SelectedIndex = index;
                            }
                            else
                            {
                                // Si la valeur n'existe pas dans la liste, utiliser Text
                                cbbResultat.Text = soutenance.ResultatSoutenance;
                            }
                        }
                        
                        // Recharger le ComboBox mémoire pour s'assurer qu'il contient les données
                        cbbMemoire.DataSource = filler.FillMemoire();
                        cbbMemoire.DisplayMember = "Text";
                        cbbMemoire.ValueMember = "Value";
                        
                        // Sélectionner le mémoire correspondant
                        if (soutenance.IdMemoire.HasValue)
                        {
                            cbbMemoire.SelectedValue = soutenance.IdMemoire.Value.ToString();
                            
                            // Afficher le sujet du mémoire dans le ComboBox (déjà fait par SelectedValue)
                            // Le DisplayMember "Text" affichera automatiquement le sujet
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
