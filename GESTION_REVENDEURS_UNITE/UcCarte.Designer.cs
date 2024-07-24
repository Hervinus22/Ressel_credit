namespace GESTION_REVENDEURS_UNITE
{
    partial class UcCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCarte));
            this.Txtrecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvcarte = new System.Windows.Forms.DataGridView();
            this.GROUP = new System.Windows.Forms.GroupBox();
            this.CmbRevendeur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.cmbValidite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtdateExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbrefpaiement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetailCarte = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarte)).BeginInit();
            this.GROUP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCarte)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.Txtrecherche.TabIndex = 8;
            // 
            // dgvcarte
            // 
            this.dgvcarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcarte.BackgroundColor = System.Drawing.Color.White;
            this.dgvcarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarte.GridColor = System.Drawing.Color.White;
            this.dgvcarte.Location = new System.Drawing.Point(10, 321);
            this.dgvcarte.Name = "dgvcarte";
            this.dgvcarte.Size = new System.Drawing.Size(1095, 201);
            this.dgvcarte.TabIndex = 7;
            this.dgvcarte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcarte_CellContentClick);
            // 
            // GROUP
            // 
            this.GROUP.Controls.Add(this.label7);
            this.GROUP.Controls.Add(this.label6);
            this.GROUP.Controls.Add(this.label5);
            this.GROUP.Controls.Add(this.label1);
            this.GROUP.Controls.Add(this.CmbRevendeur);
            this.GROUP.Controls.Add(this.panel1);
            this.GROUP.Controls.Add(this.cmbValidite);
            this.GROUP.Controls.Add(this.guna2Button2);
            this.GROUP.Controls.Add(this.guna2Button1);
            this.GROUP.Controls.Add(this.txtdateExpiration);
            this.GROUP.Controls.Add(this.cmbrefpaiement);
            this.GROUP.Controls.Add(this.txtid);
            this.GROUP.Location = new System.Drawing.Point(10, 47);
            this.GROUP.Name = "GROUP";
            this.GROUP.Size = new System.Drawing.Size(526, 268);
            this.GROUP.TabIndex = 6;
            this.GROUP.TabStop = false;
            this.GROUP.Text = "CARTE";
            // 
            // CmbRevendeur
            // 
            this.CmbRevendeur.BackColor = System.Drawing.Color.Transparent;
            this.CmbRevendeur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CmbRevendeur.BorderRadius = 15;
            this.CmbRevendeur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbRevendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRevendeur.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRevendeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRevendeur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbRevendeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbRevendeur.ItemHeight = 30;
            this.CmbRevendeur.Location = new System.Drawing.Point(24, 225);
            this.CmbRevendeur.Name = "CmbRevendeur";
            this.CmbRevendeur.Size = new System.Drawing.Size(220, 36);
            this.CmbRevendeur.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TOTAL);
            this.panel1.Location = new System.Drawing.Point(308, 45);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(63, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "TOTAL CARTE";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TOTAL.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.TOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TOTAL.Location = new System.Drawing.Point(95, 29);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(25, 27);
            this.TOTAL.TabIndex = 16;
            this.TOTAL.Text = "0";
            // 
            // cmbValidite
            // 
            this.cmbValidite.BackColor = System.Drawing.Color.Transparent;
            this.cmbValidite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbValidite.BorderRadius = 15;
            this.cmbValidite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbValidite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValidite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbValidite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbValidite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbValidite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbValidite.ItemHeight = 30;
            this.cmbValidite.Items.AddRange(new object[] {
            "1 AN",
            "2 ANS",
            "3 ANS",
            "4 ANS",
            "5 ANS"});
            this.cmbValidite.Location = new System.Drawing.Point(19, 45);
            this.cmbValidite.Name = "cmbValidite";
            this.cmbValidite.Size = new System.Drawing.Size(220, 36);
            this.cmbValidite.TabIndex = 13;
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
            this.guna2Button2.Location = new System.Drawing.Point(415, 216);
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
            this.guna2Button1.Location = new System.Drawing.Point(271, 216);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(104, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "ENREGISTRER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtdateExpiration
            // 
            this.txtdateExpiration.BorderRadius = 15;
            this.txtdateExpiration.Checked = true;
            this.txtdateExpiration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtdateExpiration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdateExpiration.Location = new System.Drawing.Point(19, 105);
            this.txtdateExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdateExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdateExpiration.Name = "txtdateExpiration";
            this.txtdateExpiration.Size = new System.Drawing.Size(225, 36);
            this.txtdateExpiration.TabIndex = 8;
            this.txtdateExpiration.Value = new System.DateTime(2023, 10, 19, 7, 50, 41, 746);
            this.txtdateExpiration.ValueChanged += new System.EventHandler(this.txtdateExpiration_ValueChanged);
            // 
            // cmbrefpaiement
            // 
            this.cmbrefpaiement.BackColor = System.Drawing.Color.Transparent;
            this.cmbrefpaiement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbrefpaiement.BorderRadius = 15;
            this.cmbrefpaiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbrefpaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrefpaiement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrefpaiement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrefpaiement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbrefpaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbrefpaiement.ItemHeight = 30;
            this.cmbrefpaiement.Location = new System.Drawing.Point(19, 164);
            this.cmbrefpaiement.Name = "cmbrefpaiement";
            this.cmbrefpaiement.Size = new System.Drawing.Size(220, 36);
            this.cmbrefpaiement.TabIndex = 7;
            this.cmbrefpaiement.SelectedIndexChanged += new System.EventHandler(this.cmbrefpaiement_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtid.Location = new System.Drawing.Point(267, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(0, 19);
            this.txtid.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetailCarte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(579, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 207);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details cartes";
            // 
            // dgvDetailCarte
            // 
            this.dgvDetailCarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailCarte.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailCarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCarte.GridColor = System.Drawing.Color.White;
            this.dgvDetailCarte.Location = new System.Drawing.Point(6, 19);
            this.dgvDetailCarte.Name = "dgvDetailCarte";
            this.dgvDetailCarte.Size = new System.Drawing.Size(514, 182);
            this.dgvDetailCarte.TabIndex = 8;
            this.dgvDetailCarte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailCarte_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(184, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 33);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(56, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouvelle carte*";
            // 
            // txtId2
            // 
            this.txtId2.AutoSize = true;
            this.txtId2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtId2.Location = new System.Drawing.Point(558, 40);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(0, 19);
            this.txtId2.TabIndex = 11;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(585, 276);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(141, 39);
            this.guna2Button3.TabIndex = 12;
            this.guna2Button3.Text = "PRINT";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            this.guna2Button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2Button3_MouseClick);
            this.guna2Button3.MouseEnter += new System.EventHandler(this.guna2Button3_MouseEnter);
            this.guna2Button3.MouseLeave += new System.EventHandler(this.guna2Button3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Revendeur*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Montant*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Validité*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date Expiration *";
            // 
            // UcCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txtrecherche);
            this.Controls.Add(this.dgvcarte);
            this.Controls.Add(this.GROUP);
            this.Name = "UcCarte";
            this.Size = new System.Drawing.Size(1114, 543);
            this.Load += new System.EventHandler(this.UcCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarte)).EndInit();
            this.GROUP.ResumeLayout(false);
            this.GROUP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCarte)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Txtrecherche;
        private System.Windows.Forms.DataGridView dgvcarte;
        private System.Windows.Forms.GroupBox GROUP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TOTAL;
        private Guna.UI2.WinForms.Guna2ComboBox cmbValidite;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdateExpiration;
        private Guna.UI2.WinForms.Guna2ComboBox cmbrefpaiement;
        private System.Windows.Forms.Label txtid;
        private Guna.UI2.WinForms.Guna2ComboBox CmbRevendeur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetailCarte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtId2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}
