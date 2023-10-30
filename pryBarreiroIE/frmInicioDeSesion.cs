using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroIE
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmVentanas frmVentanas = new frmVentanas();
            this.Hide();
            frmVentanas.ShowDialog();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string Usuario, contrasena;
            clsLogin clsLogin = new clsLogin();
            Usuario = txtUsuarios.Text;
            contrasena = txtContrasena.Text;
            clsLogin.InicioSesion(Usuario, contrasena);
        }
    }
}
