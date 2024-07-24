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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try {

                M.testLogin(IDENTIFIANT.Text, PASSWORD.Text);

            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
