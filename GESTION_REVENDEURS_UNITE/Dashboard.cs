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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void chargerCarte()
        {
            chartCarte.Series["Series1"].XValueMember = "validites";
            chartCarte.Series["Series1"].YValueMembers = "Nombre";
            chartCarte.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("v_statcartelivree");
            chartCarte.DataBind();
        }
        public void chargerGenre()
        {
            chartgenre.Series["Series1"].XValueMember = "SEXE";
            chartgenre.Series["Series1"].YValueMembers = "Nombre";
            chartgenre.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("V_CATEGORIEGENRE");
            chartCarte.DataBind();
        }
        public void chargerpaiement()
        { 
            chartPaiement.Series["Series1"].XValueMember = "Montant";
            chartPaiement.Series["Series1"].YValueMembers = "Nombre";
            chartPaiement.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("V_StatPayement");
            chartPaiement.DataBind();
        }
    
        private void Dashboard_Load(object sender, EventArgs e)
        {
            chargerGenre();
            chargerCarte();
            chargerpaiement();
        }
    }
}
