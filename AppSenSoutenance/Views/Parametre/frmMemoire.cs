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
    public partial class frmMemoire : Form
    {
        public frmMemoire()
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
            if (dgMemoire != null)
            {
                dgMemoire.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgMemoire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgMemoire.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgMemoire.AllowUserToResizeColumns = true;
                dgMemoire.AllowUserToResizeRows = true;
                dgMemoire.ScrollBars = ScrollBars.Both;
                dgMemoire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgMemoire.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void frmMemoire_Load(object sender, EventArgs e)
        {

        }
    }
}
