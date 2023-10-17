using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using pryBarreiroIE.Properties;

namespace pryBarreiroIE
{
    
    internal class clsLogin
    {
        public static void AbrirBD()
        {
            //F9 y F10 para depurar y revisar
           OleDbConnection conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + @"../../" + "Resources/Base De Datos.accdb");
            conexionBD.Open();
            
        }
        
    }
}
