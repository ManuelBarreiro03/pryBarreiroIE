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
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text, contrasena = txtContarsena.Text, confirmarContrasena = txtContarsenaConfirmar.Text;
            clsLogin clsLogin = new clsLogin();
            if (contrasena == confirmarContrasena)
            {
                clsLogin.RegistroUsuario(usuario, contrasena);
            }
            else 
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                cmdCancelar_Click(sender, e);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdRegistrar_Click(sender, e);
            }
        }

        private void txtContarsena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdRegistrar_Click(sender, e);
            }
        }

        private void txtContarsenaConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdRegistrar_Click(sender, e);
            }
        }
    }
}
