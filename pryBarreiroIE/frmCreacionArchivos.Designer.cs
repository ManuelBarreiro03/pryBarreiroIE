namespace pryBarreiroIE
{
    partial class frmCreacionArchivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreacionArchivos));
            this.VentanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdUbicacion = new System.Windows.Forms.Button();
            this.cmdCrearArchivo = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdCargaProveedores = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargarAseguradores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUbicacion
            // 
            this.cmdUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdUbicacion.Location = new System.Drawing.Point(12, 12);
            this.cmdUbicacion.Name = "cmdUbicacion";
            this.cmdUbicacion.Size = new System.Drawing.Size(177, 49);
            this.cmdUbicacion.TabIndex = 0;
            this.cmdUbicacion.Text = "Ubicacion de carpeta";
            this.cmdUbicacion.UseVisualStyleBackColor = true;
            this.cmdUbicacion.Click += new System.EventHandler(this.cmdUbicacion_Click);
            // 
            // cmdCrearArchivo
            // 
            this.cmdCrearArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCrearArchivo.Enabled = false;
            this.cmdCrearArchivo.Location = new System.Drawing.Point(12, 99);
            this.cmdCrearArchivo.Name = "cmdCrearArchivo";
            this.cmdCrearArchivo.Size = new System.Drawing.Size(177, 49);
            this.cmdCrearArchivo.TabIndex = 1;
            this.cmdCrearArchivo.Text = "Crear archivo";
            this.cmdCrearArchivo.UseVisualStyleBackColor = true;
            this.cmdCrearArchivo.Click += new System.EventHandler(this.cmdCrearArchivo_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblUbicacion.Location = new System.Drawing.Point(195, 25);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(148, 36);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNombre.Location = new System.Drawing.Point(12, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // cmdCargaProveedores
            // 
            this.cmdCargaProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCargaProveedores.Location = new System.Drawing.Point(318, 365);
            this.cmdCargaProveedores.Name = "cmdCargaProveedores";
            this.cmdCargaProveedores.Size = new System.Drawing.Size(117, 31);
            this.cmdCargaProveedores.TabIndex = 4;
            this.cmdCargaProveedores.Text = "Cargar Proveedores";
            this.cmdCargaProveedores.UseVisualStyleBackColor = true;
            this.cmdCargaProveedores.Click += new System.EventHandler(this.cmdCargaArchivo_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(195, 67);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(532, 286);
            this.dgvGrilla.TabIndex = 5;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrar.Location = new System.Drawing.Point(12, 154);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(177, 49);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(15, 209);
            this.txtRegistrar.Multiline = true;
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(174, 186);
            this.txtRegistrar.TabIndex = 7;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVolver.Location = new System.Drawing.Point(615, 364);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(117, 31);
            this.cmdVolver.TabIndex = 8;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            this.cmdVolver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdVolver_KeyPress);
            // 
            // cmdCargarAseguradores
            // 
            this.cmdCargarAseguradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCargarAseguradores.Location = new System.Drawing.Point(195, 364);
            this.cmdCargarAseguradores.Name = "cmdCargarAseguradores";
            this.cmdCargarAseguradores.Size = new System.Drawing.Size(117, 31);
            this.cmdCargarAseguradores.TabIndex = 9;
            this.cmdCargarAseguradores.Text = "Cargar Aseguradores";
            this.cmdCargarAseguradores.UseVisualStyleBackColor = true;
            this.cmdCargarAseguradores.Click += new System.EventHandler(this.cmdCargarAseguradores_Click);
            // 
            // frmCreacionArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 408);
            this.Controls.Add(this.cmdCargarAseguradores);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.cmdCargaProveedores);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.cmdCrearArchivo);
            this.Controls.Add(this.cmdUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreacionArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog VentanaCarpetas;
        private System.Windows.Forms.Button cmdUbicacion;
        private System.Windows.Forms.Button cmdCrearArchivo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdCargaProveedores;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.TextBox txtRegistrar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdCargarAseguradores;
    }
}