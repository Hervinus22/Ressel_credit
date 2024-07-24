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
    public partial class ucParam : UserControl
    {
        public ucParam()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        public void vider()
        {
            txtTel.Text = "";
            txtnom.Text = "";
            txtFonction.Text = "";
            txtid.Text = "";


        }
        private void ucParam_Load(object sender, EventArgs e)
        {
            M.chargementLabel(NbrAgent, "select count(*) from tagent");
            M.chargementTableau(dgvagent,"select * from tagent","");
            M.chargementTableau(dgv_user, "select * from tlogin", "");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtnom.Text=="" || txtTel.Text=="" || txtFonction.Text == "" )
                {
                    MessageBox.Show("Tous les champs sont requis svp !!", "MESSAGE");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_Agent", "'" + txtid.Text + "','" + txtnom.Text + "','" + txtFonction.Text + "','" + txtTel.Text+"'", "ENREGISTREMENT REUSSI");
                    M.chargementTableau(dgvagent, "select * from tagent", "");
                    vider();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgvagent.DataSource = M.recherche_Infromation("Tagent","Nom","fonction","telephone",Txtrecherche.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtdisk.SelectedIndex==-1)
            {
                MessageBox.Show("Veuillez selectionner d'abord le disk Svp !!","MESSAGE");
            }
            else
            {
                Classes.ClsGlossiaire.Getinstance().backup(txtbd.Text, txtdisk.Text);
            }
           
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgv_user.CurrentRow.Cells[0].Value.ToString();
            txtusername.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dgv_user.CurrentRow.Cells[2].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(lblid.Text==""){
                MessageBox.Show("veuillez selectionner d'abord SVP !!","MESSAGE");
                    }
            else
            {
                M.Supprimer("Tlogin", "id", int.Parse(lblid.Text));
                M.chargementTableau(dgv_user, "select * from tLogin", "");
            }
         
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtusername.Text == "")
            {
                MessageBox.Show("Tout les champs sont requis svp!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Classes.ClsGlossiaire.Getinstance().EXEC_UNIVERSELLE("Sp_Login", "'" + lblid.Text + "','" + txtusername.Text + "','" + txtPass.Text + "'", "Enregistrement Reussi");
                M.chargementTableau(dgv_user, "select * from tLogin", "");
                txtPass.Text = "";
                txtusername.Text = "";
                txtid.Text = "";
            }

        }
    }
    }
