namespace AppSenSoutenance.Views.Parametre
{
    partial class frmDepartement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtPrenomCandidat = new System.Windows.Forms.TextBox();
            this.txtNomCandidat = new System.Windows.Forms.TextBox();
            this.txtEmailCandidat = new System.Windows.Forms.TextBox();
            this.txtTelCandidat = new System.Windows.Forms.TextBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.Matricule = new System.Windows.Forms.Label();
            this.txtMDPCandidat = new System.Windows.Forms.TextBox();
            this.dgCandidat = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(77, 592);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(337, 39);
            this.btnModifier.TabIndex = 42;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Visible = false;
            // 
            // txtPrenomCandidat
            // 
            this.txtPrenomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenomCandidat.Location = new System.Drawing.Point(55, 60);
            this.txtPrenomCandidat.Name = "txtPrenomCandidat";
            this.txtPrenomCandidat.Size = new System.Drawing.Size(337, 30);
            this.txtPrenomCandidat.TabIndex = 43;
            // 
            // txtNomCandidat
            // 
            this.txtNomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomCandidat.Location = new System.Drawing.Point(55, 122);
            this.txtNomCandidat.Name = "txtNomCandidat";
            this.txtNomCandidat.Size = new System.Drawing.Size(337, 30);
            this.txtNomCandidat.TabIndex = 44;
            this.txtNomCandidat.TextChanged += new System.EventHandler(this.txtNomCandidat_TextChanged);
            // 
            // txtEmailCandidat
            // 
            this.txtEmailCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailCandidat.Location = new System.Drawing.Point(55, 184);
            this.txtEmailCandidat.Name = "txtEmailCandidat";
            this.txtEmailCandidat.Size = new System.Drawing.Size(337, 30);
            this.txtEmailCandidat.TabIndex = 45;
            this.txtEmailCandidat.TextChanged += new System.EventHandler(this.txtEmailCandidat_TextChanged);
            // 
            // txtTelCandidat
            // 
            this.txtTelCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelCandidat.Location = new System.Drawing.Point(55, 246);
            this.txtTelCandidat.Name = "txtTelCandidat";
            this.txtTelCandidat.Size = new System.Drawing.Size(337, 30);
            this.txtTelCandidat.TabIndex = 46;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricule.Location = new System.Drawing.Point(55, 308);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(337, 30);
            this.txtMatricule.TabIndex = 48;
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Matricule.Location = new System.Drawing.Point(55, 282);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(71, 20);
            this.Matricule.TabIndex = 49;
            this.Matricule.Text = "Matricule";
            // 
            // txtMDPCandidat
            // 
            this.txtMDPCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMDPCandidat.Location = new System.Drawing.Point(55, 370);
            this.txtMDPCandidat.Name = "txtMDPCandidat";
            this.txtMDPCandidat.Size = new System.Drawing.Size(337, 30);
            this.txtMDPCandidat.TabIndex = 47;
            this.txtMDPCandidat.UseSystemPasswordChar = true;
            this.txtMDPCandidat.TextChanged += new System.EventHandler(this.txtMDPCandidat_TextChanged);
            // 
            // dgCandidat
            // 
            this.dgCandidat.AllowUserToAddRows = false;
            this.dgCandidat.AllowUserToDeleteRows = false;
            this.dgCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCandidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCandidat.BackgroundColor = System.Drawing.Color.White;
            this.dgCandidat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCandidat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgCandidat.ColumnHeadersHeight = 40;
            this.dgCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCandidat.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgCandidat.EnableHeadersVisualStyles = false;
            this.dgCandidat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgCandidat.Location = new System.Drawing.Point(498, 12);
            this.dgCandidat.MultiSelect = false;
            this.dgCandidat.Name = "dgCandidat";
            this.dgCandidat.ReadOnly = true;
            this.dgCandidat.RowHeadersVisible = false;
            this.dgCandidat.RowHeadersWidth = 82;
            this.dgCandidat.RowTemplate.Height = 35;
            this.dgCandidat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCandidat.Size = new System.Drawing.Size(936, 732);
            this.dgCandidat.TabIndex = 41;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(77, 541);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(337, 39);
            this.btnSupprimer.TabIndex = 50;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(77, 490);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(337, 39);
            this.btnAjouter.TabIndex = 51;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelection.FlatAppearance.BorderSize = 0;
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelection.ForeColor = System.Drawing.Color.White;
            this.btnSelection.Location = new System.Drawing.Point(77, 643);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(337, 39);
            this.btnSelection.TabIndex = 52;
            this.btnSelection.Text = "👆 Sélectionner";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Visible = false;
            this.btnSelection.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Navy;
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(77, 694);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(156, 39);
            this.btnFermer.TabIndex = 53;
            this.btnFermer.Text = "x Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Visible = false;
            this.btnFermer.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(55, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Prenom.Location = new System.Drawing.Point(55, 96);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(60, 20);
            this.Prenom.TabIndex = 55;
            this.Prenom.Text = "Prenom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(55, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(55, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Telephone";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(55, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Mot de passe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(55, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Departement";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(55, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 30);
            this.textBox1.TabIndex = 59;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // frmDepartement
            // 
            this.ClientSize = new System.Drawing.Size(1439, 747);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPrenomCandidat);
            this.Controls.Add(this.txtNomCandidat);
            this.Controls.Add(this.txtEmailCandidat);
            this.Controls.Add(this.txtTelCandidat);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.txtMDPCandidat);
            this.Controls.Add(this.dgCandidat);
            this.Name = "frmDepartement";
            this.Load += new System.EventHandler(this.frmChefDepartement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDepartement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtPrenomCandidat;
        private System.Windows.Forms.TextBox txtNomCandidat;
        private System.Windows.Forms.TextBox txtEmailCandidat;
        private System.Windows.Forms.TextBox txtTelCandidat;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.TextBox txtMDPCandidat;
        private System.Windows.Forms.DataGridView dgCandidat;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}