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
    }
}
