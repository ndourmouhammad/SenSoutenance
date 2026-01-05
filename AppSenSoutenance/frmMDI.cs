using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenSoutenance.Views;
using AppSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;

namespace AppSenSoutenance
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Methode permettant de fermer tous les forms dans le parentMDI 
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            // On parcourt tous les formulaires enfants
            foreach (Form f in charr)
            {
                // On les ferme
                f.Close();
            }
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion connexion = new frmConnexion();
            connexion.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAnneeAcademique anneeAcademique = new frmAnneeAcademique();
            anneeAcademique.MdiParent = this;
            anneeAcademique.Show();
            anneeAcademique.WindowState = FormWindowState.Maximized;
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSession session = new frmSession();
            session.MdiParent = this;
            session.Show();
            session.WindowState = FormWindowState.Maximized;
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur professeur = new frmProfesseur();
            professeur.MdiParent = this;
            professeur.Show();
            professeur.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);  
        }

        private void memoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMemoire memoire = new frmMemoire();
            memoire.MdiParent = this;
            memoire.Show();
            memoire.WindowState = FormWindowState.Maximized;
        }

        private void soutenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSoutenance soutenance = new frmSoutenance();
            soutenance.MdiParent = this;
            soutenance.Show();
            soutenance.WindowState = FormWindowState.Maximized;
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmDepartement departement = new frmDepartement();
            departement.MdiParent = this;
            departement.Show();
            departement.WindowState = FormWindowState.Maximized;
        }

        private void candidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCandidat candidat = new frmCandidat();
            candidat.MdiParent = this;
            candidat.Show();
            candidat.WindowState = FormWindowState.Maximized;
        }

        private void chefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmChefDepartement chefDepartement = new frmChefDepartement();
            chefDepartement.MdiParent = this;
            chefDepartement.Show();
            chefDepartement.WindowState = FormWindowState.Maximized;
        }
    }
}
