using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryBarreiroIE
{
    
    internal class clsLogin
    {
        OleDbConnection conexionBD;
        public void AbrirBD() 
        {
            conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Alumnos\\source\\repos\\pryBarreiroIE\\pryBarreiroIE\\Resources\\Base De Datos.accdb");
            conexionBD.Open();
        }
        
    }
}
