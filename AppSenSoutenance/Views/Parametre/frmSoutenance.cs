using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
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
    public partial class frmSoutenance : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filler = new FilerList();

        public frmSoutenance()
        {
            InitializeComponent();
            ConfigurerEffetsBoutons();
            this.Load += FrmSoutenance_Load;
            
            // Attacher les événements aux boutons
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            btnClose.Click += btnClose_Click;
            dgSoutenance.CellClick += dgSoutenance_CellClick;
        }

        private void FrmSoutenance_Load(object sender, EventArgs e)
        {
            ChargerMemoires();
            ActualiserGrid();
        }

        private void ChargerMemoires()
        {
            cbbMemoire.DataSource = filler.FillMemoire();
            cbbMemoire.DisplayMember = "Text";
            cbbMemoire.ValueMember = "Value";
        }

        private void ActualiserGrid()
        {
            dgSoutenance.DataSource = db.soutenances.Select(s => new
            {
                Id = s.IdSoutenance,
                Date = s.DateSoutenance,
                Lieu = s.LieuSoutenance,
                Resultat = s.ResultatSoutenance,
                Mention = s.MentionSoutenance,
                Memoire = s.Memoire.SujetMemoire
            }).ToList();

            if (dgSoutenance.Columns["Id"] != null)
                dgSoutenance.Columns["Id"].Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Logique d'ajout à implémenter
            MessageBox.Show("Fonctionnalité d'ajout à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Logique de modification à implémenter
            MessageBox.Show("Fonctionnalité de modification à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Logique de suppression à implémenter
            MessageBox.Show("Fonctionnalité de suppression à implémenter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgSoutenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Remplir les champs lors de la sélection
            }
        }

        private void Effacer()
        {
            txtLieu.Clear();
            txtMention.Clear();
            txtObservations.Clear();
            cbbResultat.SelectedIndex = 0;
            cbbMemoire.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }
    }
}
