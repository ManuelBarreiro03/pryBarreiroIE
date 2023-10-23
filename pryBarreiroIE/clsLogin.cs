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
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + @"../../Resources/EL_CLUB.accdb";
        public string estadoConexion = "";
        public string datosTabla;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void TraerDatos()
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                }
            }
        }
        public void BuscarPorCodigo(int codigoSocio)
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                bool seEncuentra = false;
                while (lectorBD.Read())
                {
                    if (int.Parse(lectorBD[0].ToString()) == codigoSocio)
                    {
                        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        seEncuentra = true;
                        break;
                    }
                }
                if (true)
                {

                }
            }
        }
    }
}
