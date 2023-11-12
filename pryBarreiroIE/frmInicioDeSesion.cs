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
            if (contador == 1)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (contador == 2)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (contador>=3)
            {
                MessageBox.Show("limite de intentos alcanzado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdAceptar_Click(sender, e);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                cmdVolver_Click(sender, e);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdAceptar_Click(sender, e);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                cmdVolver_Click(sender, e);
            }
        }
    }
}