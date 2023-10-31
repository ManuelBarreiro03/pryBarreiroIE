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
        int contador;

        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string Usuario, contrasena;
            clsLogin clsLogin = new clsLogin();
            Usuario = txtUsuarios.Text;
            contrasena = txtContrasena.Text;
            this.Hide();
            clsLogin.InicioSesion(Usuario, contrasena);
            this.Show();
            contador++;
            if (contador>=3)
            {
                this.Close();
            }
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            this.Hide();
            frmRegistroUsuario.ShowDialog();
            this.Close();
        }
    }
}