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
    public partial class frmChefDepartement : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmChefDepartement()
        {
            InitializeComponent();
        }
        public void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtMDP.Clear();
            cbbDepartement.SelectedIndex = -1;
            txtNom.Focus();
        }



        private void ChargerGrid()
        {
            dvgChefDepartement.DataSource = db.chefDepartements.Select(c => new
            {
                Id = c.IdUtilisateur,
                Prenom = c.PrenomUtilisateur,
                Nom = c.NomUtilisateur,
                Email = c.EmailUtilisateur,
                Telephone = c.TelUtilisateur,
                Departement = c.Departement.LibelleDepartement
            }).ToList();

            dvgChefDepartement.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbDepartement.SelectedValue == null)
            {
                MessageBox.Show("Veuillez choisir un département");
                return;
            }

            ChefDepartement chef = new ChefDepartement
            {
                NomUtilisateur = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                EmailUtilisateur = txtEmail.Text,
                TelUtilisateur = txtTel.Text,
                MotDePasse = txtMDP.Text,
                IdDepartement = (int)cbbDepartement.SelectedValue
            };

            db.chefDepartements.Add(chef);
            db.SaveChanges();

            MessageBox.Show("Chef ajouté avec succès !");
            Effacer();
            ChargerGrid();
        }
        private void ChargerDepartements()
        {
            cbbDepartement.DataSource = db.Departements.ToList();
            cbbDepartement.DisplayMember = "LibelleDepartement";
            cbbDepartement.ValueMember = "IdDepartement";
        }
        private void frmChefDepartement_Load(object sender, EventArgs e)
        {
            ChargerDepartements();
        }


        private void dvgChefDepartement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDepartement_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = dvgChefDepartement.CurrentRow;
            if (current == null) return;

            int id = (int)current.Cells["Id"].Value;

            var chefDepartement = db.chefDepartements.Find(id);
            if (chefDepartement == null)
            {
                MessageBox.Show("ChefDepartement introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chefDepartement.NomUtilisateur = txtNom.Text;
            chefDepartement.PrenomUtilisateur = txtPrenom.Text;
            chefDepartement.EmailUtilisateur = txtEmail.Text;
            chefDepartement.TelUtilisateur = txtTel.Text;
            chefDepartement.MotDePasse = txtMDP.Text;

            // CORRECTION
            chefDepartement.IdDepartement = (int)cbbDepartement.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("ChefDepartement modifié avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée
            if (dvgChefDepartement.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef de département.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère la ligne sélectionnée
            var row = dvgChefDepartement.CurrentRow;
            // Remplir les champs que tu veux modifier ou supprimer
            txtNom.Text = row.Cells["Nom"].Value?.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtTel.Text = row.Cells["Telephone"].Value?.ToString();
            txtMDP.Text = row.Cells["MotDePasse"]?.Value?.ToString();

            // Remplir le ComboBox Département
            int departementId = (int)row.Cells["IdDepartement"].Value;
            cbbDepartement.SelectedValue = departementId;

            MessageBox.Show("Ligne sélectionnée ! Vous pouvez maintenant modifier ou supprimer.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée
            if (dvgChefDepartement.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un chef de département à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demande confirmation
            var confirm = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce chef de département ?",
                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Récupère l'ID
            int id = (int)dvgChefDepartement.CurrentRow.Cells["Id"].Value;

            // Cherche dans la base
            var chefDepartement = db.chefDepartements.Find(id);
            if (chefDepartement == null)
            {
                MessageBox.Show("Chef de département introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Supprime de la base
            db.chefDepartements.Remove(chefDepartement);
            db.SaveChanges();

            MessageBox.Show("Chef de département supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Rafraîchir la grille et effacer les champs
            Effacer();
            ChargerGrid();
        }
    }
}
