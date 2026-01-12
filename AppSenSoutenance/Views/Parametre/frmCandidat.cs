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
            ConfigureLayout();
            ConfigurerEffetsBoutons();
        }

        /// <summary>
        /// Configure les propriétés d'affichage pour éviter le débordement
        /// </summary>
        private void ConfigureLayout()
        {
            // Configuration du DataGridView
            if (dgCandidat != null)
            {
                dgCandidat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgCandidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgCandidat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgCandidat.AllowUserToResizeColumns = true;
                dgCandidat.AllowUserToResizeRows = true;
                dgCandidat.ScrollBars = ScrollBars.Both;
                dgCandidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgCandidat.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();


        /// <summary>
        /// Methode pour charger les candidats dans le datagridview
        /// </summary>
        private void frmCandidat_Load(object sender, EventArgs e)
        {
            effacer();
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
            dgCandidat.DataSource = db.candidats.Select(c => new {
                Id = c.IdUtilisateur,
                Prenom = c.PrenomUtilisateur,
                Nom = c.NomUtilisateur,
                Email = c.EmailUtilisateur,
                Telephone = c.TelUtilisateur,
                c.MatriculeCandidat
            }).ToList();
            
            if (dgCandidat.Columns["Id"] != null) dgCandidat.Columns["Id"].Visible = false;
            dgCandidat.Columns["MatriculeCandidat"].HeaderText = "Matricule";
            
            txtNomCandidat.Focus();
        }

        /// <summary>
        /// Methode pour ajouter un candidat
        /// </summary>
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


        /// <summary>
        ///     Methode pour modifier un candidat
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;

            int id = (int)current.Cells["Id"].Value;

            var candidat = db.candidats.Find(id);
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

        /// <summary>
        /// Methode pour supprimer un candidat
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;
            int id = (int)current.Cells["Id"].Value;
            var candidat = db.candidats.Find(id);
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

        /// <summary>
        /// Methode pour selectionner un candidat dans le datagridview
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var current = dgCandidat.CurrentRow;
            if (current == null) return;

            txtNomCandidat.Text = current.Cells["Nom"].Value?.ToString() ?? "";
            txtPrenomCandidat.Text = current.Cells["Prenom"].Value?.ToString() ?? "";
            txtEmailCandidat.Text = current.Cells["Email"].Value?.ToString() ?? "";
            txtTelCandidat.Text = current.Cells["Telephone"].Value?.ToString() ?? "";
            txtMatricule.Text = current.Cells["MatriculeCandidat"].Value?.ToString() ?? "";
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
