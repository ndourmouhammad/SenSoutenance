using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filler = new FilerList();

        public frmDepartement()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
            this.Load += FrmChefDepartement_Load;

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            btnClose.Click += btnClose_Click;
            dgChefDepartement.CellClick += dgChefDepartement_CellClick;
        }

        
        private string HashMotDePasse(string mdp)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                return Convert.ToBase64String(bytes);
            }
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtMDP.Clear();
            txtMatricule.Clear();
            cbbDepartement.SelectedIndex = 0;
            txtNom.Focus();
        }

       
        private void FrmChefDepartement_Load(object sender, EventArgs e)
        {
            ChargerDepartements();
            ActualiserGrid();
        }

        private void ChargerDepartements()
        {
            cbbDepartement.DataSource = filler.FillDepartement();
            cbbDepartement.DisplayMember = "Text";
            cbbDepartement.ValueMember = "Value";
        }

        private void ActualiserGrid()
        {
            dvgChefDepartement.DataSource = db.chefDepartements.Select(c => new
            {
                Id = c.IdUtilisateur,
                Prenom = c.PrenomUtilisateur,
                Nom = c.NomUtilisateur,
                Email = c.EmailUtilisateur,
                Telephone = c.TelUtilisateur,
                Matricule = c.MatriculeChefDepartement,
                Departement = c.Departement.LibelleDepartement
            }).ToList();

            if (dgChefDepartement.Columns["Id"] != null)
                dgChefDepartement.Columns["Id"].Visible = false;
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomChefDepartement.Text) ||
                string.IsNullOrWhiteSpace(txtPrenomChefDepartement.Text) ||
                string.IsNullOrWhiteSpace(txtMatriculeChefDepartement.Text) ||
                string.IsNullOrWhiteSpace(txtMDPChefDepartement.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = db.chefDepartements
                .Any(c => c.MatriculeChefDepartement == txtMatriculeChefDepartement.Text);

            if (existe)
            {
                MessageBox.Show("Ce matricule existe déjà.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChefDepartement chefDepartement = new ChefDepartement
            {
                NomUtilisateur = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                EmailUtilisateur = txtEmail.Text,
                TelUtilisateur = txtTelChefDepartement.Text,
                MotDePasse = HashMotDePasse(txtMDP.Text),
                MatriculeChefDepartement = txtMatricule.Text,
                IdDepartement = (int)cbbDepartement.SelectedValue
            };

            db.chefDepartements.Add(chefDepartement);
            db.SaveChanges();

            MessageBox.Show("Chef de département ajouté avec succès!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Effacer();
            ActualiserGrid();
        }

        
        private void dgChefDepartement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgChefDepartement.Rows[e.RowIndex];
            txtNomChefDepartement.Text = row.Cells["Nom"].Value?.ToString();
            txtPrenomChefDepartement.Text = row.Cells["Prenom"].Value?.ToString();
            txtEmailChefDepartement.Text = row.Cells["Email"].Value?.ToString();
            txtTelChefDepartement.Text = row.Cells["Telephone"].Value?.ToString();
            txtMatriculeChefDepartement.Text = row.Cells["Matricule"].Value?.ToString();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dvgChefDepartement.CurrentRow == null) return;

            int id = (int)dvgChefDepartement.CurrentRow.Cells["Id"].Value;
            var chefDepartement = db.chefDepartements.Find(id);

            if (chefDepartement == null)
            {
                MessageBox.Show("ChefDepartement introuvable.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chefDepartement.NomUtilisateur = txtNom.Text;
            chefDepartement.PrenomUtilisateur = txtPrenom.Text;
            chefDepartement.EmailUtilisateur = txtEmail.Text;
            chefDepartement.TelUtilisateur = txtTel.Text;
            chefDepartement.MatriculeChefDepartement = txtMatricule.Text;
            chefDepartement.IdDepartement = (int)cbbDepartement.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("Chef de département modifié avec succès!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Effacer();
            ActualiserGrid();
        }

        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dvgChefDepartement.CurrentRow == null) return;

            int id = (int)dgChefDepartement.CurrentRow.Cells["Id"].Value;
            var chefDepartement = db.chefDepartements.Find(id);

            if (chefDepartement == null)
            {
                MessageBox.Show("ChefDepartement introuvable.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.chefDepartements.Remove(chefDepartement);
            db.SaveChanges();

            MessageBox.Show("Chef de département supprimé avec succès!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Effacer();
            ActualiserGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurerEffetsBoutons()
        {
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void frmChefDepartement_Load_1(object sender, EventArgs e)
        {

        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomCandidat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMDPCandidat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCandidat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
