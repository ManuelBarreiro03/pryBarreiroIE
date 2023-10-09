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


namespace pryBarreiroIE
{
    public partial class frmLogin : Form
    {

        OleDbConnection conexionBD;
        public frmLogin()
        {
            InitializeComponent();

        }


        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            string UsuarioBD;
            conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Alumnos\\source\\repos\\pryBarreiroIE\\pryBarreiroIE\\Resources\\Base De Datos.accdb");
            conexionBD.Open();
            conexionBD.ConnectionString.CompareTo(txtUsuario.Text);
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmVentanas frmVentanas = new frmVentanas();
            this.Hide();
            frmVentanas.ShowDialog();
        }
    }
}
