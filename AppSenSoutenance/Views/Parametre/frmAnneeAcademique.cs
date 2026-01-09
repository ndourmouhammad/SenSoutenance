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
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
            ConfigureLayout();
        }

        /// <summary>
        /// Configure les propriétés d'affichage pour éviter le débordement
        /// </summary>
        private void ConfigureLayout()
        {
            // Configuration du DataGridView
            if (dgAnneeAcademique != null)
            {
                dgAnneeAcademique.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgAnneeAcademique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgAnneeAcademique.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgAnneeAcademique.AllowUserToResizeColumns = true;
                dgAnneeAcademique.AllowUserToResizeRows = true;
                dgAnneeAcademique.ScrollBars = ScrollBars.Both;
                dgAnneeAcademique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgAnneeAcademique.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        // Contexte de la base de données utilisé pour les opérations CRUD
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();


        // Chargement du formulaire : on alimente le DataGridView avec la liste des années académiques
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            dgAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
        }

        // Méthode utilitaire pour réinitialiser les champs du formulaire et rafraîchir la grille
        public void effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
            txtLibelleAnneeAcademique.Focus();
        }

        // Ajout d'une nouvelle année académique : construction de l'entité puis sauvegarde en base
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text
                )
            };
            db.anneeAcademiques.Add( anneeAcademique );
            db.SaveChanges();
            effacer();
        }

        // Modification d'une année académique sélectionnée dans la grille
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneeAcademiques.Find( id );
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            db.SaveChanges();
            effacer();
        }

        // Suppression de l'année académique sélectionnée
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneeAcademiques.Find(id);
            db.anneeAcademiques.Remove( anneeAcademique );
            db.SaveChanges();
            effacer();
        }

        // Sélection d'une ligne : remplissage des champs depuis la grille
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Remplit les champs à partir des colonnes 1 et 2.
            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
