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
    public partial class frmProfesseur : Form
    {
        public frmProfesseur()
        {
            InitializeComponent();
            ConfigureLayout();
            ConfigurerEffetsBoutons();
        }

        /// <summary>
        /// Configure les propriétés d'affichage pour éviter le débordement
        /// </summary>
        private void ConfigureLayout()
        {
            // Configuration du DataGridView
            if (dgProfesseur != null)
            {
                dgProfesseur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgProfesseur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgProfesseur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgProfesseur.AllowUserToResizeColumns = true;
                dgProfesseur.AllowUserToResizeRows = true;
                dgProfesseur.ScrollBars = ScrollBars.Both;
                dgProfesseur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgProfesseur.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }


        /// <summary>
        /// Contexte de la base de données
        /// </summary>
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        /// <summary>
        /// Methode pour charger les professeurs dans le datagridview
        /// </summary>
        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            effacer();
        }

        /// <summary>
        /// Methode pour effacer les champs du formulaire
        /// </summary>
        /// 

        public void effacer()
        {
            txtNomProfesseur.Clear();
            txtPrenomProfesseur.Clear();
            txtEmailProfesseur.Clear();
            txtTelProfesseur.Clear();
            txtMDPProfesseur.Clear();
            txtSpecialite.Clear();
            dgProfesseur.DataSource = db.professeurs.Select(p => new {
                Id = p.IdUtilisateur,
                Prenom = p.PrenomUtilisateur,
                Nom = p.NomUtilisateur,
                Email = p.EmailUtilisateur,
                Telephone = p.TelUtilisateur,
                Specialite = p.SpecialiteProfesseur
            }).ToList();

            if (dgProfesseur.Columns["Id"] != null) dgProfesseur.Columns["Id"].Visible = false;

            txtNomProfesseur.Focus();
        }



        /// <summary>
        /// Methode pour ajouter un professeur
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur()
            {
                NomUtilisateur = txtNomProfesseur.Text,
                PrenomUtilisateur = txtPrenomProfesseur.Text,
                EmailUtilisateur = txtEmailProfesseur.Text,
                TelUtilisateur = txtTelProfesseur.Text,
                MotDePasse = txtMDPProfesseur.Text,
                SpecialiteProfesseur = txtSpecialite.Text
            };
            db.professeurs.Add(professeur);
            db.SaveChanges();
            effacer();
        }

        /// <summary>
        /// Methode pour selectionner un professeur
        /// </summary>
        /// 
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var current = dgProfesseur.CurrentRow;
            if (current == null) return;

            txtNomProfesseur.Text = current.Cells["Nom"].Value?.ToString() ?? "";
            txtPrenomProfesseur.Text = current.Cells["Prenom"].Value?.ToString() ?? "";
            txtEmailProfesseur.Text = current.Cells["Email"].Value?.ToString() ?? "";
            txtTelProfesseur.Text = current.Cells["Telephone"].Value?.ToString() ?? "";
            txtSpecialite.Text = current.Cells["Specialite"].Value?.ToString() ?? "";
        }

        /// <summary>
        /// Methode pour supprimer un professeur
        /// </summary>
        /// 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var current = dgProfesseur.CurrentRow;
            if (current == null) return;
            int id = (int)current.Cells["Id"].Value;
            var professeur = db.professeurs.Find(id);
            if (professeur == null)
            {
                MessageBox.Show("Professeur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.professeurs.Remove(professeur);
            db.SaveChanges();
            effacer();
        }

        /// <summary>
        /// Methode pour modifier un professeur
        /// </summary>
        ///

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = dgProfesseur.CurrentRow;
            if (current == null) return;
            int id = (int)current.Cells["Id"].Value;

            var professeur = db.professeurs.Find(id);
            if (professeur == null)
            {
                MessageBox.Show("Professeur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            professeur.NomUtilisateur = txtNomProfesseur.Text;
            professeur.PrenomUtilisateur = txtPrenomProfesseur.Text;
            professeur.EmailUtilisateur = txtEmailProfesseur.Text;
            professeur.TelUtilisateur = txtTelProfesseur.Text;
            professeur.MotDePasse = txtMDPProfesseur.Text;
            professeur.SpecialiteProfesseur = txtSpecialite.Text;
            db.SaveChanges();
            effacer();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}