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
        }
        int idSelectionne = 0;


        

        private void button1_Click(object sender, EventArgs e)
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
                dvgDepartement.DataSource = db.Departements.ToList();
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
                txtNom.Text = row.Cells["NomDepartement"].Value.ToString();
                txtCode.Text = row.Cells["code"].Value.ToString();

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
        private void button3_Click(object sender, EventArgs e)
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
    }
}
