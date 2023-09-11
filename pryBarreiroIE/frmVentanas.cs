﻿using System;
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
    public partial class frmVentanas : Form
    {
        public frmVentanas()
        {
            InitializeComponent();
        }

        private void cmdSeguros_Click(object sender, EventArgs e)
        {
            frmSeguros frmSeguros = new frmSeguros();
            frmSeguros.ShowDialog();
        }

        private void cmdUbicacionCarpeta_Click(object sender, EventArgs e)
        {
            frmCarpetas frmCarpetas = new frmCarpetas();
            frmCarpetas.ShowDialog();
        }
    }
}
