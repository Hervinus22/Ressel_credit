namespace GESTION_REVENDEURS_UNITE
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDENTIFIANT = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 451);
            this.panel1.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(315, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 23);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "X";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Guna2Button1);
            this.panel2.Controls.Add(this.PASSWORD);
            this.panel2.Controls.Add(this.IDENTIFIANT);
            this.panel2.Controls.Add(this.PictureBox1);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Location = new System.Drawing.Point(9, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 426);
            this.panel2.TabIndex = 6;
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.AutoRoundedCorners = true;
            this.Guna2Button1.BorderRadius = 28;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.Location = new System.Drawing.Point(48, 339);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(221, 59);
            this.Guna2Button1.TabIndex = 7;
            this.Guna2Button1.Text = "Connexion";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // PASSWORD
            // 
            this.PASSWORD.Animated = true;
            this.PASSWORD.AutoRoundedCorners = true;
            this.PASSWORD.BorderColor = System.Drawing.Color.Black;
            this.PASSWORD.BorderRadius = 18;
            this.PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PASSWORD.DefaultText = "";
            this.PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PASSWORD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PASSWORD.Location = new System.Drawing.Point(42, 267);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.PlaceholderText = "Mot de passe";
            this.PASSWORD.SelectedText = "";
            this.PASSWORD.Size = new System.Drawing.Size(234, 38);
            this.PASSWORD.TabIndex = 4;
            this.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDENTIFIANT
            // 
            this.IDENTIFIANT.Animated = true;
            this.IDENTIFIANT.AutoRoundedCorners = true;
            this.IDENTIFIANT.BorderColor = System.Drawing.Color.Black;
            this.IDENTIFIANT.BorderRadius = 20;
            this.IDENTIFIANT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDENTIFIANT.DefaultText = "";
            this.IDENTIFIANT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDENTIFIANT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDENTIFIANT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDENTIFIANT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDENTIFIANT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDENTIFIANT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDENTIFIANT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDENTIFIANT.Location = new System.Drawing.Point(42, 209);
            this.IDENTIFIANT.Name = "IDENTIFIANT";
            this.IDENTIFIANT.PasswordChar = '\0';
            this.IDENTIFIANT.PlaceholderText = "Identifiant";
            this.IDENTIFIANT.SelectedText = "";
            this.IDENTIFIANT.Size = new System.Drawing.Size(234, 43);
            this.IDENTIFIANT.TabIndex = 2;
            this.IDENTIFIANT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(29, 63);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(269, 119);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(128, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 28);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel panel2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2TextBox PASSWORD;
        internal Guna.UI2.WinForms.Guna2TextBox IDENTIFIANT;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
    }
}