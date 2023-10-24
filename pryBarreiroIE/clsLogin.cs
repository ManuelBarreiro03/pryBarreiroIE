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

        public void TraerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";
            grilla.Columns.Add("Id", "Id");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Lugar", "Lugar");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Sexo", "Sexo");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], 
                    lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7]);
                }
            }
        }
        public void BuscarPorCodigo(int codigoSocio, DataGridView grilla)
        {
            ConectarBD();
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
                        grilla.Rows.Clear();
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3],
                        lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7]);
                        seEncuentra = true;
                    }
                }
                if (seEncuentra == false)
                {
                    MessageBox.Show("no existe", "consulta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            lectorBD.Close();
        }
        public void Registros() 
        {
            
        }
    }
}
