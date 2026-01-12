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
            Utilisateur utilisateur =
                (Utilisateur)db.candidats.FirstOrDefault(u => u.EmailUtilisateur == email)
                ?? (Utilisateur)db.professeurs.FirstOrDefault(u => u.EmailUtilisateur == email)
                ?? (Utilisateur)db.chefDepartements.FirstOrDefault(u => u.EmailUtilisateur == email);

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

            // 🔐 COMPARAISON OBLIGATOIRE
            if (!string.Equals(hashInput, utilisateur.MotDePasse, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email ou mot de passe incorrect");
                return;
            }

            // ✅ Connexion réussie
            MessageBox.Show("Connexion réussie");

            frmMDI mdi = new frmMDI();
            // mdi.profil = utilisateur.GetType().Name; // Candidat / Professeur / ChefDepartement
            mdi.profil = "Admin"; // si on veut tester les fonctionnalités admin
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
    }
}
