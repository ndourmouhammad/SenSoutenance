using System;
using System.Drawing;
using System.Windows.Forms;
using AppSenSoutenance.Views.Parametre;

namespace AppSenSoutenance
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            this.Text = "Tableau de Bord";
            this.BackColor = Color.FromArgb(240, 242, 245);
            
            // Re-triggering layout on resize to keep cards centered
            this.Resize += (s, e) => CenterCards();
        }

        private void CenterCards()
        {
            if (flowLayoutPanel1 != null)
            {
                int totalWidth = flowLayoutPanel1.Width;
                // Simple centering logic could be added here if needed, 
                // but FlowLayoutPanel handles wrapping well.
            }
        }

        private Panel CreateCard(string title, string description, Color color, Action onClick)
        {
            Panel card = new Panel();
            card.Size = new Size(250, 150);
            card.BackColor = Color.White;
            card.Margin = new Padding(15);
            card.Cursor = Cursors.Hand;
            
            // Border/Shadow simulation
            card.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            };

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.ForeColor = color;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 40;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Padding = new Padding(0, 5, 0, 0);

            Label lblDesc = new Label();
            lblDesc.Text = description;
            lblDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDesc.ForeColor = Color.DimGray;
            lblDesc.Dock = DockStyle.Fill;
            lblDesc.TextAlign = ContentAlignment.TopCenter;
            lblDesc.Padding = new Padding(10);

            card.Controls.Add(lblDesc);
            card.Controls.Add(lblTitle);

            // Hover effects
            card.MouseEnter += (s, e) => {
                card.BackColor = Color.FromArgb(245, 245, 245);
                card.Scale(new SizeF(1.02f, 1.02f)); // Simple visual feedback
            };
            card.MouseLeave += (s, e) => {
                card.BackColor = Color.White;
                card.Scale(new SizeF(0.98039f, 0.98039f));
            };

            // Propagate clicks
            card.Click += (s, e) => onClick();
            lblTitle.Click += (s, e) => onClick();
            lblDesc.Click += (s, e) => onClick();

            return card;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            PopulateCards();
        }

        private void PopulateCards()
        {
            flowLayoutPanel1.Controls.Clear();

            flowLayoutPanel1.Controls.Add(CreateCard("Année Académique", "Gérer les années scolaires et les périodes d'activité.", Color.FromArgb(0, 122, 204), () => OpenForm(new frmAnneeAcademique())));
            flowLayoutPanel1.Controls.Add(CreateCard("Sessions", "Planifier et configurer les sessions de soutenance.", Color.FromArgb(0, 122, 204), () => OpenForm(new frmSession())));
            flowLayoutPanel1.Controls.Add(CreateCard("Professeurs", "Gestion du corps enseignant et des encadrants.", Color.FromArgb(46, 204, 113), () => OpenForm(new frmProfesseur())));
            flowLayoutPanel1.Controls.Add(CreateCard("Candidats", "Liste des étudiants et suivi de leurs dossiers.", Color.FromArgb(46, 204, 113), () => OpenForm(new frmCandidat())));
            flowLayoutPanel1.Controls.Add(CreateCard("Mémoires", "Dépôt et validation des travaux de fin d'études.", Color.FromArgb(231, 76, 60), () => OpenForm(new frmMemoire())));
            flowLayoutPanel1.Controls.Add(CreateCard("Soutenances", "Organisation et calendrier des jurys.", Color.FromArgb(231, 76, 60), () => OpenForm(new frmSoutenance())));
            flowLayoutPanel1.Controls.Add(CreateCard("Départements", "Gestion des départements et des chefs de service.", Color.FromArgb(155, 89, 182), () => OpenForm(new frmDepartement())));
        }

        private void OpenForm(Form f)
        {
            if (this.MdiParent != null)
            {
                // Close other children except dashboard? 
                // Or just show this one. The user's MDI has a 'fermer()' method.
                // We should probably call the MDI's opening logic.
                
                // For now, let's just trigger the MDI menu items if we can, 
                // or replicate the logic.
                
                f.MdiParent = this.MdiParent;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
                // Note: We might want to close the dashboard or just hide it.
            }
        }
    }
}
