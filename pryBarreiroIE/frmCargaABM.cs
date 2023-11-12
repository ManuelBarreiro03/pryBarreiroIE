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
                if (txtEntidad2.Text == "")
                {
                    MessageBox.Show("Coloque Entidad", "Error", MessageBoxButtons.OK);
                    txtEntidad2.Focus();
                }
                else
                {
                    if (txtApertura2.Text == "")
                    {
                        MessageBox.Show("Coloque Apertura", "Error", MessageBoxButtons.OK);
                        txtApertura2.Focus();
                    }
                    else
                    {
                        if (txtNExpte2.Text == "")
                        {
                            MessageBox.Show("Coloque Nº Expte", "Error", MessageBoxButtons.OK);
                            txtNExpte2.Focus();
                        }
                        else
                        {
                            if (txtJurisdiccion2.Text == "")
                            {
                                MessageBox.Show("Coloque Jurisdicción", "Error", MessageBoxButtons.OK);
                                txtJurisdiccion2.Focus();
                            }
                            else
                            {
                                if (txtDireccion2.Text == "")
                                {
                                    MessageBox.Show("Coloque Dirección", "Error", MessageBoxButtons.OK);
                                    txtDireccion2.Focus();
                                }
                                else
                                {
                                    if (txtLiquiResp2.Text == "")
                                    {
                                        MessageBox.Show("Coloque Liqui. Resp.", "Error", MessageBoxButtons.OK);
                                        txtLiquiResp2.Focus();
                                    }
                                    else
                                    {
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

        private void cmdLimpiar1_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero1.Enabled = true;
            txtEntidad1.Text = "";
            txtApertura1.Text = "";
            txtNExpte1.Text = "";
            txtJurisdiccion1.Text = "";
            txtDireccion1.Text = "";
            txtLiquiResp1.Text = "";
            cmdAlta1.Enabled = false;
            cmdBaja1.Enabled = false;
            cmdModificacion1.Enabled = false;
        }

        private void cmdLimpiar2_Click(object sender, EventArgs e)
        {
            txtNumero2.Text = "";
            txtNumero2.Enabled = true;
            txtEntidad2.Text = "";
            txtApertura2.Text = "";
            txtNExpte2.Text = "";
            txtJurisdiccion2.Text = "";
            txtDireccion2.Text = "";
            txtLiquiResp2.Text = "";
            cmdAlta2.Enabled = false;
            cmdBaja2.Enabled = false;
            cmdModificacion2.Enabled = false;
        }

        private void dgvAseguradores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero2.Text = dgvAseguradores.CurrentRow.Cells[0].Value.ToString();
            txtNumero2.Enabled = false;
            txtEntidad2.Text = dgvAseguradores.CurrentRow.Cells[1].Value.ToString();
            txtApertura2.Text = dgvAseguradores.CurrentRow.Cells[2].Value.ToString();
            txtNExpte2.Text = dgvAseguradores.CurrentRow.Cells[3].Value.ToString();
            txtJurisdiccion2.Text = dgvAseguradores.CurrentRow.Cells[4].Value.ToString();
            txtDireccion2.Text = dgvAseguradores.CurrentRow.Cells[5].Value.ToString();
            txtLiquiResp2.Text = dgvAseguradores.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero1.Text = dgvAseguradores.CurrentRow.Cells[0].Value.ToString();
            txtNumero1.Enabled = false;
            txtEntidad1.Text = dgvAseguradores.CurrentRow.Cells[1].Value.ToString();
            txtApertura1.Text = dgvAseguradores.CurrentRow.Cells[2].Value.ToString();
            txtNExpte1.Text = dgvAseguradores.CurrentRow.Cells[3].Value.ToString();
            txtJurisdiccion1.Text = dgvAseguradores.CurrentRow.Cells[4].Value.ToString();
            txtDireccion1.Text = dgvAseguradores.CurrentRow.Cells[5].Value.ToString();
            txtLiquiResp1.Text = dgvAseguradores.CurrentRow.Cells[6].Value.ToString();
        }

        private void cmdAlta2_Click(object sender, EventArgs e)
        {
            StreamWriter srAlta2 = new StreamWriter(@"../../" + "resources/Listado de aseguradores.csv", true);
            srAlta2.WriteLine(txtNumero2.Text + ";" + txtEntidad2.Text + ";" + txtApertura2.Text + ";" + txtNExpte2.Text + ";" + txtJurisdiccion2.Text + ";" + txtDireccion2.Text + ";" + txtLiquiResp2.Text);
            srAlta2.Close();
            MessageBox.Show("Venta cargada");
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
            txtNumero2.Text = "";
            txtNumero2.Enabled = true;
            txtEntidad2.Text = "";
            txtApertura2.Text = "";
            txtNExpte2.Text = "";
            txtJurisdiccion2.Text = "";
            txtDireccion2.Text = "";
            txtLiquiResp2.Text = "";
            cmdAlta2.Enabled = false;
            cmdBaja2.Enabled = false;
            cmdModificacion2.Enabled = false;
        }

        private void cmdAlta1_Click(object sender, EventArgs e)
        {
            StreamWriter srAlta1 = new StreamWriter(@"../../" + "resources/Base Proveedores.csv", true);
            srAlta1.WriteLine(txtNumero1.Text + ";" + txtEntidad1.Text + ";" + txtApertura1.Text + ";" + txtNExpte1.Text + ";" + txtJurisdiccion1.Text + ";" + txtDireccion1.Text + ";" + txtLiquiResp1.Text);
            srAlta1.Close();
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
            MessageBox.Show("Venta cargada");
            txtNumero1.Text = "";
            txtNumero1.Enabled = true;
            txtEntidad1.Text = "";
            txtApertura1.Text = "";
            txtNExpte1.Text = "";
            txtJurisdiccion1.Text = "";
            txtDireccion1.Text = "";
            txtLiquiResp1.Text = "";
            cmdAlta1.Enabled = false;
            cmdBaja1.Enabled = false;
            cmdModificacion1.Enabled = false;
        }

        private void cmdVerificar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            { 
                cmdVerificar2_Click(sender, e);
            }
        }

        private void cmdVolver2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                cmdVolver2_Click(sender, e);
            }
        }

        private void cmdVolver1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                cmdVolver1_Click(sender, e);
            }
        }
    }
}
