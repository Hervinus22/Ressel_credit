using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_REVENDEURS_UNITE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public void switchClic(Control uc, PictureBox btn)
        {
            //move indicator
            SidePanel.Top = btn.Top;
            SidePanel.Top = btn.Top;
            //change control
            pan1.Controls.Clear();
            uc.Dock = pan1.Dock;
            pan1.Controls.Add(uc);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switchClic(new Dashboard(), pictureBox1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switchClic(new ucRevendeurs(), pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switchClic(new ucPaiement(), pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switchClic(new UcCarte(), pictureBox5);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if
                  (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switchClic(new ucParam(), pictureBox6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switchClic(new Dashboard(), pictureBox1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cb = new login();
            cb.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
