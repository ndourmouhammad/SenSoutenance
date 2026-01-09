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
    public partial class frmSujet : Form
    {
        public frmSujet()
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
            if (dgSujet != null)
            {
                dgSujet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                dgSujet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgSujet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgSujet.AllowUserToResizeColumns = true;
                dgSujet.AllowUserToResizeRows = true;
                dgSujet.ScrollBars = ScrollBars.Both;
                dgSujet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgSujet.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void frmSujet_Load(object sender, EventArgs e)
        {

        }
    }
}
