using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace GESTION_REVENDEURS_UNITE.Classes
{
    class ClsConnexion
    {
            public string chemin;

            public object AONS { get; private set; }

            public void connect()
            {
                chemin = @"Data Source=DESKTOP-JEKPT9T;Initial Catalog=Gestion_de_Revendeurs_Soft;Integrated Security=True";

            }


        }

    }

