namespace AppSenSoutenance.Views.Parametre
{
    partial class frmAnneeAcademique
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
            this.dgAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.txtAnneeAcademiqueVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtLibelleAnneeAcademique = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnneeAcademique
            // 
            this.dgAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnneeAcademique.Location = new System.Drawing.Point(320, 114);
            this.dgAnneeAcademique.Name = "dgAnneeAcademique";
            this.dgAnneeAcademique.RowHeadersWidth = 82;
            this.dgAnneeAcademique.RowTemplate.Height = 33;
            this.dgAnneeAcademique.Size = new System.Drawing.Size(696, 523);
            this.dgAnneeAcademique.TabIndex = 0;
            // 
            // txtAnneeAcademiqueVal
            // 
            this.txtAnneeAcademiqueVal.Location = new System.Drawing.Point(17, 294);
            this.txtAnneeAcademiqueVal.Name = "txtAnneeAcademiqueVal";
            this.txtAnneeAcademiqueVal.Size = new System.Drawing.Size(238, 31);
            this.txtAnneeAcademiqueVal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valeur";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 477);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 55);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(96, 582);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 55);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(96, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 55);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtLibelleAnneeAcademique
            // 
            this.txtLibelleAnneeAcademique.Location = new System.Drawing.Point(17, 166);
            this.txtLibelleAnneeAcademique.Name = "txtLibelleAnneeAcademique";
            this.txtLibelleAnneeAcademique.Size = new System.Drawing.Size(238, 31);
            this.txtLibelleAnneeAcademique.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texte";
            // 
            // frmAnneeAcademique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 649);
            this.ControlBox = false;
            this.Controls.Add(this.txtLibelleAnneeAcademique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAnneeAcademiqueVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAnneeAcademique);
            this.Name = "frmAnneeAcademique";
            this.Text = "Annee Academique";
            this.Load += new System.EventHandler(this.frmAnneeAcademique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnneeAcademique;
        private System.Windows.Forms.TextBox txtAnneeAcademiqueVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtLibelleAnneeAcademique;
        private System.Windows.Forms.Label label1;
    }
}