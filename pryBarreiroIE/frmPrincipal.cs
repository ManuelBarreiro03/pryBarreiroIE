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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion frmInicioDeSesion = new frmInicioDeSesion();
            this.Hide();
            frmInicioDeSesion.ShowDialog();
            this.Close();
        }
    }
}
