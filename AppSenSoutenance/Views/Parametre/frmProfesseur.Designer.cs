namespace AppSenSoutenance.Views.Parametre
{
    partial class frmProfesseur
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
            this.dgProfesseur = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenomProfesseur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomProfesseur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelProfesseur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailProfesseur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDPProfesseur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProfesseur
            // 
            this.dgProfesseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseur.Location = new System.Drawing.Point(675, 159);
            this.dgProfesseur.Name = "dgProfesseur";
            this.dgProfesseur.RowHeadersWidth = 82;
            this.dgProfesseur.RowTemplate.Height = 33;
            this.dgProfesseur.Size = new System.Drawing.Size(945, 556);
            this.dgProfesseur.TabIndex = 1;
            this.dgProfesseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesseur.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(485, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 44);
            this.btnSelect.TabIndex = 4;
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
            this.btnRemove.Location = new System.Drawing.Point(485, 668);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 44);
            this.btnRemove.TabIndex = 9;
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
            this.btnEdit.Location = new System.Drawing.Point(485, 565);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 44);
            this.btnEdit.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(485, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prénom";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtPrenomProfesseur
            // 
            this.txtPrenomProfesseur.Location = new System.Drawing.Point(17, 159);
            this.txtPrenomProfesseur.Name = "txtPrenomProfesseur";
            this.txtPrenomProfesseur.Size = new System.Drawing.Size(286, 31);
            this.txtPrenomProfesseur.TabIndex = 17;
            this.txtPrenomProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nom";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtNomProfesseur
            // 
            this.txtNomProfesseur.Location = new System.Drawing.Point(358, 159);
            this.txtNomProfesseur.Name = "txtNomProfesseur";
            this.txtNomProfesseur.Size = new System.Drawing.Size(286, 31);
            this.txtNomProfesseur.TabIndex = 19;
            this.txtNomProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telephone";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtTelProfesseur
            // 
            this.txtTelProfesseur.Location = new System.Drawing.Point(358, 265);
            this.txtTelProfesseur.Name = "txtTelProfesseur";
            this.txtTelProfesseur.Size = new System.Drawing.Size(286, 31);
            this.txtTelProfesseur.TabIndex = 23;
            this.txtTelProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtEmailProfesseur
            // 
            this.txtEmailProfesseur.Location = new System.Drawing.Point(17, 265);
            this.txtEmailProfesseur.Name = "txtEmailProfesseur";
            this.txtEmailProfesseur.Size = new System.Drawing.Size(286, 31);
            this.txtEmailProfesseur.TabIndex = 21;
            this.txtEmailProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Spécialité";
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(358, 389);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(286, 31);
            this.txtSpecialite.TabIndex = 27;
            this.txtSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mot de passe";
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // txtMDPProfesseur
            // 
            this.txtMDPProfesseur.Location = new System.Drawing.Point(17, 389);
            this.txtMDPProfesseur.Name = "txtMDPProfesseur";
            this.txtMDPProfesseur.Size = new System.Drawing.Size(286, 31);
            this.txtMDPProfesseur.TabIndex = 25;
            this.txtMDPProfesseur.UseSystemPasswordChar = true;
            this.txtMDPProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // frmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1662, 739);
            this.ControlBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMDPProfesseur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelProfesseur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailProfesseur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomProfesseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenomProfesseur);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgProfesseur);
            this.Name = "frmProfesseur";
            this.Text = "Professeur";
            this.AutoScroll = true;
            this.Load += new System.EventHandler(this.frmProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProfesseur;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenomProfesseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomProfesseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelProfesseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailProfesseur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDPProfesseur;
    }
}