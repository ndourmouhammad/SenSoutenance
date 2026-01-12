using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Account
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
            ConfigureLayout();
            ConfigurerEffetsBoutons();
        }

        /// <summary>
        /// Appel du contexte de la base de données
        /// </summary>
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        /// <summary>
        /// Configure les propriétés d'affichage pour éviter le débordement à l'exécution.
        /// - Active le scrolling du formulaire si le contenu dépasse la taille.
        /// - Rend la grille responsive (ancrage + redimensionnement automatique des colonnes).
        /// - Autorise le redimensionnement des colonnes/lignes par l'utilisateur.
        /// </summary>
        private void ConfigureLayout()
        {
            // Permet l'apparition de barres de défilement si nécessaire
            this.AutoScroll = true;

            // Définit une taille minimale raisonnable pour éviter un rendu trop compact
            if (this.MinimumSize.Width < 800) this.MinimumSize = new Size(800, 600);

            // Si la grille existe, applique des règles de redimensionnement
            if (dgUtilisateurs != null)
            {
                // La grille suit les bords du formulaire — évite qu'elle déborde hors de la fenêtre
                dgUtilisateurs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Adapte automatiquement la largeur des colonnes pour occuper l'espace disponible
                dgUtilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Ajuste la hauteur des lignes pour le contenu ; utile si les cellules contiennent du texte long
                dgUtilisateurs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Autorise le redimensionnement manuel si l'utilisateur souhaite ajuster la vue
                dgUtilisateurs.AllowUserToResizeColumns = true;
                dgUtilisateurs.AllowUserToResizeRows = true;

                // Assure l'affichage des barres de défilement si nécessaire
                dgUtilisateurs.ScrollBars = ScrollBars.Both;

                // Améliore le rendu des en-têtes
                dgUtilisateurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Si vous utilisez AutoGenerateColumns = true (par défaut), gardez-le.
                // Si vous créez des colonnes manuellement dans le Designer, pensez à régler leurs AutoSizeMode.
            }
        }




        /// <summary>
        /// Réinitialiser le formulaire candidat après une opération CRUD
        /// </summary>
        private void ResetForm()
        {
            dgUtilisateurs.DataSource = db.candidats.Select(
                a=> new { a.IdUtilisateur, a.NomUtilisateur, a.PrenomUtilisateur, a.EmailUtilisateur, 
                    a.TelUtilisateur }).ToList();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtMatricule.Clear();
            txtNom.Focus();
        }

        /// <summary>
        /// Ajouter un utilisateur de type candidat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }

        /// <summary>
        /// Chargement du formulaire : on alimente le DataGridView avec la liste des utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ChargerSelonOnglet();
        }

        private void tabUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerSelonOnglet();
        }

        private void ChargerSelonOnglet()
        {
            if (tabUtilisateurs.SelectedIndex == 0) // Candidat
            {
                ResetForm();
                btnSelect.Visible = true;
                btnSelectP.Visible = false;
                btnSelectC.Visible = false;
            }
            else if (tabUtilisateurs.SelectedIndex == 1) // Professeur
            {
                ResetFormProfesseur();
                btnSelect.Visible = false;
                btnSelectP.Visible = true;
                btnSelectC.Visible = false;
            }
            else if (tabUtilisateurs.SelectedIndex == 2) // Chef
            {
                ResetFormChef();
                btnSelect.Visible = false;
                btnSelectP.Visible = false;
                btnSelectC.Visible = true;
            }
        }



        /// <summary>
        /// Modifier un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.SaveChanges();
            ResetForm();
        }

        /// <summary>
        /// sélectionner un utilisateur dans la grille pour modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgUtilisateurs.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgUtilisateurs.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgUtilisateurs.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgUtilisateurs.CurrentRow.Cells[4].Value.ToString();
            txtMatricule.Text = db.candidats.Find(
                int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString())
                ).MatriculeCandidat;
        }

        /// <summary>
        /// Supprimer un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);
            db.candidats.Remove(candidat);
            db.SaveChanges();
            ResetForm();
        }

        private void ResetFormProfesseur()
        {
            dgUtilisateurs.DataSource = db.professeurs.Select(
                a => new
                {
                    a.IdUtilisateur,
                    a.NomUtilisateur,
                    a.PrenomUtilisateur,
                    a.EmailUtilisateur,
                    a.TelUtilisateur
                }).ToList();
            txtPNom.Clear();
            txtPPrenom.Clear();
            txtPTel.Clear();
            txtPEmail.Clear();
            txtPSpecialite.Clear();
            txtPNom.Focus();
        }

        /// <summary>
        /// Ajouter un utilisateur de type professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPAjouter_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur();
            professeur.NomUtilisateur = txtPNom.Text;
            professeur.PrenomUtilisateur = txtPPrenom.Text;
            professeur.TelUtilisateur = txtPTel.Text;
            professeur.EmailUtilisateur = txtPEmail.Text;
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                professeur.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            db.professeurs.Add(professeur);
            db.SaveChanges();
            ResetFormProfesseur();
        }

        /// <summary>
        /// Modifier un utilisateur de type professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            professeur.NomUtilisateur = txtPNom.Text;
            professeur.PrenomUtilisateur = txtPPrenom.Text;
            professeur.TelUtilisateur = txtPTel.Text;
            professeur.EmailUtilisateur = txtPEmail.Text;
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            db.SaveChanges();
            ResetFormProfesseur();
        }

        /// <summary>
        /// Sélectionner un utilisateur de type professeur dans la grille pour modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectP_Click(object sender, EventArgs e)
        {
            txtPNom.Text = dgUtilisateurs.CurrentRow.Cells[1].Value.ToString();
            txtPPrenom.Text = dgUtilisateurs.CurrentRow.Cells[2].Value.ToString();
            txtPEmail.Text = dgUtilisateurs.CurrentRow.Cells[3].Value.ToString();
            txtPTel.Text = dgUtilisateurs.CurrentRow.Cells[4].Value.ToString();
            txtPSpecialite.Text = db.professeurs.Find(
                int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString())
                ).SpecialiteProfesseur;
        }

        /// <summary>
        /// Supprimer un utilisateur de type professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDelete_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            db.professeurs.Remove(professeur);
            db.SaveChanges();
            ResetFormProfesseur();
        }

        /// <summary>
        /// Ajouter un utilisateur de type chef de département
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAjouter_Click(object sender, EventArgs e)
        {
            ChefDepartement chef = new ChefDepartement();
            chef.NomUtilisateur = txtCNom.Text;
            chef.PrenomUtilisateur = txtCPrenom.Text;
            chef.TelUtilisateur = txtCTel.Text;
            chef.EmailUtilisateur = txtCEmail.Text;
            chef.IdDepartement = int.Parse( txtCDepartement.Text);
            using (MD5 md5Hash = MD5.Create())
            {
                chef.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            db.chefDepartements.Add(chef);
            db.SaveChanges();
            ResetFormChef();
        }

        /// <summary>
        /// Réinitialiser le formulaire chef de département après une opération CRUD
        /// </summary>
        private void ResetFormChef()
        {
            dgUtilisateurs.DataSource = db.chefDepartements.Select(
                a => new
                {
                    a.IdUtilisateur,
                    a.NomUtilisateur,
                    a.PrenomUtilisateur,
                    a.EmailUtilisateur,
                    a.TelUtilisateur
                }).ToList();
            txtCNom.Clear();
            txtCPrenom.Clear();
            txtCTel.Clear();
            txtCEmail.Clear();
            txtCDepartement.Clear();
            txtCNom.Focus();
        }

        private void btnSelectC_Click(object sender, EventArgs e)
        {
            txtCNom .Text = dgUtilisateurs.CurrentRow.Cells[1].Value.ToString();
            txtCPrenom.Text = dgUtilisateurs.CurrentRow.Cells[2].Value.ToString();
            txtCEmail.Text = dgUtilisateurs.CurrentRow.Cells[3].Value.ToString();
            txtCTel.Text = dgUtilisateurs.CurrentRow.Cells[4].Value.ToString();
            txtCDepartement.Text = db.chefDepartements.Find(
                int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString())
                ).IdDepartement.ToString();
        }

        private void btnCModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement chef = db.chefDepartements.Find(id);
            chef.NomUtilisateur = txtCNom.Text;
            chef.PrenomUtilisateur = txtCPrenom.Text;
            chef.TelUtilisateur = txtCTel.Text;
            chef.EmailUtilisateur = txtCEmail.Text;
            chef.IdDepartement = int.Parse(txtCDepartement.Text);
            db.SaveChanges();
            ResetFormChef();
        }

        private void btnCSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateurs.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement chef = db.chefDepartements.Find(id);
            db.chefDepartements.Remove(chef);
            db.SaveChanges();
            ResetFormChef();
        }
        private void ConfigurerEffetsBoutons()
        {
            // Candidat
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnEdit.MouseEnter += (s, e) => btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.MouseLeave += (s, e) => btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnRemove.MouseEnter += (s, e) => btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.MouseLeave += (s, e) => btnRemove.BackColor = Color.FromArgb(231, 76, 60);

            // Professeur
            btnPAjouter.MouseEnter += (s, e) => btnPAjouter.BackColor = Color.FromArgb(39, 174, 96);
            btnPAjouter.MouseLeave += (s, e) => btnPAjouter.BackColor = Color.FromArgb(46, 204, 113);
            btnPEdit.MouseEnter += (s, e) => btnPEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnPEdit.MouseLeave += (s, e) => btnPEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnPDelete.MouseEnter += (s, e) => btnPDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnPDelete.MouseLeave += (s, e) => btnPDelete.BackColor = Color.FromArgb(231, 76, 60);

            // Chef de projet
            btnCAjouter.MouseEnter += (s, e) => btnCAjouter.BackColor = Color.FromArgb(39, 174, 96);
            btnCAjouter.MouseLeave += (s, e) => btnCAjouter.BackColor = Color.FromArgb(46, 204, 113);
            btnCModifier.MouseEnter += (s, e) => btnCModifier.BackColor = Color.FromArgb(41, 128, 185);
            btnCModifier.MouseLeave += (s, e) => btnCModifier.BackColor = Color.FromArgb(52, 152, 219);
            btnCSupprimer.MouseEnter += (s, e) => btnCSupprimer.BackColor = Color.FromArgb(192, 57, 43);
            btnCSupprimer.MouseLeave += (s, e) => btnCSupprimer.BackColor = Color.FromArgb(231, 76, 60);

            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
