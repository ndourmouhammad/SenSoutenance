namespace AppSenSoutenance.Views.Parametre
{
    partial class frmSujet
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
            this.dgSujet = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitreSujet = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.txtDescriptionSujet = new System.Windows.Forms.TextBox();
            this.dtpPropositionSujet = new System.Windows.Forms.DateTimePicker();
            this.cmbStatutSujet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSujet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSujet
            // 
            this.dgSujet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSujet.Location = new System.Drawing.Point(684, 145);
            this.dgSujet.Name = "dgSujet";
            this.dgSujet.RowHeadersWidth = 82;
            this.dgSujet.RowTemplate.Height = 33;
            this.dgSujet.Size = new System.Drawing.Size(945, 556);
            this.dgSujet.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(412, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 55);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Titre";
            // 
            // txtTitreSujet
            // 
            this.txtTitreSujet.Location = new System.Drawing.Point(37, 165);
            this.txtTitreSujet.Name = "txtTitreSujet";
            this.txtTitreSujet.Size = new System.Drawing.Size(262, 31);
            this.txtTitreSujet.TabIndex = 43;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(32, 221);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(120, 25);
            this.Description.TabIndex = 46;
            this.Description.Text = "Description";
            // 
            // txtDescriptionSujet
            // 
            this.txtDescriptionSujet.AcceptsReturn = true;
            this.txtDescriptionSujet.Location = new System.Drawing.Point(37, 272);
            this.txtDescriptionSujet.Multiline = true;
            this.txtDescriptionSujet.Name = "txtDescriptionSujet";
            this.txtDescriptionSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionSujet.Size = new System.Drawing.Size(534, 93);
            this.txtDescriptionSujet.TabIndex = 45;
            // 
            // dtpPropositionSujet
            // 
            this.dtpPropositionSujet.Location = new System.Drawing.Point(37, 450);
            this.dtpPropositionSujet.Name = "dtpPropositionSujet";
            this.dtpPropositionSujet.Size = new System.Drawing.Size(262, 31);
            this.dtpPropositionSujet.TabIndex = 47;
            // 
            // cmbStatutSujet
            // 
            this.cmbStatutSujet.FormattingEnabled = true;
            this.cmbStatutSujet.Location = new System.Drawing.Point(448, 164);
            this.cmbStatutSujet.Name = "cmbStatutSujet";
            this.cmbStatutSujet.Size = new System.Drawing.Size(121, 33);
            this.cmbStatutSujet.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date de proposition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Statut";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(412, 650);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 55);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 547);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 55);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(412, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 55);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1668, 734);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatutSujet);
            this.Controls.Add(this.dtpPropositionSujet);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtDescriptionSujet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitreSujet);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgSujet);
            this.Name = "frmSujet";
            this.Text = "Sujet";
            this.Load += new System.EventHandler(this.frmSujet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSujet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSujet;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitreSujet;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txtDescriptionSujet;
        private System.Windows.Forms.DateTimePicker dtpPropositionSujet;
        private System.Windows.Forms.ComboBox cmbStatutSujet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}