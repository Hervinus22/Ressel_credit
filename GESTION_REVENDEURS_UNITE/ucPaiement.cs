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
    public partial class ucPaiement : UserControl
    {
        public ucPaiement()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try{
                if (cmbagent.SelectedIndex ==-1 || cmbrevendeur.SelectedIndex== -1 || txtdate.Text=="" || txtMontant.Text==""){
                    MessageBox.Show("Tous les champs sont requis svp !!", "MESSAGE");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_paiement","'"+txtid.Text+"','"+cmbrevendeur.SelectedItem+"','"+ float.Parse(txtMontant.Text)+"','"+cmbagent.SelectedItem+"','"+txtdate.Value.ToString("yyyy-MM-dd")+"'","ENREGISTREMENT REUSSI");
                    M.chargementTableau(dgvpaiement, "select * from tpaiement", "");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvpaiement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvpaiement.CurrentRow.Cells[0].Value.ToString();
            cmbrevendeur.Text= dgvpaiement.CurrentRow.Cells[1].Value.ToString();
            txtMontant.Text= dgvpaiement.CurrentRow.Cells[2].Value.ToString();
            cmbagent.Text= dgvpaiement.CurrentRow.Cells[3].Value.ToString();
            txtdate.Text= dgvpaiement.CurrentRow.Cells[4].Value.ToString();

        }

        private void ucPaiement_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dgvpaiement, "select * from tpaiement", ""); 
            M.chargementCombo(cmbrevendeur, "SELECT nom+' '+post_nom+' '+prenom FROM TREVENDEUR");
            M.chargementCombo(cmbagent, "SELECT NOM FROM TAGENT");
            M.chargementLabel(TOTAL, "select count(*) from V_Detailcarte");
            M.chargementLabel(TOTAL, "SELECT sum(Montant) FROM TPAIEMENT");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("veuillez selectionner d'abord SVP !!", "MESSAGE");
            }
            else
            {
                M.Supprimer("Tpaiement", "id", int.Parse(txtid.Text));
                M.chargementTableau(dgvpaiement, "select * from tpaiement", "");
            }
        }

        private void Txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgvpaiement.DataSource = M.recherche_Infromation("Tpaiement", "id","refrevendeur","Datepaiement", Txtrecherche.Text);
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
