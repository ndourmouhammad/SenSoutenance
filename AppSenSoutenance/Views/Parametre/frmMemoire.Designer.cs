namespace AppSenSoutenance.Views.Parametre
{
    partial class frmMemoire
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
            this.dgMemoire = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAnneeAcademiqueMemoire = new System.Windows.Forms.ComboBox();
            this.txtSujetMemoire = new System.Windows.Forms.TextBox();
            this.txtAnneeAcademique = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSessionMemoire = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMemoire
            // 
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoire.Location = new System.Drawing.Point(833, 150);
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.RowHeadersWidth = 82;
            this.dgMemoire.RowTemplate.Height = 33;
            this.dgMemoire.Size = new System.Drawing.Size(755, 518);
            this.dgMemoire.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sujet";
            // 
            // cbbAnneeAcademiqueMemoire
            // 
            this.cbbAnneeAcademiqueMemoire.FormattingEnabled = true;
            this.cbbAnneeAcademiqueMemoire.Location = new System.Drawing.Point(57, 337);
            this.cbbAnneeAcademiqueMemoire.Name = "cbbAnneeAcademiqueMemoire";
            this.cbbAnneeAcademiqueMemoire.Size = new System.Drawing.Size(286, 33);
            this.cbbAnneeAcademiqueMemoire.TabIndex = 19;
            // 
            // txtSujetMemoire
            // 
            this.txtSujetMemoire.Location = new System.Drawing.Point(57, 201);
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(286, 31);
            this.txtSujetMemoire.TabIndex = 17;
            // 
            // txtAnneeAcademique
            // 
            this.txtAnneeAcademique.AutoSize = true;
            this.txtAnneeAcademique.Location = new System.Drawing.Point(52, 277);
            this.txtAnneeAcademique.Name = "txtAnneeAcademique";
            this.txtAnneeAcademique.Size = new System.Drawing.Size(199, 25);
            this.txtAnneeAcademique.TabIndex = 18;
            this.txtAnneeAcademique.Text = "Annee Academique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Session";
            // 
            // txtSessionMemoire
            // 
            this.txtSessionMemoire.Location = new System.Drawing.Point(459, 201);
            this.txtSessionMemoire.Name = "txtSessionMemoire";
            this.txtSessionMemoire.Size = new System.Drawing.Size(286, 31);
            this.txtSessionMemoire.TabIndex = 21;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(586, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 55);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(586, 614);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 55);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(586, 509);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 55);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(586, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 55);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmMemoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1627, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSessionMemoire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAnneeAcademiqueMemoire);
            this.Controls.Add(this.txtSujetMemoire);
            this.Controls.Add(this.txtAnneeAcademique);
            this.Controls.Add(this.dgMemoire);
            this.Name = "frmMemoire";
            this.Text = "Memoire";
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMemoire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAnneeAcademiqueMemoire;
        private System.Windows.Forms.TextBox txtSujetMemoire;
        private System.Windows.Forms.Label txtAnneeAcademique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSessionMemoire;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}