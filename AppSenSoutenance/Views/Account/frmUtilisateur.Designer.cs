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
            this.tabUtilisateurs = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
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
            this.btnPRemove = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.tabChefDeProjet = new System.Windows.Forms.TabPage();
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
            this.btnCRemove = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.dgUtilisateurs = new System.Windows.Forms.DataGridView();
            this.tabUtilisateurs.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChefDeProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUtilisateurs
            // 
            this.tabUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabUtilisateurs.Controls.Add(this.tabCandidat);
            this.tabUtilisateurs.Controls.Add(this.tabProfesseur);
            this.tabUtilisateurs.Controls.Add(this.tabChefDeProjet);
            this.tabUtilisateurs.Location = new System.Drawing.Point(12, 12);
            this.tabUtilisateurs.Name = "tabUtilisateurs";
            this.tabUtilisateurs.SelectedIndex = 0;
            this.tabUtilisateurs.Size = new System.Drawing.Size(593, 597);
            this.tabUtilisateurs.TabIndex = 0;
            // 
            // tabCandidat
            // 
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
            this.tabCandidat.Location = new System.Drawing.Point(8, 46);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(577, 543);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candidat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            this.tabCandidat.Click += new System.EventHandler(this.tabCandidat_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(377, 492);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 44);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(377, 421);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 44);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(377, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 44);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(40, 306);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(496, 39);
            this.txtMatricule.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "Matricule";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(40, 234);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(496, 39);
            this.txtTel.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(40, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(496, 39);
            this.txtEmail.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Email";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(40, 87);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(496, 39);
            this.txtPrenom.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(40, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(496, 39);
            this.txtNom.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nom";
            // 
            // tabProfesseur
            // 
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
            this.tabProfesseur.Controls.Add(this.btnPRemove);
            this.tabProfesseur.Controls.Add(this.btnPUpdate);
            this.tabProfesseur.Controls.Add(this.btnPAdd);
            this.tabProfesseur.Location = new System.Drawing.Point(8, 46);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(577, 543);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            this.tabProfesseur.Click += new System.EventHandler(this.tabProfesseur_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 32);
            this.label10.TabIndex = 74;
            this.label10.Text = "Nom";
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(377, 492);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(159, 44);
            this.btnPDelete.TabIndex = 73;
            this.btnPDelete.Text = "&Supprimer";
            this.btnPDelete.UseVisualStyleBackColor = false;
            // 
            // btnPEdit
            // 
            this.btnPEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPEdit.ForeColor = System.Drawing.Color.White;
            this.btnPEdit.Location = new System.Drawing.Point(377, 421);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(159, 44);
            this.btnPEdit.TabIndex = 72;
            this.btnPEdit.Text = "&Modifier";
            this.btnPEdit.UseVisualStyleBackColor = false;
            // 
            // btnPAjouter
            // 
            this.btnPAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAjouter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPAjouter.ForeColor = System.Drawing.Color.White;
            this.btnPAjouter.Location = new System.Drawing.Point(377, 351);
            this.btnPAjouter.Name = "btnPAjouter";
            this.btnPAjouter.Size = new System.Drawing.Size(159, 44);
            this.btnPAjouter.TabIndex = 71;
            this.btnPAjouter.Text = "&Ajouter";
            this.btnPAjouter.UseVisualStyleBackColor = false;
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.Location = new System.Drawing.Point(40, 306);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(496, 39);
            this.txtPSpecialite.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 69;
            this.label6.Text = "Specialite";
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(40, 234);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(496, 39);
            this.txtPTel.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 67;
            this.label7.Text = "Telephone";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(40, 160);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(496, 39);
            this.txtPEmail.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 32);
            this.label8.TabIndex = 65;
            this.label8.Text = "Email";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.Location = new System.Drawing.Point(40, 87);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(496, 39);
            this.txtPPrenom.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 63;
            this.label9.Text = "Prenom";
            // 
            // txtPNom
            // 
            this.txtPNom.Location = new System.Drawing.Point(40, 30);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(496, 39);
            this.txtPNom.TabIndex = 62;
            // 
            // btnPRemove
            // 
            this.btnPRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnPRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPRemove.ForeColor = System.Drawing.Color.White;
            this.btnPRemove.Location = new System.Drawing.Point(377, 781);
            this.btnPRemove.Name = "btnPRemove";
            this.btnPRemove.Size = new System.Drawing.Size(159, 44);
            this.btnPRemove.TabIndex = 60;
            this.btnPRemove.Text = "&Supprimer";
            this.btnPRemove.UseVisualStyleBackColor = false;
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(377, 678);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(159, 44);
            this.btnPUpdate.TabIndex = 59;
            this.btnPUpdate.Text = "&Modifier";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPAdd.ForeColor = System.Drawing.Color.White;
            this.btnPAdd.Location = new System.Drawing.Point(377, 581);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(159, 44);
            this.btnPAdd.TabIndex = 58;
            this.btnPAdd.Text = "&Ajouter";
            this.btnPAdd.UseVisualStyleBackColor = false;
            // 
            // tabChefDeProjet
            // 
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
            this.tabChefDeProjet.Controls.Add(this.btnCRemove);
            this.tabChefDeProjet.Controls.Add(this.btnCUpdate);
            this.tabChefDeProjet.Controls.Add(this.btnCAdd);
            this.tabChefDeProjet.Location = new System.Drawing.Point(8, 46);
            this.tabChefDeProjet.Name = "tabChefDeProjet";
            this.tabChefDeProjet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDeProjet.Size = new System.Drawing.Size(577, 543);
            this.tabChefDeProjet.TabIndex = 2;
            this.tabChefDeProjet.Text = "Chef de projet";
            this.tabChefDeProjet.UseVisualStyleBackColor = true;
            // 
            // btnCSupprimer
            // 
            this.btnCSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnCSupprimer.Location = new System.Drawing.Point(377, 492);
            this.btnCSupprimer.Name = "btnCSupprimer";
            this.btnCSupprimer.Size = new System.Drawing.Size(159, 44);
            this.btnCSupprimer.TabIndex = 73;
            this.btnCSupprimer.Text = "&Supprimer";
            this.btnCSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnCModifier
            // 
            this.btnCModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCModifier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCModifier.ForeColor = System.Drawing.Color.White;
            this.btnCModifier.Location = new System.Drawing.Point(377, 421);
            this.btnCModifier.Name = "btnCModifier";
            this.btnCModifier.Size = new System.Drawing.Size(159, 44);
            this.btnCModifier.TabIndex = 72;
            this.btnCModifier.Text = "&Modifier";
            this.btnCModifier.UseVisualStyleBackColor = false;
            // 
            // btnCAjouter
            // 
            this.btnCAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAjouter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCAjouter.ForeColor = System.Drawing.Color.White;
            this.btnCAjouter.Location = new System.Drawing.Point(377, 351);
            this.btnCAjouter.Name = "btnCAjouter";
            this.btnCAjouter.Size = new System.Drawing.Size(159, 44);
            this.btnCAjouter.TabIndex = 71;
            this.btnCAjouter.Text = "&Ajouter";
            this.btnCAjouter.UseVisualStyleBackColor = false;
            // 
            // txtCDepartement
            // 
            this.txtCDepartement.Location = new System.Drawing.Point(40, 306);
            this.txtCDepartement.Name = "txtCDepartement";
            this.txtCDepartement.Size = new System.Drawing.Size(496, 39);
            this.txtCDepartement.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 32);
            this.label11.TabIndex = 69;
            this.label11.Text = "Departement";
            // 
            // txtCTel
            // 
            this.txtCTel.Location = new System.Drawing.Point(40, 234);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(496, 39);
            this.txtCTel.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 32);
            this.label12.TabIndex = 67;
            this.label12.Text = "Telephone";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(40, 160);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(496, 39);
            this.txtCEmail.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 32);
            this.label13.TabIndex = 65;
            this.label13.Text = "Email";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.Location = new System.Drawing.Point(40, 87);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(496, 39);
            this.txtCPrenom.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 32);
            this.label14.TabIndex = 63;
            this.label14.Text = "Prenom";
            // 
            // txtCNom
            // 
            this.txtCNom.Location = new System.Drawing.Point(40, 30);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(496, 39);
            this.txtCNom.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 32);
            this.label15.TabIndex = 61;
            this.label15.Text = "Nom";
            // 
            // btnCRemove
            // 
            this.btnCRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCRemove.ForeColor = System.Drawing.Color.White;
            this.btnCRemove.Location = new System.Drawing.Point(371, 754);
            this.btnCRemove.Name = "btnCRemove";
            this.btnCRemove.Size = new System.Drawing.Size(159, 44);
            this.btnCRemove.TabIndex = 60;
            this.btnCRemove.Text = "&Supprimer";
            this.btnCRemove.UseVisualStyleBackColor = false;
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCUpdate.Location = new System.Drawing.Point(371, 651);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(159, 44);
            this.btnCUpdate.TabIndex = 59;
            this.btnCUpdate.Text = "&Modifier";
            this.btnCUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCAdd
            // 
            this.btnCAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCAdd.ForeColor = System.Drawing.Color.White;
            this.btnCAdd.Location = new System.Drawing.Point(371, 554);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(159, 44);
            this.btnCAdd.TabIndex = 58;
            this.btnCAdd.Text = "&Ajouter";
            this.btnCAdd.UseVisualStyleBackColor = false;
            // 
            // dgUtilisateurs
            // 
            this.dgUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateurs.Location = new System.Drawing.Point(627, 58);
            this.dgUtilisateurs.Name = "dgUtilisateurs";
            this.dgUtilisateurs.RowHeadersWidth = 82;
            this.dgUtilisateurs.RowTemplate.Height = 26;
            this.dgUtilisateurs.Size = new System.Drawing.Size(663, 540);
            this.dgUtilisateurs.TabIndex = 1;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1344, 679);
            this.ControlBox = false;
            this.Controls.Add(this.dgUtilisateurs);
            this.Controls.Add(this.tabUtilisateurs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabUtilisateurs.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChefDeProjet.ResumeLayout(false);
            this.tabChefDeProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUtilisateurs;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDeProjet;
        private System.Windows.Forms.DataGridView dgUtilisateurs;
        private System.Windows.Forms.Button btnPRemove;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnCRemove;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCAdd;
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
        //private System.Windows.Forms.Label txtPNom;
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
        private System.Windows.Forms.Label label10;
    }
}