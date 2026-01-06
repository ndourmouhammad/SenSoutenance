namespace AppSenSoutenance
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anneeAcademiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soutenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sujetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anneeAcademiqueToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.professeurToolStripMenuItem,
            this.memoireToolStripMenuItem,
            this.soutenanceToolStripMenuItem,
            this.departementToolStripMenuItem,
            this.candidatToolStripMenuItem,
            this.chefToolStripMenuItem,
            this.sujetToolStripMenuItem});
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(127, 38);
            this.parametreToolStripMenuItem.Text = "Parametre";
            // 
            // anneeAcademiqueToolStripMenuItem
            // 
            this.anneeAcademiqueToolStripMenuItem.Name = "anneeAcademiqueToolStripMenuItem";
            this.anneeAcademiqueToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.anneeAcademiqueToolStripMenuItem.Text = "&Annee Academique";
            this.anneeAcademiqueToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqueToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.sessionToolStripMenuItem.Text = "&Session";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // professeurToolStripMenuItem
            // 
            this.professeurToolStripMenuItem.Name = "professeurToolStripMenuItem";
            this.professeurToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.professeurToolStripMenuItem.Text = "&Professeur";
            this.professeurToolStripMenuItem.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // memoireToolStripMenuItem
            // 
            this.memoireToolStripMenuItem.Name = "memoireToolStripMenuItem";
            this.memoireToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.memoireToolStripMenuItem.Text = "Memoire";
            this.memoireToolStripMenuItem.Click += new System.EventHandler(this.memoireToolStripMenuItem_Click);
            // 
            // soutenanceToolStripMenuItem
            // 
            this.soutenanceToolStripMenuItem.Name = "soutenanceToolStripMenuItem";
            this.soutenanceToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.soutenanceToolStripMenuItem.Text = "Soutenance";
            this.soutenanceToolStripMenuItem.Click += new System.EventHandler(this.soutenanceToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // candidatToolStripMenuItem
            // 
            this.candidatToolStripMenuItem.Name = "candidatToolStripMenuItem";
            this.candidatToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.candidatToolStripMenuItem.Text = "Candidat";
            this.candidatToolStripMenuItem.Click += new System.EventHandler(this.candidatToolStripMenuItem_Click);
            // 
            // chefToolStripMenuItem
            // 
            this.chefToolStripMenuItem.Name = "chefToolStripMenuItem";
            this.chefToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.chefToolStripMenuItem.Text = "ChefDepartement";
            this.chefToolStripMenuItem.Click += new System.EventHandler(this.chefToolStripMenuItem_Click);
            // 
            // sujetToolStripMenuItem
            // 
            this.sujetToolStripMenuItem.Name = "sujetToolStripMenuItem";
            this.sujetToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.sujetToolStripMenuItem.Text = "Sujet";
            this.sujetToolStripMenuItem.Click += new System.EventHandler(this.sujetToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 666);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMDI";
            this.Text = "SenSoutenance ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anneeAcademiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soutenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sujetToolStripMenuItem;
    }
}