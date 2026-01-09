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
        }


        /// <summary>
        /// Contexte de la base de données
        /// </summary>
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        
        /// <summary>
        /// Configure les propriétés d'affichage pour éviter le débordement à l'exécution.
        /// </summary>
        private void ConfigureLayout()
        {
            this.AutoScroll = true;
            if (this.MinimumSize.Width < 800) this.MinimumSize = new Size(800, 600);
            
            if (dgProfesseur != null)
            {
                dgProfesseur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgProfesseur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgProfesseur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgProfesseur.AllowUserToResizeColumns = true;
                dgProfesseur.AllowUserToResizeRows = true;
                dgProfesseur.ScrollBars = ScrollBars.Both;
                dgProfesseur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Methode pour charger les professeurs dans le datagridview
        /// </summary>
        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            dgProfesseur.DataSource = db.professeurs.ToList();
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
            dgProfesseur.DataSource = db.professeurs.ToList();
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
            var bound = current.DataBoundItem as AppSenSoutenance.Models.Professeur;
            if (bound == null) return;

            txtNomProfesseur.Text = bound.NomUtilisateur;
            txtPrenomProfesseur.Text = bound.PrenomUtilisateur;
            txtEmailProfesseur.Text = bound.EmailUtilisateur;
            txtTelProfesseur.Text = bound.TelUtilisateur;
            txtMDPProfesseur.Text = bound.MotDePasse;
            txtSpecialite.Text = bound.SpecialiteProfesseur;

        }

        /// <summary>
        /// Methode pour supprimer un professeur
        /// </summary>
        /// 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var current = dgProfesseur.CurrentRow;
            if (current == null) return;
            var bound = current.DataBoundItem as AppSenSoutenance.Models.Professeur;
            if (bound == null) return;
            var professeur = db.professeurs.Find(bound.IdUtilisateur);
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
            var bound = current.DataBoundItem as AppSenSoutenance.Models.Professeur;
            if (bound == null) return;

            var professeur = db.professeurs.Find(bound.IdUtilisateur);
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
    }
}
