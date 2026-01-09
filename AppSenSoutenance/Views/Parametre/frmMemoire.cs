using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmMemoire : Form
    {
        // Contexte de la base de données utilisé pour les opérations CRUD
        private BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private FilerList filler = new FilerList();
        private byte[] documentBytes = null;
        private string documentFileName = string.Empty;
        private bool isUpdating = false; // Flag pour éviter les boucles d'événements

        public frmMemoire()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
            this.FormClosing += FrmMemoire_FormClosing;
            
            // Hooking up the new logic
            this.cbbAnneeAcademiqueMemoire.SelectedIndexChanged += cbbAnneeAcademiqueMemoire_SelectedIndexChanged;
            this.cbbSessionMemoire.SelectedIndexChanged += cbbSessionMemoire_SelectedIndexChanged;
        }

        #region Événements de chargement

        /// <summary>
        /// Chargement du formulaire : initialisation de l'interface
        /// </summary>
        private void frmMemoire_Load(object sender, EventArgs e)
        {
            try
            {
                RafraichirInterface();
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
        private void FrmMemoire_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }

        #endregion

        #region Logique de Liaison (Hierarchique)

        /// <summary>
        /// Filtre les sessions en fonction de l'année académique sélectionnée
        /// </summary>
        private void cbbAnneeAcademiqueMemoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;
                if (cbbAnneeAcademiqueMemoire.SelectedValue != null)
                {
                    string yearVal = cbbAnneeAcademiqueMemoire.SelectedValue.ToString();
                    
                    if (yearVal != "0")
                    {
                        int idYear = Convert.ToInt32(yearVal);
                        
                        // Filtrer les sessions appartenant à cette année
                        var sessionsFiltered = db.sessions
                            .Where(s => s.IdAnneeAcademique == idYear)
                            .ToList();

                        List<ListItem> list = new List<ListItem>();
                        list.Add(new ListItem { Value = "0", Text = "Selectionner" });
                        foreach (var s in sessionsFiltered)
                        {
                            list.Add(new ListItem { Value = s.IdSession.ToString(), Text = s.LibelleSession });
                        }

                        cbbSessionMemoire.DataSource = list;
                        cbbSessionMemoire.DisplayMember = "Text";
                        cbbSessionMemoire.ValueMember = "Value";
                    }
                    else
                    {
                        // Si "Selectionner" est choisi pour l'année, on recharge toutes les sessions
                        cbbSessionMemoire.DataSource = filler.FillSession();
                    }
                }
            }
            finally
            {
                isUpdating = false;
            }
        }

        /// <summary>
        /// Sélectionne automatiquement l'année académique en fonction de la session choisie
        /// </summary>
        private void cbbSessionMemoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;
                if (cbbSessionMemoire.SelectedValue != null)
                {
                    string sessionVal = cbbSessionMemoire.SelectedValue.ToString();
                    if (sessionVal != "0")
                    {
                        int idSession = Convert.ToInt32(sessionVal);
                        var session = db.sessions.Find(idSession);
                        
                        if (session != null && session.IdAnneeAcademique != null)
                        {
                            cbbAnneeAcademiqueMemoire.SelectedValue = session.IdAnneeAcademique.ToString();
                        }
                    }
                }
            }
            finally
            {
                isUpdating = false;
            }
        }

        #endregion

        #region Actions de navigation et sélection de fichier

        /// <summary>
        /// Ouvre une boîte de dialogue pour sélectionner un document
        /// </summary>
        private void btnBrowseDocument_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Documents PDF (*.pdf)|*.pdf|Documents Word (*.docx)|*.docx|Tous les fichiers (*.*)|*.*";
                    ofd.Title = "Sélectionner le manuscrit du mémoire";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        documentBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                        documentFileName = System.IO.Path.GetFileName(ofd.FileName);
                        lblDocumentInfo.Text = $"Fichier : {documentFileName}";
                        lblDocumentInfo.ForeColor = Color.FromArgb(39, 174, 96); // Vert
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Actions CRUD

        /// <summary>
        /// Ajoute un nouveau mémoire dans la base de données
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationFormulaire())
                {
                    int sessionId = Convert.ToInt32(cbbSessionMemoire.SelectedValue);
                    var session = db.sessions.Find(sessionId);

                    Memoire memoire = new Memoire
                    {
                        SujetMemoire = txtSujetMemoire.Text.Trim(),
                        IdAnneeAcademique = session.IdAnneeAcademique ?? 0,
                        IdSession = sessionId,
                        DocumentMemoire = documentBytes
                    };

                    db.memoires.Add(memoire);
                    db.SaveChanges();

                    MessageBox.Show("Mémoire ajouté avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                string errorDetail = $"Erreur lors de l'ajout : {ex.Message}\n\n" +
                                   $"Type: {ex.GetType().FullName}\n" +
                                   $"StackTrace: {ex.StackTrace}\n\n" +
                                   "Veuillez envoyer une capture d'écran de ce message.";
                MessageBox.Show(errorDetail, "Erreur Critique (Diagnostic)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sélectionne un mémoire dans le DataGridView et remplit les champs du formulaire
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMemoire.CurrentRow != null)
                {
                    int id = (int)dgMemoire.CurrentRow.Cells["Id"].Value;

                    Memoire memoire = db.memoires.Find(id);
                    if (memoire != null)
                    {
                        txtSujetMemoire.Text = memoire.SujetMemoire;
                        
                        // On désactive le flag pour éviter de déclencher les filtres pendant le remplissage
                        isUpdating = true;
                        cbbAnneeAcademiqueMemoire.SelectedValue = memoire.IdAnneeAcademique.ToString();
                        cbbSessionMemoire.SelectedValue = memoire.IdSession?.ToString() ?? "0";
                        isUpdating = false;

                        documentBytes = memoire.DocumentMemoire;
                        lblDocumentInfo.Text = documentBytes != null ? "Document attaché (existant)" : "Aucun document attaché";
                        lblDocumentInfo.ForeColor = documentBytes != null ? Color.FromArgb(39, 174, 96) : Color.FromArgb(127, 140, 141);
                    }
                    else
                    {
                        MessageBox.Show("Mémoire introuvable.",
                            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpdating = false;
            }
        }

        /// <summary>
        /// Modifie le mémoire sélectionné
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMemoire.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un mémoire à modifier.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidationFormulaire()) return;

                int id = (int)dgMemoire.CurrentRow.Cells["Id"].Value;
                Memoire memoire = db.memoires.Find(id);

                if (memoire != null)
                {
                    int sessionId = Convert.ToInt32(cbbSessionMemoire.SelectedValue);
                    var session = db.sessions.Find(sessionId);

                    memoire.SujetMemoire = txtSujetMemoire.Text.Trim();
                    memoire.IdAnneeAcademique = session.IdAnneeAcademique ?? 0;
                    memoire.IdSession = sessionId;
                    if (documentBytes != null)
                    {
                        memoire.DocumentMemoire = documentBytes;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Modification réussie !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
                else
                {
                    MessageBox.Show("Mémoire introuvable.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime le mémoire sélectionné après confirmation
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMemoire.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un mémoire à supprimer.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce mémoire ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = (int)dgMemoire.CurrentRow.Cells["Id"].Value;
                    Memoire memoire = db.memoires.Find(id);

                    if (memoire != null)
                    {
                        db.memoires.Remove(memoire);
                        db.SaveChanges();
                        MessageBox.Show("Suppression réussie !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Effacer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Recherche

        /// <summary>
        /// Recherche des mémoires selon les critères saisis
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var liste = db.memoires.AsQueryable();

                // Filtre par sujet
                if (!string.IsNullOrWhiteSpace(txtRSujet.Text))
                {
                    string recherche = txtRSujet.Text.Trim().ToLower();
                    liste = liste.Where(m => m.SujetMemoire.ToLower().Contains(recherche));
                }

                // Filtre par année académique
                if (!string.IsNullOrWhiteSpace(txtRAnneeAcademique.Text))
                {
                    string rechercheAnnee = txtRAnneeAcademique.Text.Trim().ToLower();
                    liste = liste.Where(m => m.AnneeAcademique.LibelleAnneeAcademique
                        .ToLower().Contains(rechercheAnnee));
                }

                // Filtre par session
                if (!string.IsNullOrWhiteSpace(txtRSession.Text))
                {
                    string rechercheSession = txtRSession.Text.Trim().ToLower();
                    liste = liste.Where(m => m.Session.LibelleSession
                        .ToLower().Contains(rechercheSession));
                }

                // Projection pour l'affichage
                dgMemoire.DataSource = liste.Select(m => new
                {
                    Id = m.IdMemoire,
                    Sujet = m.SujetMemoire,
                    IdAnneeAcademique = m.IdAnneeAcademique,
                    AnneeAcademique = m.AnneeAcademique.LibelleAnneeAcademique,
                    IdSession = m.IdSession,
                    Session = m.Session.LibelleSession
                }).ToList();

                ConfigurerDataGridView();

                if (!liste.Any())
                {
                    MessageBox.Show("Aucun mémoire trouvé.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Réinitialise les critères de recherche et affiche tous les mémoires
        /// </summary>
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtRSujet.Clear();
                txtRAnneeAcademique.Clear();
                txtRSession.Clear();
                RafraichirInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                isUpdating = true; // On bloque les événements pendant le refresh initial
                
                // Réinitialisation des champs de saisie
                txtSujetMemoire.Clear();
                txtRSujet.Clear();
                txtRAnneeAcademique.Clear();
                txtRSession.Clear();
                documentBytes = null;
                documentFileName = string.Empty;
                lblDocumentInfo.Text = "Aucun document sélectionné";
                lblDocumentInfo.ForeColor = Color.FromArgb(127, 140, 141);

                // Chargement des listes déroulantes
                cbbAnneeAcademiqueMemoire.DataSource = filler.FillAnneeAcademique();
                cbbAnneeAcademiqueMemoire.DisplayMember = "Text";
                cbbAnneeAcademiqueMemoire.ValueMember = "Value";

                cbbSessionMemoire.DataSource = filler.FillSession();
                cbbSessionMemoire.DisplayMember = "Text";
                cbbSessionMemoire.ValueMember = "Value";

                // Chargement du DataGridView avec les mémoires
                dgMemoire.DataSource = db.memoires.Select(m => new
                {
                    Id = m.IdMemoire,
                    Sujet = m.SujetMemoire,
                    IdAnneeAcademique = m.IdAnneeAcademique,
                    AnneeAcademique = m.AnneeAcademique.LibelleAnneeAcademique,
                    IdSession = m.IdSession,
                    Session = m.Session.LibelleSession
                }).ToList();

                ConfigurerDataGridView();

                // On masque le champ année académique (car redondant avec la session)
                label2.Visible = false;
                cbbAnneeAcademiqueMemoire.Visible = false;

                // On remonte la session pour combler l'espace (ajustement visuel simple)
                label3.Location = label2.Location;
                cbbSessionMemoire.Location = cbbAnneeAcademiqueMemoire.Location;

                // Sélection par défaut
                if (cbbSessionMemoire.Items.Count > 0)
                    cbbSessionMemoire.SelectedIndex = 0;

                txtSujetMemoire.Focus();
                isUpdating = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpdating = false;
            }
        }

        /// <summary>
        /// Configure l'affichage du DataGridView
        /// </summary>
        private void ConfigurerDataGridView()
        {
            // Masquer les colonnes ID
            if (dgMemoire.Columns["IdAnneeAcademique"] != null)
                dgMemoire.Columns["IdAnneeAcademique"].Visible = false;

            if (dgMemoire.Columns["IdSession"] != null)
                dgMemoire.Columns["IdSession"].Visible = false;

            // Définir les en-têtes de colonnes
            if (dgMemoire.Columns["Id"] != null)
            {
                dgMemoire.Columns["Id"].HeaderText = "ID";
                dgMemoire.Columns["Id"].Width = 60;
            }

            if (dgMemoire.Columns["Sujet"] != null)
            {
                dgMemoire.Columns["Sujet"].HeaderText = "Sujet du Mémoire";
                dgMemoire.Columns["Sujet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgMemoire.Columns["AnneeAcademique"] != null)
            {
                dgMemoire.Columns["AnneeAcademique"].HeaderText = "Année Académique";
                dgMemoire.Columns["AnneeAcademique"].Width = 150;
            }

            if (dgMemoire.Columns["Session"] != null)
            {
                dgMemoire.Columns["Session"].HeaderText = "Session";
                dgMemoire.Columns["Session"].Width = 120;
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
        private bool ValidationFormulaire()
        {
            // Validation du sujet
            if (string.IsNullOrWhiteSpace(txtSujetMemoire.Text))
            {
                MessageBox.Show("Veuillez saisir le sujet du mémoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSujetMemoire.Focus();
                return false;
            }

            if (txtSujetMemoire.Text.Trim().Length < 10)
            {
                MessageBox.Show("Le sujet du mémoire doit contenir au moins 10 caractères.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSujetMemoire.Focus();
                return false;
            }

            // Validation de l'année académique
            if (cbbAnneeAcademiqueMemoire.SelectedValue == null || cbbAnneeAcademiqueMemoire.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Veuillez sélectionner une année académique.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbAnneeAcademiqueMemoire.Focus();
                return false;
            }

            // Validation de la session
            if (cbbSessionMemoire.SelectedValue == null || cbbSessionMemoire.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Veuillez sélectionner une session.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbSessionMemoire.Focus();
                return false;
            }

            // Vérification des doublons sécurisée
            string sujet = txtSujetMemoire.Text.Trim().ToLower();
            int sessionId = Convert.ToInt32(cbbSessionMemoire.SelectedValue);

            // Extraction de l'ID actuel pour le LINQ
            int currentId = -1;
            if (dgMemoire.CurrentRow != null && dgMemoire.Columns.Contains("Id") && dgMemoire.CurrentRow.Cells["Id"].Value != null)
            {
                currentId = (int)dgMemoire.CurrentRow.Cells["Id"].Value;
            }

            // On récupère l'année de la session choisie
            var sessionObj = db.sessions.Find(sessionId);
            int? anneeId = sessionObj?.IdAnneeAcademique;

            bool doublon = db.memoires.Any(m =>
                m.SujetMemoire != null && m.SujetMemoire.ToLower() == sujet &&
                m.IdSession == sessionId &&
                (currentId == -1 || m.IdMemoire != currentId)
            );

            if (doublon)
            {
                MessageBox.Show("Ce mémoire existe déjà pour cette session.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Effet hover pour btnAdd
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            // Effet hover pour btnEdit
            btnEdit.MouseEnter += (s, e) => btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.MouseLeave += (s, e) => btnEdit.BackColor = Color.FromArgb(52, 152, 219);

            // Effet hover pour btnRemove
            btnRemove.MouseEnter += (s, e) => btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.MouseLeave += (s, e) => btnRemove.BackColor = Color.FromArgb(231, 76, 60);

            // Effet hover pour btnSelect
            btnSelect.MouseEnter += (s, e) => btnSelect.BackColor = Color.FromArgb(127, 140, 141);
            btnSelect.MouseLeave += (s, e) => btnSelect.BackColor = Color.FromArgb(149, 165, 166);

            // Effet hover pour btnSearch
            btnSearch.MouseEnter += (s, e) => btnSearch.BackColor = Color.FromArgb(31, 97, 141);
            btnSearch.MouseLeave += (s, e) => btnSearch.BackColor = Color.FromArgb(41, 128, 185);

            // Effet hover pour btnResetSearch
            btnResetSearch.MouseEnter += (s, e) => btnResetSearch.BackColor = Color.FromArgb(127, 140, 141);
            btnResetSearch.MouseLeave += (s, e) => btnResetSearch.BackColor = Color.FromArgb(149, 165, 166);

            // Effet hover pour btnClose
            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(52, 73, 94);
        }

        #endregion

        #region Événements de contrôles

        /// <summary>
        /// Ferme le formulaire
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}