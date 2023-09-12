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
        string leerLinea;
        string[] separarDatos;
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

        private void cmdCargaArchivo_Click(object sender, EventArgs e)
        {
            StreamReader srProveedor = new StreamReader("baseproveedores.csv");
            leerLinea = srProveedor.ReadLine();
            separarDatos = leerLinea.Split(';');
            for (int i = 0; i < separarDatos.Length; i++) 
            {
                dgvGrilla.Columns.Add(separarDatos[i], separarDatos[i]);
            }
            while (srProveedor.EndOfStream == false)
            {
                leerLinea = srProveedor.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvGrilla.Rows.Add(separarDatos);
            }
            srProveedor.Close();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            StreamWriter swRegistrar = new StreamWriter("EjemploXD", true);
            swRegistrar.WriteLine(txtRegistrar.Text);
            swRegistrar.Close();
            MessageBox.Show("registrado", "registrado", MessageBoxButtons.OK);
            txtRegistrar.Text = "";
            txtRegistrar.Focus();
        }
    }
}
