using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
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
        FilerList filler = new FilerList();

        public frmChefDepartement()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
            this.Load += FrmChefDepartement_Load;

            // Attacher les événements aux boutons
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            btnClose.Click += btnClose_Click;
            dgChef.CellClick += dgChef_CellClick;
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
            dgChef.DataSource = db.chefDepartements.Select(c => new
            {
                Id = c.IdUtilisateur,
                Prenom = c.PrenomUtilisateur,
                Nom = c.NomUtilisateur,
                Email = c.EmailUtilisateur,
                Telephone = c.TelUtilisateur,
                Departement = c.Departement.LibelleDepartement
            }).ToList();

            if (dgChef.Columns["Id"] != null)
                dgChef.Columns["Id"].Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Logique d'ajout à implémenter
            MessageBox.Show("Fonctionnalité d'ajout à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Logique de modification à implémenter
            MessageBox.Show("Fonctionnalité de modification à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Logique de suppression à implémenter
            MessageBox.Show("Fonctionnalité de suppression à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgChef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgChef.Rows[e.RowIndex];
                txtPrenom.Text = row.Cells["Prenom"].Value?.ToString();
                txtNom.Text = row.Cells["Nom"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtTel.Text = row.Cells["Telephone"].Value?.ToString();
                // Sélectionner le département dans le combo si nécessaire
            }
        }

        private void Effacer()
        {
            txtPrenom.Clear();
            txtNom.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtMDP.Clear();
            cbbDepartement.SelectedIndex = 0;
        }
    }
}
