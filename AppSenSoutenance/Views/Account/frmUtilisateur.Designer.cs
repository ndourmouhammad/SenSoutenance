namespace AppSenSoutenance.Views.Account
{
    partial class frmUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabUtilisateurs = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.btnSelectP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnPAjouter = new System.Windows.Forms.Button();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPPrenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPNom = new System.Windows.Forms.TextBox();
            this.tabChefDeProjet = new System.Windows.Forms.TabPage();
            this.btnSelectC = new System.Windows.Forms.Button();
            this.btnCSupprimer = new System.Windows.Forms.Button();
            this.btnCModifier = new System.Windows.Forms.Button();
            this.btnCAjouter = new System.Windows.Forms.Button();
            this.txtCDepartement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCPrenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgUtilisateurs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabUtilisateurs.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChefDeProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUtilisateurs
            // 
            this.tabUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabUtilisateurs.Controls.Add(this.tabCandidat);
            this.tabUtilisateurs.Controls.Add(this.tabProfesseur);
            this.tabUtilisateurs.Controls.Add(this.tabChefDeProjet);
            this.tabUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabUtilisateurs.Location = new System.Drawing.Point(12, 80);
            this.tabUtilisateurs.Name = "tabUtilisateurs";
            this.tabUtilisateurs.SelectedIndex = 0;
            this.tabUtilisateurs.Size = new System.Drawing.Size(400, 580);
            this.tabUtilisateurs.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.White;
            this.tabCandidat.Controls.Add(this.btnSelect);
            this.tabCandidat.Controls.Add(this.btnRemove);
            this.tabCandidat.Controls.Add(this.btnEdit);
            this.tabCandidat.Controls.Add(this.btnAdd);
            this.tabCandidat.Controls.Add(this.txtMatricule);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtTel);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtEmail);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtPrenom);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtNom);
            this.tabCandidat.Controls.Add(this.label1);
            this.tabCandidat.Location = new System.Drawing.Point(4, 24);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(15);
            this.tabCandidat.Size = new System.Drawing.Size(392, 552);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "👤 Candidat";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 500);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(352, 30);
            this.btnSelect.TabIndex = 59;
            this.btnSelect.Text = "👆 Sélectionner";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(20, 450);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(352, 38);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "🗑️ Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(20, 405);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(352, 38);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "✏️ Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(352, 38);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "➕ Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatricule.Location = new System.Drawing.Point(20, 315);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(352, 23);
            this.txtMatricule.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.Location = new System.Drawing.Point(17, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Matricule";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTel.Location = new System.Drawing.Point(20, 260);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(352, 23);
            this.txtTel.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.Location = new System.Drawing.Point(17, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(20, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 23);
            this.txtEmail.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Email";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrenom.Location = new System.Drawing.Point(20, 150);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(352, 23);
            this.txtPrenom.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(17, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.Location = new System.Drawing.Point(20, 95);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(352, 23);
            this.txtNom.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nom";
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.White;
            this.tabProfesseur.Controls.Add(this.btnSelectP);
            this.tabProfesseur.Controls.Add(this.label10);
            this.tabProfesseur.Controls.Add(this.btnPDelete);
            this.tabProfesseur.Controls.Add(this.btnPEdit);
            this.tabProfesseur.Controls.Add(this.btnPAjouter);
            this.tabProfesseur.Controls.Add(this.txtPSpecialite);
            this.tabProfesseur.Controls.Add(this.label6);
            this.tabProfesseur.Controls.Add(this.txtPTel);
            this.tabProfesseur.Controls.Add(this.label7);
            this.tabProfesseur.Controls.Add(this.txtPEmail);
            this.tabProfesseur.Controls.Add(this.label8);
            this.tabProfesseur.Controls.Add(this.txtPPrenom);
            this.tabProfesseur.Controls.Add(this.label9);
            this.tabProfesseur.Controls.Add(this.txtPNom);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 24);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(15);
            this.tabProfesseur.Size = new System.Drawing.Size(392, 552);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "👨‍🏫 Professeur";
            // 
            // btnSelectP
            // 
            this.btnSelectP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSelectP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectP.ForeColor = System.Drawing.Color.White;
            this.btnSelectP.Location = new System.Drawing.Point(20, 500);
            this.btnSelectP.Name = "btnSelectP";
            this.btnSelectP.Size = new System.Drawing.Size(352, 30);
            this.btnSelectP.TabIndex = 75;
            this.btnSelectP.Text = "👆 Sélectionner";
            this.btnSelectP.UseVisualStyleBackColor = false;
            this.btnSelectP.Visible = false;
            this.btnSelectP.Click += new System.EventHandler(this.btnSelectP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.Location = new System.Drawing.Point(17, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Nom";
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDelete.FlatAppearance.BorderSize = 0;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(20, 450);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(352, 38);
            this.btnPDelete.TabIndex = 73;
            this.btnPDelete.Text = "🗑️ Supprimer";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPEdit.FlatAppearance.BorderSize = 0;
            this.btnPEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPEdit.ForeColor = System.Drawing.Color.White;
            this.btnPEdit.Location = new System.Drawing.Point(20, 405);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(352, 38);
            this.btnPEdit.TabIndex = 72;
            this.btnPEdit.Text = "✏️ Modifier";
            this.btnPEdit.UseVisualStyleBackColor = false;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // btnPAjouter
            // 
            this.btnPAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPAjouter.FlatAppearance.BorderSize = 0;
            this.btnPAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAjouter.ForeColor = System.Drawing.Color.White;
            this.btnPAjouter.Location = new System.Drawing.Point(20, 360);
            this.btnPAjouter.Name = "btnPAjouter";
            this.btnPAjouter.Size = new System.Drawing.Size(352, 38);
            this.btnPAjouter.TabIndex = 71;
            this.btnPAjouter.Text = "➕ Ajouter";
            this.btnPAjouter.UseVisualStyleBackColor = false;
            this.btnPAjouter.Click += new System.EventHandler(this.btnPAjouter_Click);
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPSpecialite.Location = new System.Drawing.Point(20, 315);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(352, 23);
            this.txtPSpecialite.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.Location = new System.Drawing.Point(17, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Specialite";
            // 
            // txtPTel
            // 
            this.txtPTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPTel.Location = new System.Drawing.Point(20, 260);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(352, 23);
            this.txtPTel.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Telephone";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPEmail.Location = new System.Drawing.Point(20, 205);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(352, 23);
            this.txtPEmail.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.Location = new System.Drawing.Point(17, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Email";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPPrenom.Location = new System.Drawing.Point(20, 150);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(352, 23);
            this.txtPPrenom.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.Location = new System.Drawing.Point(17, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Prenom";
            // 
            // txtPNom
            // 
            this.txtPNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPNom.Location = new System.Drawing.Point(20, 95);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(352, 23);
            this.txtPNom.TabIndex = 62;
            // 
            // tabChefDeProjet
            // 
            this.tabChefDeProjet.BackColor = System.Drawing.Color.White;
            this.tabChefDeProjet.Controls.Add(this.btnSelectC);
            this.tabChefDeProjet.Controls.Add(this.btnCSupprimer);
            this.tabChefDeProjet.Controls.Add(this.btnCModifier);
            this.tabChefDeProjet.Controls.Add(this.btnCAjouter);
            this.tabChefDeProjet.Controls.Add(this.txtCDepartement);
            this.tabChefDeProjet.Controls.Add(this.label11);
            this.tabChefDeProjet.Controls.Add(this.txtCTel);
            this.tabChefDeProjet.Controls.Add(this.label12);
            this.tabChefDeProjet.Controls.Add(this.txtCEmail);
            this.tabChefDeProjet.Controls.Add(this.label13);
            this.tabChefDeProjet.Controls.Add(this.txtCPrenom);
            this.tabChefDeProjet.Controls.Add(this.label14);
            this.tabChefDeProjet.Controls.Add(this.txtCNom);
            this.tabChefDeProjet.Controls.Add(this.label15);
            this.tabChefDeProjet.Location = new System.Drawing.Point(4, 24);
            this.tabChefDeProjet.Name = "tabChefDeProjet";
            this.tabChefDeProjet.Padding = new System.Windows.Forms.Padding(15);
            this.tabChefDeProjet.Size = new System.Drawing.Size(392, 552);
            this.tabChefDeProjet.TabIndex = 2;
            this.tabChefDeProjet.Text = "🏢 Chef de projet";
            // 
            // btnSelectC
            // 
            this.btnSelectC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSelectC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectC.ForeColor = System.Drawing.Color.White;
            this.btnSelectC.Location = new System.Drawing.Point(20, 500);
            this.btnSelectC.Name = "btnSelectC";
            this.btnSelectC.Size = new System.Drawing.Size(352, 30);
            this.btnSelectC.TabIndex = 76;
            this.btnSelectC.Text = "👆 Sélectionner";
            this.btnSelectC.UseVisualStyleBackColor = false;
            this.btnSelectC.Visible = false;
            this.btnSelectC.Click += new System.EventHandler(this.btnSelectC_Click);
            // 
            // btnCSupprimer
            // 
            this.btnCSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSupprimer.FlatAppearance.BorderSize = 0;
            this.btnCSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnCSupprimer.Location = new System.Drawing.Point(20, 450);
            this.btnCSupprimer.Name = "btnCSupprimer";
            this.btnCSupprimer.Size = new System.Drawing.Size(352, 38);
            this.btnCSupprimer.TabIndex = 73;
            this.btnCSupprimer.Text = "🗑️ Supprimer";
            this.btnCSupprimer.UseVisualStyleBackColor = false;
            this.btnCSupprimer.Click += new System.EventHandler(this.btnCSupprimer_Click);
            // 
            // btnCModifier
            // 
            this.btnCModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCModifier.FlatAppearance.BorderSize = 0;
            this.btnCModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCModifier.ForeColor = System.Drawing.Color.White;
            this.btnCModifier.Location = new System.Drawing.Point(20, 405);
            this.btnCModifier.Name = "btnCModifier";
            this.btnCModifier.Size = new System.Drawing.Size(352, 38);
            this.btnCModifier.TabIndex = 72;
            this.btnCModifier.Text = "✏️ Modifier";
            this.btnCModifier.UseVisualStyleBackColor = false;
            this.btnCModifier.Click += new System.EventHandler(this.btnCModifier_Click);
            // 
            // btnCAjouter
            // 
            this.btnCAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAjouter.FlatAppearance.BorderSize = 0;
            this.btnCAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAjouter.ForeColor = System.Drawing.Color.White;
            this.btnCAjouter.Location = new System.Drawing.Point(20, 360);
            this.btnCAjouter.Name = "btnCAjouter";
            this.btnCAjouter.Size = new System.Drawing.Size(352, 38);
            this.btnCAjouter.TabIndex = 71;
            this.btnCAjouter.Text = "➕ Ajouter";
            this.btnCAjouter.UseVisualStyleBackColor = false;
            this.btnCAjouter.Click += new System.EventHandler(this.btnCAjouter_Click);
            // 
            // txtCDepartement
            // 
            this.txtCDepartement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCDepartement.Location = new System.Drawing.Point(20, 315);
            this.txtCDepartement.Name = "txtCDepartement";
            this.txtCDepartement.Size = new System.Drawing.Size(352, 23);
            this.txtCDepartement.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label11.Location = new System.Drawing.Point(17, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Departement";
            // 
            // txtCTel
            // 
            this.txtCTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCTel.Location = new System.Drawing.Point(20, 260);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(352, 23);
            this.txtCTel.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.Location = new System.Drawing.Point(17, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Telephone";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCEmail.Location = new System.Drawing.Point(20, 205);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(352, 23);
            this.txtCEmail.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label13.Location = new System.Drawing.Point(17, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Email";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCPrenom.Location = new System.Drawing.Point(20, 150);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(352, 23);
            this.txtCPrenom.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label14.Location = new System.Drawing.Point(17, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Prenom";
            // 
            // txtCNom
            // 
            this.txtCNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCNom.Location = new System.Drawing.Point(20, 95);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(352, 23);
            this.txtCNom.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label15.Location = new System.Drawing.Point(17, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Nom";
            // 
            // dgUtilisateurs
            // 
            this.dgUtilisateurs.AllowUserToAddRows = false;
            this.dgUtilisateurs.AllowUserToDeleteRows = false;
            this.dgUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.dgUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUtilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUtilisateurs.ColumnHeadersHeight = 35;
            this.dgUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUtilisateurs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgUtilisateurs.EnableHeadersVisualStyles = false;
            this.dgUtilisateurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgUtilisateurs.Location = new System.Drawing.Point(420, 80);
            this.dgUtilisateurs.MultiSelect = false;
            this.dgUtilisateurs.Name = "dgUtilisateurs";
            this.dgUtilisateurs.ReadOnly = true;
            this.dgUtilisateurs.RowHeadersVisible = false;
            this.dgUtilisateurs.RowHeadersWidth = 51;
            this.dgUtilisateurs.RowTemplate.Height = 30;
            this.dgUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateurs.Size = new System.Drawing.Size(912, 540);
            this.dgUtilisateurs.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 60);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 Gestion des Utilisateurs";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1172, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✖ Fermer";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1344, 679);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgUtilisateurs);
            this.Controls.Add(this.tabUtilisateurs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Utilisateurs";
            this.AutoScroll = true;
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabUtilisateurs.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChefDeProjet.ResumeLayout(false);
            this.tabChefDeProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUtilisateurs;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDeProjet;
        private System.Windows.Forms.DataGridView dgUtilisateurs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnPAjouter;
        private System.Windows.Forms.TextBox txtPSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPPrenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPNom;
        private System.Windows.Forms.Button btnCSupprimer;
        private System.Windows.Forms.Button btnCModifier;
        private System.Windows.Forms.Button btnCAjouter;
        private System.Windows.Forms.TextBox txtCDepartement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCPrenom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSelectP;
        private System.Windows.Forms.Button btnSelectC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}