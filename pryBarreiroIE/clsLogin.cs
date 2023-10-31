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
using System.IO;
using System.Diagnostics.Contracts;

namespace pryBarreiroIE
{

    internal class clsLogin
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

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
            lectorBD.Close();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Registros";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            objDS = new DataSet();
            adaptadorBD.Fill(objDS, "Registros");

            DataTable objTabla = objDS.Tables["Registros"];
            DataRow nuevoRegistro = objTabla.NewRow();

            nuevoRegistro["Categoria"] = "Conexion BD";
            nuevoRegistro["FechaHora"] = DateTime.Now;
            nuevoRegistro["Descripcion"] = "Conexion exitosa";

            objTabla.Rows.Add(nuevoRegistro);

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
            adaptadorBD.Update(objDS, "Registros");
        }
        public void BuscarPorCodigo(string codigoSocio, DataGridView grilla)
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
                    if (lectorBD[0].ToString() == codigoSocio || lectorBD[2].ToString() == codigoSocio)
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
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Registros";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            objDS = new DataSet();
            adaptadorBD.Fill(objDS, "Registros");

            DataTable objTabla = objDS.Tables["Registros"];
            DataRow nuevoRegistro = objTabla.NewRow();

            nuevoRegistro["Categoria"] = "Consulta";
            nuevoRegistro["FechaHora"] = DateTime.Now;
            nuevoRegistro["Descripcion"] = "Consulta exitosa";

            objTabla.Rows.Add(nuevoRegistro);

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
            adaptadorBD.Update(objDS, "Registros");
        }
        public void Registros()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                objDS = new DataSet();
                adaptadorBD.Fill(objDS, "Registros");

                DataTable objTabla = objDS.Tables["Registros"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Registros");

                MessageBox.Show("registro exitoso", "Registros");
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
        public void InicioSesion(string Usuario, string contra)
        {
            try
            {
                bool seEncuentra = false;
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuarios";

                lectorBD = comandoBD.ExecuteReader();
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == Usuario && lectorBD[2].ToString() == contra)
                        {
                            seEncuentra = true;
                            frmVentanas frmVentanas = new frmVentanas();
                            frmVentanas.ShowDialog();
                            break;
                        }
                    }
                }
                if (seEncuentra == false)
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                    lectorBD.Close();
            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }
        public void RegistroUsuario(string Usuario, string contra) 
        {
            try
            {
                bool seEncuentra = false;
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuarios";
               
                lectorBD = comandoBD.ExecuteReader();
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == Usuario)
                        {
                            MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            seEncuentra = true;
                        }
                    }
                    lectorBD.Close();
                    if (seEncuentra == false)
                    {
                        adaptadorBD = new OleDbDataAdapter(comandoBD);
                        objDS = new DataSet();
                        adaptadorBD.Fill(objDS, "Usuarios");

                        DataTable objTabla = objDS.Tables["Usuarios"];
                        DataRow nuevoRegistro = objTabla.NewRow();

                        nuevoRegistro["Usuario"] = Usuario;
                        nuevoRegistro["Contrasena"] = contra;
                        nuevoRegistro["Categoria"] = "Usuario";

                        objTabla.Rows.Add(nuevoRegistro);

                        OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                        adaptadorBD.Update(objDS, "Usuarios");
                        MessageBox.Show("Usuario Registrado con Exito", "Registro", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fatal Error");
            }
        }
        public void TraerLogs(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Registros";
            grilla.Columns.Add("Categoria", "Categoria");
            grilla.Columns.Add("Fecha y Hora", "Fecha y Hora");
            grilla.Columns.Add("Descripcion", "Descripcion");

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3]);
                }
            }
            lectorBD.Close();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Registros";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            objDS = new DataSet();
            adaptadorBD.Fill(objDS, "Registros");

            DataTable objTabla = objDS.Tables["Registros"];
            DataRow nuevoRegistro = objTabla.NewRow();

            nuevoRegistro["Categoria"] = "Registros";
            nuevoRegistro["FechaHora"] = DateTime.Now;
            nuevoRegistro["Descripcion"] = "Consulta Logs";

            objTabla.Rows.Add(nuevoRegistro);

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
            adaptadorBD.Update(objDS, "Registros");
        }
    }
}
