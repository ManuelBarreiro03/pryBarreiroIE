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
    public partial class frmGrilla : Form
    {
        string leerLinea;
        string[] separarDatos;
        public frmGrilla()
        {
            InitializeComponent();
            
        }

        private void frmGrilla_Load(object sender, EventArgs e)
        {
            
            dgvMuestraGrilla.Rows.Clear();
            dgvMuestraGrilla.Columns.Clear();
            StreamReader srAseguradores = new StreamReader(@"../../../" + );
            leerLinea = srAseguradores.ReadLine();
            separarDatos = leerLinea.Split(';');
            for (int i = 0; i < separarDatos.Length; i++)
            {
                dgvMuestraGrilla.Columns.Add(separarDatos[i], separarDatos[i]);
            }
            while (srAseguradores.EndOfStream == false)
            {
                leerLinea = srAseguradores.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvMuestraGrilla.Rows.Add(separarDatos);
            }
            srAseguradores.Close();
        }
    }
}
