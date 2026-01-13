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
        public frmDepartement()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
        }
        int idSelectionne = 0;


        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (BdSenSoutenanceContext db = new BdSenSoutenanceContext())
            {
                Departement departement = new Departement()
                {
                    LibelleDepartement = txtNom.Text,
                    Code = txtCode.Text
                };

                db.Departements.Add(departement);
                db.SaveChanges();
            }

            DialogResult dialogResult = MessageBox.Show("Département ajouté avec succès !");
        }
        private void ChargerDepartements()
        {
            using (BdSenSoutenanceContext db = new BdSenSoutenanceContext())
            {
                dvgDepartement.DataSource = db.Departements.Select(d => new {
                    Id = d.IdDepartement,
                    Nom = d.LibelleDepartement,
                    Code = d.Code
                }).ToList();
                
                if (dvgDepartement.Columns["Id"] != null) dvgDepartement.Columns["Id"].Visible = false;
            }
        }
        private void FormDepartement_load(object sender, EventArgs e)
        {
            ChargerDepartements();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgDepartement.Rows[e.RowIndex];
                idSelectionne = Convert.ToInt32(row.Cells["Id"].Value);
                txtNom.Text = row.Cells["Nom"].Value.ToString();
                txtCode.Text = row.Cells["Code"].Value.ToString();

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (BdSenSoutenanceContext db = new BdSenSoutenanceContext())
            {
                Departement dept = db.Departements.Find(idSelectionne);
                if (dept != null)
                {
                    dept.LibelleDepartement = txtNom.Text;
                    dept.Code = txtCode.Text;
                    db.SaveChanges();
                    MessageBox.Show("Departement modifier");
                    ChargerDepartements();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show(" Veuillez selectionner un departement a modifier");

                }
            }
        }
        private void ClearFields()
        {
            txtNom.Text = "";
            txtCode.Text = "";
            idSelectionne = 0;
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            using (BdSenSoutenanceContext db = new BdSenSoutenanceContext())
            {
                Departement dept = db.Departements.Find(idSelectionne);
                if (dept != null)
                {
                    db.Departements.Remove(dept);
                    db.SaveChanges();
                    MessageBox.Show("Departement Supprimer");
                    ChargerDepartements();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Veuillez selectionner le departement a Supprimer");

                }
            }
        }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            var current = dvgDepartement.CurrentRow;
            if (current == null) return;

            txtNom.Text = current.Cells["Nom"].Value?.ToString() ?? "";
            txtCode.Text = current.Cells["Code"].Value?.ToString() ?? "";
           
        }
    }
}
