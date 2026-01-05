namespace AppSenSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtAnneeAcademique = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRAnneeAcademique = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSession
            // 
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Location = new System.Drawing.Point(374, 165);
            this.dgSession.Name = "dgSession";
            this.dgSession.RowHeadersWidth = 82;
            this.dgSession.RowTemplate.Height = 33;
            this.dgSession.Size = new System.Drawing.Size(755, 518);
            this.dgSession.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(173, 630);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 55);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(173, 525);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 55);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(173, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 55);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(46, 204);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(286, 31);
            this.txtSession.TabIndex = 11;
            // 
            // txtAnneeAcademique
            // 
            this.txtAnneeAcademique.AutoSize = true;
            this.txtAnneeAcademique.Location = new System.Drawing.Point(41, 280);
            this.txtAnneeAcademique.Name = "txtAnneeAcademique";
            this.txtAnneeAcademique.Size = new System.Drawing.Size(199, 25);
            this.txtAnneeAcademique.TabIndex = 13;
            this.txtAnneeAcademique.Text = "Annee Academique";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(46, 340);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(286, 33);
            this.cbbAnneeAcademique.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Session";
            // 
            // txtRSession
            // 
            this.txtRSession.Location = new System.Drawing.Point(374, 78);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(203, 31);
            this.txtRSession.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Annee Academique";
            // 
            // txtRAnneeAcademique
            // 
            this.txtRAnneeAcademique.Location = new System.Drawing.Point(662, 78);
            this.txtRAnneeAcademique.Name = "txtRAnneeAcademique";
            this.txtRAnneeAcademique.Size = new System.Drawing.Size(183, 31);
            this.txtRAnneeAcademique.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(970, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 55);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 726);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRAnneeAcademique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.txtAnneeAcademique);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgSession);
            this.Name = "frmSession";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label txtAnneeAcademique;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRAnneeAcademique;
        private System.Windows.Forms.Button btnSearch;
    }
}