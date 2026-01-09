namespace AppSenSoutenance.Views.Parametre
{
    partial class frmCandidat
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
            this.dgCandidat = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDPCandidat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelCandidat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCandidat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCandidat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenomCandidat = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCandidat
            // 
            this.dgCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCandidat.Location = new System.Drawing.Point(680, 132);
            this.dgCandidat.Name = "dgCandidat";
            this.dgCandidat.RowHeadersWidth = 82;
            this.dgCandidat.RowTemplate.Height = 33;
            this.dgCandidat.Size = new System.Drawing.Size(945, 556);
            this.dgCandidat.TabIndex = 2;
            this.dgCandidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCandidat.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(364, 307);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(100, 25);
            this.Matricule.TabIndex = 40;
            this.Matricule.Text = "Matricule";
            this.Matricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(369, 358);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(286, 31);
            this.txtMatricule.TabIndex = 39;
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mot de passe";
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtMDPCandidat
            // 
            this.txtMDPCandidat.Location = new System.Drawing.Point(28, 358);
            this.txtMDPCandidat.Name = "txtMDPCandidat";
            this.txtMDPCandidat.Size = new System.Drawing.Size(286, 31);
            this.txtMDPCandidat.TabIndex = 37;
            this.txtMDPCandidat.UseSystemPasswordChar = true;
            this.txtMDPCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telephone";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtTelCandidat
            // 
            this.txtTelCandidat.Location = new System.Drawing.Point(369, 234);
            this.txtTelCandidat.Name = "txtTelCandidat";
            this.txtTelCandidat.Size = new System.Drawing.Size(286, 31);
            this.txtTelCandidat.TabIndex = 35;
            this.txtTelCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email";
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtEmailCandidat
            // 
            this.txtEmailCandidat.Location = new System.Drawing.Point(28, 234);
            this.txtEmailCandidat.Name = "txtEmailCandidat";
            this.txtEmailCandidat.Size = new System.Drawing.Size(286, 31);
            this.txtEmailCandidat.TabIndex = 33;
            this.txtEmailCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtNomCandidat
            // 
            this.txtNomCandidat.Location = new System.Drawing.Point(369, 128);
            this.txtNomCandidat.Name = "txtNomCandidat";
            this.txtNomCandidat.Size = new System.Drawing.Size(286, 31);
            this.txtNomCandidat.TabIndex = 31;
            this.txtNomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Prénom";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtPrenomCandidat
            // 
            this.txtPrenomCandidat.Location = new System.Drawing.Point(28, 128);
            this.txtPrenomCandidat.Name = "txtPrenomCandidat";
            this.txtPrenomCandidat.Size = new System.Drawing.Size(286, 31);
            this.txtPrenomCandidat.TabIndex = 29;
            this.txtPrenomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(496, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 44);
            this.btnSelect.TabIndex = 41;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(496, 633);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 44);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(496, 530);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 44);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(496, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 44);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1637, 733);
            this.ControlBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMDPCandidat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelCandidat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailCandidat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomCandidat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenomCandidat);
            this.Controls.Add(this.dgCandidat);
            this.Name = "frmCandidat";
            this.ShowIcon = false;
            this.Text = "Candidat";
            this.Load += new System.EventHandler(this.frmCandidat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCandidat;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDPCandidat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelCandidat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailCandidat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomCandidat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenomCandidat;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}