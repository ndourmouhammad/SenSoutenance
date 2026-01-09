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
        /// Ajouter un utilisateur de type candidat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
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
        /// Réinitialiser le formulaire
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

        private void tabCandidat_Click(object sender, EventArgs e)
        {

        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void tabProfesseur_Click(object sender, EventArgs e)
        {

        }

        
    }
}
