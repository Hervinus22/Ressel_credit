using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_REVENDEURS_UNITE
{
    public partial class ucRevendeurs : UserControl
    {
        public ucRevendeurs()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void ucRevendeurs_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dgvRevendeurs, "select * from trevendeur","");
            M.chargementLabel(nbr, "select count(*) from trevendeur");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            M.CHOISIR_IMAGE(photo);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                if (txtnom.Text=="" || txtpost.Text == "" || txtprenom.Text == "" || cmbsexe.SelectedIndex == -1 || txtdate.Text == "" || txtadresse.Text == "" || txttel.Text == "")
                {
                    MessageBox.Show("Tous les champs sont requis svp !!","Message");
                }
                else
                {
                    M.EXEC_UNIVERSELLE_PICTURE("sp_revendeur","'" + txtid.Text + "','" + txtnom.Text + "','" + txtpost.Text + "','" + txtprenom.Text + "','" + cmbsexe.SelectedItem + "','" + txtdate.Value.ToString("yyyy-MM-dd") + "','" + txtadresse.Text + "','" + txttel.Text +"',@image", "Enregistrement reussi");
                    M.chargementTableau(dgvRevendeurs,"select * from trevendeur","");
                    M.chargementLabel(nbr, "select count(*) from trevendeur");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur"+ex.Message);
            }
        }

        private void dgvRevendeurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtid.Text = dgvRevendeurs.CurrentRow.Cells[0].Value.ToString();
            this.txtnom.Text = dgvRevendeurs.CurrentRow.Cells[1].Value.ToString();
            this.txtpost.Text = dgvRevendeurs.CurrentRow.Cells[2].Value.ToString();
            this.txtprenom.Text = dgvRevendeurs.CurrentRow.Cells[3].Value.ToString();
            this.cmbsexe.SelectedItem = dgvRevendeurs.CurrentRow.Cells[4].Value.ToString();
            this.txtdate.Text = dgvRevendeurs.CurrentRow.Cells[5].Value.ToString();
            this.txtadresse.Text = dgvRevendeurs.CurrentRow.Cells[6].Value.ToString();
            this.txttel.Text = dgvRevendeurs.CurrentRow.Cells[7].Value.ToString();
            M.GET_PHOTO("select photo from trevendeur where id=" + txtid.Text + " ", photo, 0);
        }

        private void TXTRECHERCHE_TextChanged(object sender, EventArgs e)
        {
            dgvRevendeurs.DataSource = M.recherche_Infromation("trevendeur", "Nom", "postnom", "prenom", TXTRECHERCHE.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("veuillez selectionner d'abord SVP !!", "MESSAGE");
            }
            else
            {
                M.Supprimer("TRevendeur", "id", int.Parse(txtid.Text));
                M.chargementTableau(dgvRevendeurs, "select * from trevendeur", "");
            }
        }
    }
}
