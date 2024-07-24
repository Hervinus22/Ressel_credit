namespace GESTION_REVENDEURS_UNITE
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.group = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chartCarte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartgenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPaiement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.group.SuspendLayout();
            this.groupP.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(736, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(365, 213);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // group
            // 
            this.group.Controls.Add(this.chartPaiement);
            this.group.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.group.Location = new System.Drawing.Point(7, 23);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(352, 221);
            this.group.TabIndex = 1;
            this.group.Text = "STATISTIQUE SUR  LE GENRE DE REVENDEUR";
            // 
            // groupP
            // 
            this.groupP.Controls.Add(this.chartgenre);
            this.groupP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupP.Location = new System.Drawing.Point(383, 23);
            this.groupP.Name = "groupP";
            this.groupP.Size = new System.Drawing.Size(333, 221);
            this.groupP.TabIndex = 2;
            this.groupP.Text = "STATISTIQUE SUR  LE GENRE DE REVENDEUR";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.chartCarte);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(7, 250);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1104, 290);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "STATISTIQUE SUR  LES CARTES LIVREES";
            // 
            // chartCarte
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCarte.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCarte.Legends.Add(legend3);
            this.chartCarte.Location = new System.Drawing.Point(12, 50);
            this.chartCarte.Name = "chartCarte";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCarte.Series.Add(series3);
            this.chartCarte.Size = new System.Drawing.Size(958, 240);
            this.chartCarte.TabIndex = 0;
            this.chartCarte.Text = "chart1";
            // 
            // chartgenre
            // 
            chartArea2.Name = "ChartArea1";
            this.chartgenre.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartgenre.Legends.Add(legend2);
            this.chartgenre.Location = new System.Drawing.Point(13, 45);
            this.chartgenre.Name = "chartgenre";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartgenre.Series.Add(series2);
            this.chartgenre.Size = new System.Drawing.Size(304, 168);
            this.chartgenre.TabIndex = 1;
            this.chartgenre.Text = "chart1";
            // 
            // chartPaiement
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPaiement.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPaiement.Legends.Add(legend1);
            this.chartPaiement.Location = new System.Drawing.Point(12, 45);
            this.chartPaiement.Name = "chartPaiement";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPaiement.Series.Add(series1);
            this.chartPaiement.Size = new System.Drawing.Size(326, 168);
            this.chartPaiement.TabIndex = 2;
            this.chartPaiement.Text = "chart2";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupP);
            this.Controls.Add(this.group);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1114, 543);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.group.ResumeLayout(false);
            this.groupP.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaiement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox group;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaiement;
        private Guna.UI2.WinForms.Guna2GroupBox groupP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgenre;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCarte;
    }
}
