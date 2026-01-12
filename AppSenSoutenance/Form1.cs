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

namespace AppSenSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        /// <summary>
        /// Méthode de connexion de l'utilisateur
        /// </summary>
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string email = txtIdentifiant.Text.Trim();
            string password = txtMotDePasse.Text.Trim();

            // Recherche de l'utilisateur (tous types)
            Utilisateur utilisateur = db.utilisateurs.FirstOrDefault(u => u.EmailUtilisateur == email);

            if (utilisateur == null)
            {
                MessageBox.Show("Email ou mot de passe incorrect");
                return;
            }

            // Calcul du hash du mot de passe saisi
            string hashInput;
            using (MD5 md5 = MD5.Create())
            {
                hashInput = Shared.Crypted.GetMd5Hash(md5, password);
            }

            // 🔐 COMPARAISON
            if (!string.Equals(hashInput, utilisateur.MotDePasse, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email ou mot de passe incorrect");
                return;
            }

            // Déterminer le profil
            string profil = "Inconnu";
            if (utilisateur is Admin) profil = "Admin";
            else if (utilisateur is ChefDepartement) profil = "ChefDepartement";
            else if (utilisateur is Professeur) profil = "Professeur";
            else if (utilisateur is Candidat) profil = "Candidat";

            // ✅ Accès
            frmMDI mdi = new frmMDI();
            // mdi.profil = profil;
            mdi.profil = "Admin";
            mdi.Show();
            this.Hide();
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
