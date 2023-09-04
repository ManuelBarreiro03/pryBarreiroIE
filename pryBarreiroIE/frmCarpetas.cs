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

namespace pryBarreiroIE
{

    public partial class frmCarpetas : Form
    {
        string ruta;
        public frmCarpetas()
        {
            InitializeComponent();
        }

        private void cmdUbicacion_Click(object sender, EventArgs e)
        {
            VentanaCarpetas.ShowDialog();
            lblUbicacion.Text = VentanaCarpetas.SelectedPath;
            txtNombre.Enabled = true;
            cmdCrearArchivo.Enabled = true;
        }

        private void cmdCrearArchivo_Click(object sender, EventArgs e)
        {
            ruta = lblUbicacion.Text + "/" + txtNombre.Text;
            StreamWriter swArchivo = new StreamWriter(ruta, false);
            MessageBox.Show("Archivo creado");
        }
    }
}
