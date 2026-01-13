using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        // Contexte de la base de données utilisé pour les opérations CRUD
        private BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private FilerList filler = new FilerList();

        public frmSession()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();

        }

        #region Événements de chargement

        /// <summary>
        /// Chargement du formulaire : initialisation de l'interface
        /// </summary>
        private void frmSession_Load(object sender, EventArgs e)
        {
            try
            {
                RafraichirInterface();
                btnSelect.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Libération des ressources lors de la fermeture du formulaire
        /// </summary>
        private void FrmSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }

        #endregion

        #region Actions CRUD

        /// <summary>
        /// Ajoute une nouvelle session dans la base de données
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationFormulaire())
                {
                    Session session = new Session
                    {
                        LibelleSession = txtSession.Text.Trim(),
                        IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue)
                    };
                    
                    // Debug message pour confirmer les données avant l'insertion
                    string debugMsg = $"Session: {session.LibelleSession}\nAnnée: {cbbAnneeAcademique.Text} (ID: {session.IdAnneeAcademique})";
                    MessageBox.Show(debugMsg, "Debug Session", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.sessions.Add(session);
                    db.SaveChanges();

                    MessageBox.Show("Session ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                // Diagnostic détaillé pour identifier la source exacte de la NullReferenceException
                string errorDetail = $"Erreur lors de l'ajout : {ex.Message}\n\n" +
                                   $"Type: {ex.GetType().FullName}\n" +
                                   $"StackTrace: {ex.StackTrace}\n\n" +
                                   "Veuillez envoyer une capture d'écran de ce message.";
                MessageBox.Show(errorDetail, "Erreur Critique (Diagnostic)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sélectionne une session dans le DataGridView et remplit les champs du formulaire
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSession.CurrentRow != null)
                {
                    int id = (int)dgSession.CurrentRow.Cells["Id"].Value;

                    Session session = db.sessions.Find(id);
                    if (session != null)
                    {
                        txtSession.Text = session.LibelleSession;
                        cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
                    }
                    else
                    {
                        MessageBox.Show("Session introuvable.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifie la session sélectionnée
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSession.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une session à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidationFormulaire()) return;

                int id = (int)dgSession.CurrentRow.Cells["Id"].Value;
                Session session = db.sessions.Find(id);

                if (session != null)
                {
                    session.LibelleSession = txtSession.Text.Trim();
                    session.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

                    db.SaveChanges();
                    MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
                else
                {
                    MessageBox.Show("Session introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime la session sélectionnée après confirmation
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSession.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une session à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer cette session ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = (int)dgSession.CurrentRow.Cells["Id"].Value;
                    Session session = db.sessions.Find(id);

                    if (session != null)
                    {
                        db.sessions.Remove(session);
                        db.SaveChanges();
                        MessageBox.Show("Suppression réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Effacer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Recherche

        /// <summary>
        /// Recherche des sessions selon les critères saisis
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var liste = db.sessions.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtRSession.Text))
                {
                    string recherche = txtRSession.Text.Trim().ToLower();
                    liste = liste.Where(s => s.LibelleSession != null && s.LibelleSession.ToLower().Contains(recherche));
                }

                if (!string.IsNullOrWhiteSpace(txtRAnneeAcademique.Text))
                {
                    string rechercheAnnee = txtRAnneeAcademique.Text.Trim().ToLower();
                    liste = liste.Where(s => s.AnneeAcademique != null && s.AnneeAcademique.LibelleAnneeAcademique.ToLower().Contains(rechercheAnnee));
                }

                dgSession.DataSource = liste.Select(s => new
                {
                    Id = s.IdSession,
                    Session = s.LibelleSession,
                    idAnneAcademique = s.IdAnneeAcademique,
                    Annee = s.AnneeAcademique != null ? s.AnneeAcademique.LibelleAnneeAcademique : "N/A"
                }).ToList();

                if (!liste.Any())
                {
                    MessageBox.Show("Aucune session trouvée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Réinitialise les critères de recherche et affiche toutes les sessions
        /// </summary>
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtRSession.Clear();
                txtRAnneeAcademique.Clear();
                RafraichirInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Méthodes utilitaires

        /// <summary>
        /// Rafraîchit l'interface : réinitialise les champs et recharge les données
        /// </summary>
        private void RafraichirInterface()
        {
            try
            {
                txtSession.Clear();
                txtRSession.Clear();
                txtRAnneeAcademique.Clear();

                cbbAnneeAcademique.DataSource = filler.FillAnneeAcademique();
                cbbAnneeAcademique.DisplayMember = "Text";
                cbbAnneeAcademique.ValueMember = "Value";

                dgSession.DataSource = db.sessions.Select(s => new
                {
                    Id = s.IdSession,
                    Session = s.LibelleSession,
                    idAnneAcademique = s.IdAnneeAcademique,
                    Annee = s.AnneeAcademique != null ? s.AnneeAcademique.LibelleAnneeAcademique : "N/A"
                }).ToList();

                if (cbbAnneeAcademique.Items.Count > 0)
                    cbbAnneeAcademique.SelectedIndex = 0;

                ConfigurerDataGridView();
                txtSession.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurerDataGridView()
        {
            if (dgSession.ColumnCount > 0)
            {
                dgSession.Columns["Id"].Visible = false;
                dgSession.Columns["idAnneAcademique"].Visible = false;
                dgSession.Columns["Session"].HeaderText = "Session";
                dgSession.Columns["Annee"].HeaderText = "Année Académique";
            }
        }

        /// <summary>
        /// Réinitialise les champs du formulaire et rafraîchit la grille
        /// </summary>
        public void Effacer()
        {
            RafraichirInterface();
        }

        /// <summary>
        /// Valide les données saisies dans le formulaire
        /// </summary>
        /// <returns>True si la validation réussit, sinon False</returns>
        private bool ValidationFormulaire()
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé de la session.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSession.Focus();
                return false;
            }

            if (txtSession.Text.Trim().Length < 3)
            {
                MessageBox.Show("Le libellé de la session doit contenir au moins 3 caractères.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSession.Focus();
                return false;
            }

            if (cbbAnneeAcademique.SelectedValue == null || Convert.ToInt32(cbbAnneeAcademique.SelectedValue) <= 0)
            {
                MessageBox.Show("Veuillez sélectionner une année académique valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbAnneeAcademique.Focus();
                return false;
            }

            string libelle = txtSession.Text.Trim().ToLower();
            int anneeId = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

            // Extraction de l'ID actuel hors de la requête LINQ pour éviter la NullReferenceException
            int currentId = -1;
            if (dgSession.CurrentRow != null && dgSession.Columns.Contains("Id") && dgSession.CurrentRow.Cells["Id"].Value != null)
            {
                currentId = Convert.ToInt32(dgSession.CurrentRow.Cells["Id"].Value);
            }

            // Correction de la NullReferenceException : On utilise la variable locale 'currentId' dans la requête LINQ
            // pour éviter d'accéder à dgSession pendant la traduction de l'expression.
            bool doublon = db.sessions.Any(s =>
                s.LibelleSession != null && 
                s.LibelleSession.ToLower() == libelle &&
                s.IdAnneeAcademique == anneeId &&
                (currentId == -1 || s.IdSession != currentId)
            );

            if (doublon)
            {
                MessageBox.Show("Cette session existe déjà pour l'année académique sélectionnée.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Effets visuels des boutons

        /// <summary>
        /// Configure les effets hover pour les boutons
        /// </summary>
        private void ConfigurerEffetsBoutons()
        {
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            btnEdit.MouseEnter += (s, e) => btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.MouseLeave += (s, e) => btnEdit.BackColor = Color.FromArgb(52, 152, 219);

            btnRemove.MouseEnter += (s, e) => btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.MouseLeave += (s, e) => btnRemove.BackColor = Color.FromArgb(231, 76, 60);

            btnSearch.MouseEnter += (s, e) => btnSearch.BackColor = Color.FromArgb(31, 97, 141);
            btnSearch.MouseLeave += (s, e) => btnSearch.BackColor = Color.FromArgb(41, 128, 185);

            btnResetSearch.MouseEnter += (s, e) => btnResetSearch.BackColor = Color.FromArgb(127, 140, 141);
            btnResetSearch.MouseLeave += (s, e) => btnResetSearch.BackColor = Color.FromArgb(149, 165, 166);

            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        #endregion

        #region Événements de contrôles

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}