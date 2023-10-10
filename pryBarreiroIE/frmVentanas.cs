using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pryBarreiroIE.Resources;

namespace pryBarreiroIE
{
    public partial class frmVentanas : Form
    {
        public frmVentanas()
        {
            InitializeComponent();
        }

        private void cmdSeguros_Click(object sender, EventArgs e)
        {
            frmMuestraArchivos frmSeguros = new frmMuestraArchivos();
            this.Hide();
            frmSeguros.ShowDialog();
        }

        private void cmdUbicacionCarpeta_Click(object sender, EventArgs e)
        {
            frmCreacionArchivos frmCarpetas = new frmCreacionArchivos();
            this.Hide();
            frmCarpetas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaABM frmCargaVentas = new frmCargaABM();
            this.Hide();
            frmCargaVentas.ShowDialog();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}
