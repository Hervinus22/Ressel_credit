using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace GESTION_REVENDEURS_UNITE
{
    public partial class UcCarte : UserControl
    {
        public UcCarte()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void cmbrefpaiement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbRevendeur.SelectedIndex == -1 || cmbrefpaiement.SelectedIndex == -1 || txtdateExpiration.Text == "" || cmbValidite.SelectedIndex==-1)
                {
                    MessageBox.Show("Tous les champs sont requis svp !!", "MESSAGE");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_Carte", "'" + txtid.Text + "','" + cmbValidite.SelectedItem + "','" + txtdateExpiration.Value.ToString("yyyy-MM-dd") + "','" + cmbrefpaiement.SelectedItem + "','" + CmbRevendeur.SelectedItem + "'", "ENREGISTREMENT REUSSI");
                    M.chargementTableau(dgvcarte, "select * from tcarte", "");
                    M.chargementTableau(dgvDetailCarte, "select * from V_Detailcarte", "");
                    M.chargementLabel(TOTAL, "SELECT SUM(CODE) FROM V_DETAILCARTE ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcCarte_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dgvcarte, "select * from tcarte","");
            M.chargementTableau(dgvDetailCarte, "select * from V_Detailcarte", "");
            M.chargementCombo(CmbRevendeur, "SELECT nom+' '+post_nom+' '+prenom FROM TREVENDEUR");
            M.chargementCombo(cmbrefpaiement,"select Montant from tpaiement");
            M.chargementLabel(TOTAL, "SELECT count(*) FROM V_DETAILCARTE ");
        }

        private void dgvDetailCarte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId2.Text = dgvDetailCarte.CurrentRow.Cells[0].Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("veuillez selectionner d'abord SVP !!", "MESSAGE");
            }
            else
            {
                M.Supprimer("Tcarte", "id", int.Parse(txtid.Text));
                M.chargementTableau(dgvcarte, "select * from tcarte", "");
                M.chargementLabel(TOTAL, "SELECT SUM(CODE) FROM V_DETAILCARTE ");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try {
                if (txtId2.Text == "")
                {
                    MessageBox.Show("veuillez selectionner d'abord le code de la carte svp!!","MESSAGE");
                }
                else
                {
                    Rapport.carte rpt = new Rapport.carte();

                    rpt.DataSource = M.get_Report_X("V_Detailcarte", "code", int.Parse(dgvDetailCarte.CurrentRow.Cells[0].Value.ToString()));

                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
           
        }

        private void dgvcarte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvcarte.CurrentRow.Cells[0].Value.ToString();
            cmbValidite.SelectedItem = dgvcarte.CurrentRow.Cells[1].Value.ToString();
            txtdateExpiration.Text= dgvcarte.CurrentRow.Cells[2].Value.ToString();
            cmbrefpaiement.Text= dgvcarte.CurrentRow.Cells[3].Value.ToString();
            CmbRevendeur.Text= dgvcarte.CurrentRow.Cells[4].Value.ToString();

        }

        private void txtdateExpiration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            guna2Button3.ForeColor = Color.Yellow;
        }

        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            guna2Button3.ForeColor = Color.White;
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button3.FillColor = Color.Black;
        }
    }
}
