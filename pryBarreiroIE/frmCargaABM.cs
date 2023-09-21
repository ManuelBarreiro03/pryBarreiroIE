using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroIE
{
    public partial class frmCargaABM : Form
    {
        string leerLinea;
        string[] separarDatos;
        public frmCargaABM()
        {
            InitializeComponent();
        }

        private void cmdVolver1_Click(object sender, EventArgs e)
        {
            frmVentanas frmVentanas = new frmVentanas();
            this.Hide();
            frmVentanas.ShowDialog();
        }

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            frmVentanas frmVentanas = new frmVentanas();
            this.Hide();
            frmVentanas.ShowDialog();
        }
       
        private void cmdCargarGrilla_Click(object sender, EventArgs e)
        {
            dgvProveedores.Rows.Clear();
            dgvProveedores.Columns.Clear();
            StreamReader srProveedor = new StreamReader(@"../../" + "resources/Base Proveedores.csv");
            leerLinea = srProveedor.ReadLine();
            separarDatos = leerLinea.Split(';');
            for (int i = 0; i < separarDatos.Length; i++)
            {
                dgvProveedores.Columns.Add(separarDatos[i], separarDatos[i]);
            }
            while (srProveedor.EndOfStream == false)
            {
                leerLinea = srProveedor.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvProveedores.Rows.Add(separarDatos);
            }
            srProveedor.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvAseguradores.Rows.Clear();
            dgvAseguradores.Columns.Clear();
            StreamReader srProveedor = new StreamReader(@"../../" + "resources/Listado de aseguradores.csv");
            leerLinea = srProveedor.ReadLine();
            separarDatos = leerLinea.Split(';');
            for (int i = 0; i < separarDatos.Length; i++)
            {
                dgvAseguradores.Columns.Add(separarDatos[i], separarDatos[i]);
            }
            while (srProveedor.EndOfStream == false)
            {
                leerLinea = srProveedor.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvAseguradores.Rows.Add(separarDatos);
            }
            srProveedor.Close();
        }

    }
}
