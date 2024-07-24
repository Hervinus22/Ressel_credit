namespace GESTION_REVENDEURS_UNITE
{
    partial class ucPaiement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvpaiement = new System.Windows.Forms.DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.GROUP = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.cmbrevendeur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbagent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtid = new System.Windows.Forms.Label();
            this.Txtrecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaiement)).BeginInit();
            this.GROUP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMontant
            // 
            this.txtMontant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMontant.BorderRadius = 15;
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Location = new System.Drawing.Point(19, 94);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "00,00$";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(239, 36);
            this.txtMontant.TabIndex = 4;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // dgvpaiement
            // 
            this.dgvpaiement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpaiement.BackgroundColor = System.Drawing.Color.White;
            this.dgvpaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpaiement.GridColor = System.Drawing.Color.White;
            this.dgvpaiement.Location = new System.Drawing.Point(10, 321);
            this.dgvpaiement.Name = "dgvpaiement";
            this.dgvpaiement.Size = new System.Drawing.Size(1095, 201);
            this.dgvpaiement.TabIndex = 4;
            this.dgvpaiement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpaiement_CellContentClick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button2.BorderRadius = 19;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(395, 216);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(104, 45);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "SUPPRIMER";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(285, 216);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(104, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "ENREGISTRER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // GROUP
            // 
            this.GROUP.Controls.Add(this.label7);
            this.GROUP.Controls.Add(this.label6);
            this.GROUP.Controls.Add(this.label5);
            this.GROUP.Controls.Add(this.label4);
            this.GROUP.Controls.Add(this.panel1);
            this.GROUP.Controls.Add(this.cmbrevendeur);
            this.GROUP.Controls.Add(this.guna2Button2);
            this.GROUP.Controls.Add(this.guna2Button1);
            this.GROUP.Controls.Add(this.txtdate);
            this.GROUP.Controls.Add(this.cmbagent);
            this.GROUP.Controls.Add(this.txtMontant);
            this.GROUP.Controls.Add(this.txtid);
            this.GROUP.Location = new System.Drawing.Point(10, 45);
            this.GROUP.Name = "GROUP";
            this.GROUP.Size = new System.Drawing.Size(526, 270);
            this.GROUP.TabIndex = 3;
            this.GROUP.TabStop = false;
            this.GROUP.Text = "PAIEMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TOTAL);
            this.panel1.Location = new System.Drawing.Point(309, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 71);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 68);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(146, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "TOTAL MONTANT PAYE";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TOTAL.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.TOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TOTAL.Location = new System.Drawing.Point(81, 29);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(25, 27);
            this.TOTAL.TabIndex = 16;
            this.TOTAL.Text = "0";
            // 
            // cmbrevendeur
            // 
            this.cmbrevendeur.BackColor = System.Drawing.Color.Transparent;
            this.cmbrevendeur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbrevendeur.BorderRadius = 15;
            this.cmbrevendeur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbrevendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrevendeur.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrevendeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrevendeur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbrevendeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbrevendeur.ItemHeight = 30;
            this.cmbrevendeur.Location = new System.Drawing.Point(23, 33);
            this.cmbrevendeur.Name = "cmbrevendeur";
            this.cmbrevendeur.Size = new System.Drawing.Size(239, 36);
            this.cmbrevendeur.TabIndex = 13;
            // 
            // txtdate
            // 
            this.txtdate.BorderRadius = 15;
            this.txtdate.Checked = true;
            this.txtdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate.Location = new System.Drawing.Point(19, 216);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(239, 36);
            this.txtdate.TabIndex = 8;
            this.txtdate.Value = new System.DateTime(2023, 10, 19, 7, 50, 41, 746);
            // 
            // cmbagent
            // 
            this.cmbagent.BackColor = System.Drawing.Color.Transparent;
            this.cmbagent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbagent.BorderRadius = 15;
            this.cmbagent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbagent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbagent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbagent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbagent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbagent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbagent.ItemHeight = 30;
            this.cmbagent.Location = new System.Drawing.Point(19, 155);
            this.cmbagent.Name = "cmbagent";
            this.cmbagent.Size = new System.Drawing.Size(239, 36);
            this.cmbagent.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtid.Location = new System.Drawing.Point(286, 16);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(0, 19);
            this.txtid.TabIndex = 3;
            // 
            // Txtrecherche
            // 
            this.Txtrecherche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txtrecherche.BorderRadius = 15;
            this.Txtrecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtrecherche.DefaultText = "";
            this.Txtrecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtrecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtrecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtrecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtrecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtrecherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txtrecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtrecherche.Location = new System.Drawing.Point(818, 279);
            this.Txtrecherche.Name = "Txtrecherche";
            this.Txtrecherche.PasswordChar = '\0';
            this.Txtrecherche.PlaceholderText = "Rechercher....";
            this.Txtrecherche.SelectedText = "";
            this.Txtrecherche.Size = new System.Drawing.Size(287, 36);
            this.Txtrecherche.TabIndex = 5;
            this.Txtrecherche.TextChanged += new System.EventHandler(this.Txtrecherche_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 33);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouveau Paiement *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date paiement *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(31, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nom du revendeur*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Montant *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nom de L\'agent *";
            // 
            // ucPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Txtrecherche);
            this.Controls.Add(this.dgvpaiement);
            this.Controls.Add(this.GROUP);
            this.Name = "ucPaiement";
            this.Size = new System.Drawing.Size(1114, 543);
            this.Load += new System.EventHandler(this.ucPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaiement)).EndInit();
            this.GROUP.ResumeLayout(false);
            this.GROUP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMontant;
        private System.Windows.Forms.DataGridView dgvpaiement;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.GroupBox GROUP;
        private Guna.UI2.WinForms.Guna2ComboBox cmbrevendeur;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbagent;
        private System.Windows.Forms.Label txtid;
        private Guna.UI2.WinForms.Guna2TextBox Txtrecherche;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
