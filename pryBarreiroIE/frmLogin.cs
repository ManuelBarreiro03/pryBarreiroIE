using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryBarreiroIE.Resources
{
    public partial class frmLogin : Form
    {
        clsLogin objBaseDatos;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorCodigo(int.Parse(txtCodigoUsuario.Text));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsLogin();
            objBaseDatos.ConectarBD();
            lblEstadoConexion.Text = objBaseDatos.estadoConexion;
            objBaseDatos.TraerDatos();
            lblDatos.Text = objBaseDatos.datosTabla;
        }
    }
}
