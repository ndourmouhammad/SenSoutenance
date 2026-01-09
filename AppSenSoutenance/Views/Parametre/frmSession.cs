using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        // On initialise le contexte une seule fois pour toute la classe
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filler = new FilerList();

        public frmSession()
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
            if (dgSession != null)
            {
                dgSession.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgSession.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgSession.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgSession.AllowUserToResizeColumns = true;
                dgSession.AllowUserToResizeRows = true;
                dgSession.ScrollBars = ScrollBars.Both;
                dgSession.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgSession.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        /// <summary>
        /// Methode pour charger les sessions dans le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmSession_Load(object sender, EventArgs e)
        {
            RafraichirInterface();
        }

        // --- ACTIONS ---

        /// <summary>
        /// Methode pour ajouter une nouvelle session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationFormulaire())
            {
                Session session = new Session();
                session.LibelleSession = txtSession.Text.Trim();
                session.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

                db.sessions.Add(session);
                db.SaveChanges();

                MessageBox.Show("Session ajoutée avec succès !");
                RafraichirInterface();
            }
        }

        /// <summary>
        /// Methode pour selectionner une session dans le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow != null)
            {
                // On utilise EXACTEMENT le nom défini dans le Select de RafraichirInterface
                int id = (int)dgSession.CurrentRow.Cells["Id"].Value;

                Session session = db.sessions.Find(id);
                if (session != null)
                {
                    txtSession.Text = session.LibelleSession;
                    cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique.ToString();
                }
            }
        }

        /// <summary>
        /// Methode pour modifier une session sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow != null && ValidationFormulaire())
            {
                int id = (int)dgSession.CurrentRow.Cells["Id"].Value;
                Session session = db.sessions.Find(id);

                if (session != null)
                {
                    session.LibelleSession = txtSession.Text.Trim();
                    session.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

                    db.SaveChanges();
                    MessageBox.Show("Modification réussie !");
                    RafraichirInterface();
                }
            }
        }

        /// <summary>
        /// methode pour supprimer une session sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow != null)
            {
                if (MessageBox.Show("Supprimer cette session ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dgSession.CurrentRow.Cells["Id"].Value;
                    Session session = db.sessions.Find(id);

                    if (session != null)
                    {
                        db.sessions.Remove(session);
                        db.SaveChanges();
                        RafraichirInterface();
                    }
                }
            }
        }

        /// <summary>
        /// Methode pour rafraichir l'interface
        /// </summary>  
        private void RafraichirInterface()
        {
            txtSession.Text = string.Empty;

            // 1. Recharger la liste déroulante
            cbbAnneeAcademique.DataSource = filler.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";

            // 2. Recharger le tableau avec des noms de colonnes clairs
            dgSession.DataSource = db.sessions.Select(s => new
            {
                Id = s.IdSession, // Nom de colonne utilisé par les boutons
                Session = s.LibelleSession,
                idAnneAcademique = s.IdAnneeAcademique,
                Annee = s.AnneeAcademique.LibelleAnneeAcademique
            }).ToList();

            if (cbbAnneeAcademique.Items.Count > 0)
                cbbAnneeAcademique.SelectedIndex = 0;

            txtSession.Focus();
        }

        /// <summary>
        /// Validation du formulaire
        /// </summary>
        private bool ValidationFormulaire()
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé de la session.");
                return false;
            }

            if (cbbAnneeAcademique.SelectedValue == null || cbbAnneeAcademique.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Methode pour rechercher des sessions
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.sessions.ToList();

            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession
                .Contains(txtRSession.Text)).ToList();
            }

            if(txtRAnneeAcademique.Text != "")
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique
                .Contains(txtRAnneeAcademique.Text)).ToList();
            }

            dgSession.DataSource = liste;
        }
    }
}