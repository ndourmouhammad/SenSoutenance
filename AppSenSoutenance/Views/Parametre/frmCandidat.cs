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
    public partial class frmCandidat : Form
    {
        public frmCandidat()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmCandidat_Load(object sender, EventArgs e)
        {
            dgCandidat.DataSource = db.candidats.ToList();
        }

        /// <summary>
        /// Methode pour effacer les champs du formulaire
        /// </summary>
        
        public void effacer()
        {
            txtNomCandidat.Clear();
            txtPrenomCandidat.Clear();
            txtEmailCandidat.Clear();
            txtTelCandidat.Clear();
            txtMDPCandidat.Clear();
            txtMatricule.Clear();
            dgCandidat.DataSource = db.candidats.ToList();
            txtNomCandidat.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat()
            {
                NomUtilisateur = txtNomCandidat.Text,
                PrenomUtilisateur = txtPrenomCandidat.Text,
                EmailUtilisateur = txtEmailCandidat.Text,
                TelUtilisateur = txtTelCandidat.Text,
                MotDePasse = txtMDPCandidat.Text,
                MatriculeCandidat = txtMatricule.Text
            };
            db.candidats.Add(candidat);
            db.SaveChanges();
            MessageBox.Show("Candidat ajouté avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            effacer();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;

            var bound = current.DataBoundItem as AppSenSoutenance.Models.Candidat;
            if (bound == null) return;

            var candidat = db.candidats.Find(bound.IdUtilisateur);
            if (candidat == null)
            {
                MessageBox.Show("Candidat introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            candidat.NomUtilisateur = txtNomCandidat.Text;
            candidat.PrenomUtilisateur = txtPrenomCandidat.Text;
            candidat.EmailUtilisateur = txtEmailCandidat.Text;
            candidat.TelUtilisateur = txtTelCandidat.Text;
            candidat.MotDePasse = txtMDPCandidat.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.SaveChanges();
            MessageBox.Show("Candidat modifié avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;
            var bound = current.DataBoundItem as AppSenSoutenance.Models.Candidat;
            if (bound == null) return;
            var candidat = db.candidats.Find(bound.IdUtilisateur);
            if (candidat == null)
            {
                MessageBox.Show("Candidat introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.candidats.Remove(candidat);
            db.SaveChanges();
            MessageBox.Show("Candidat supprimé avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            effacer();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;

            var candidat = current.DataBoundItem as AppSenSoutenance.Models.Candidat;
            if (candidat == null) return;

            txtNomCandidat.Text = candidat.NomUtilisateur ?? "";
            txtPrenomCandidat.Text = candidat.PrenomUtilisateur ?? "";
            txtEmailCandidat.Text = candidat.EmailUtilisateur ?? "";
            txtTelCandidat.Text = candidat.TelUtilisateur ?? "";
            txtMDPCandidat.Text = candidat.MotDePasse ?? "";
            txtMatricule.Text = candidat.MatriculeCandidat ?? "";
        }

        
    }
}
