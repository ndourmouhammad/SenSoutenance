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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgSujet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSujet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSujet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSujet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSujet.Location = new System.Drawing.Point(682, 89);
            this.dgSujet.Name = "dgSujet";
            this.dgSujet.RowHeadersWidth = 82;
            this.dgSujet.RowTemplate.Height = 33;
            this.dgSujet.Size = new System.Drawing.Size(945, 556);
            this.dgSujet.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(412, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 44);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Titre";
            // 
            // txtTitreSujet
            // 
            this.txtTitreSujet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitreSujet.Location = new System.Drawing.Point(39, 129);
            this.txtTitreSujet.Name = "txtTitreSujet";
            this.txtTitreSujet.Size = new System.Drawing.Size(262, 43);
            this.txtTitreSujet.TabIndex = 43;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Description.Location = new System.Drawing.Point(36, 179);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(152, 37);
            this.Description.TabIndex = 46;
            this.Description.Text = "Description";
            // 
            // txtDescriptionSujet
            // 
            this.txtDescriptionSujet.AcceptsReturn = true;
            this.txtDescriptionSujet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescriptionSujet.Location = new System.Drawing.Point(41, 230);
            this.txtDescriptionSujet.Multiline = true;
            this.txtDescriptionSujet.Name = "txtDescriptionSujet";
            this.txtDescriptionSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionSujet.Size = new System.Drawing.Size(534, 93);
            this.txtDescriptionSujet.TabIndex = 45;
            // 
            // dtpPropositionSujet
            // 
            this.dtpPropositionSujet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpPropositionSujet.Location = new System.Drawing.Point(41, 400);
            this.dtpPropositionSujet.Name = "dtpPropositionSujet";
            this.dtpPropositionSujet.Size = new System.Drawing.Size(262, 43);
            this.dtpPropositionSujet.TabIndex = 47;
            // 
            // cmbStatutSujet
            // 
            this.cmbStatutSujet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatutSujet.FormattingEnabled = true;
            this.cmbStatutSujet.Location = new System.Drawing.Point(450, 128);
            this.cmbStatutSujet.Name = "cmbStatutSujet";
            this.cmbStatutSujet.Size = new System.Drawing.Size(121, 45);
            this.cmbStatutSujet.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(36, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date de proposition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(445, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 37);
            this.label3.TabIndex = 53;
            this.label3.Text = "Statut";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(416, 524);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 44);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(416, 444);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 44);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(416, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 44);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
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