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
        static public string[] VectorDatos = new string[7];
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

        private void frmCargaABM_Load(object sender, EventArgs e)
        {
            dgvAseguradores.Rows.Clear();
            dgvAseguradores.Columns.Clear();
            StreamReader srAseguradores = new StreamReader(@"../../" + "resources/Listado de aseguradores.csv");
            leerLinea = srAseguradores.ReadLine();
            separarDatos = leerLinea.Split(';');
            for (int i = 0; i < separarDatos.Length; i++)
            {
                dgvAseguradores.Columns.Add(separarDatos[i], separarDatos[i]);
            }
            while (srAseguradores.EndOfStream == false)
            {
                leerLinea = srAseguradores.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvAseguradores.Rows.Add(separarDatos);
            }
            srAseguradores.Close();
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

        private void cmdVerificar2_Click(object sender, EventArgs e)
        {
            if (txtNumero2.Text == "")
            {
                MessageBox.Show("Coloque Numero", "Error", MessageBoxButtons.OK);
                txtNumero2.Focus();
            }
            else
            {
                VectorDatos[1] = txtNumero2.Text;
                if (txtEntidad2.Text == "")
                {
                    MessageBox.Show("Coloque Entidad", "Error", MessageBoxButtons.OK);
                    txtEntidad2.Focus();
                }
                else
                {
                    VectorDatos[1] = txtEntidad2.Text;
                    if (txtApertura2.Text == "")
                    {
                        MessageBox.Show("Coloque Apertura", "Error", MessageBoxButtons.OK);
                        txtApertura2.Focus();
                    }
                    else
                    {
                        VectorDatos[1] = txtApertura2.Text;
                        if (txtNExpte2.Text == "")
                        {
                            MessageBox.Show("Coloque Nº Expte", "Error", MessageBoxButtons.OK);
                            txtNExpte2.Focus();
                        }
                        else
                        {
                            VectorDatos[1] = txtNExpte2.Text;
                            if (txtJurisdiccion2.Text == "")
                            {
                                MessageBox.Show("Coloque Jurisdicción", "Error", MessageBoxButtons.OK);
                                txtJurisdiccion2.Focus();
                            }
                            else
                            {
                                VectorDatos[1] = txtJurisdiccion2.Text;
                                if (txtDireccion2.Text == "")
                                {
                                    MessageBox.Show("Coloque Dirección", "Error", MessageBoxButtons.OK);
                                    txtDireccion2.Focus();
                                }
                                else
                                {
                                    VectorDatos[1] = txtDireccion2.Text;
                                    if (txtLiquiResp2.Text == "")
                                    {
                                        MessageBox.Show("Coloque Liqui. Resp.", "Error", MessageBoxButtons.OK);
                                        txtLiquiResp2.Focus();
                                    }
                                    else
                                    {
                                        VectorDatos[1] = txtLiquiResp2.Text;
                                        cmdAlta2.Enabled = true;
                                        cmdBaja2.Enabled = true;
                                        cmdModificacion2.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmdVerificar1_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                MessageBox.Show("Coloque Numero","Error", MessageBoxButtons.OK);
                txtNumero1.Focus();
            }
            else
            {
                if (txtEntidad1.Text == "")
                {
                    MessageBox.Show("Coloque Entidad", "Error", MessageBoxButtons.OK);
                    txtEntidad1.Focus();
                }
                else
                {
                    if (txtApertura1.Text == "")
                    {
                        MessageBox.Show("Coloque Apertura", "Error", MessageBoxButtons.OK);
                        txtApertura1.Focus();
                    }
                    else
                    {
                        if (txtNExpte1.Text == "")
                        {
                            MessageBox.Show("Coloque Nº Expte", "Error", MessageBoxButtons.OK);
                            txtNExpte1.Focus();
                        }
                        else
                        {
                            if (txtJurisdiccion1.Text == "")
                            {
                                MessageBox.Show("Coloque Jurisdicción", "Error", MessageBoxButtons.OK);
                                txtJurisdiccion1.Focus();
                            }
                            else
                            {
                                if (txtDireccion1.Text == "")
                                {
                                    MessageBox.Show("Coloque Dirección","Error", MessageBoxButtons.OK);
                                    txtDireccion1.Focus();
                                }
                                else
                                {
                                    if (txtLiquiResp1.Text == "")
                                    {
                                        MessageBox.Show("Coloque Liqui. Resp.", "Error", MessageBoxButtons.OK);
                                        txtLiquiResp1.Focus();
                                    }
                                    else
                                    {
                                        cmdAlta1.Enabled = true;
                                        cmdBaja1.Enabled = true;
                                        cmdModificacion1.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmdAlta2_Click(object sender, EventArgs e)
        {
            StreamWriter srAlta = new StreamWriter(@"../../" + "resources/Listado de aseguradores.csv");
        }
    }
}
