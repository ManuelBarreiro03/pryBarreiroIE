namespace pryBarreiroIE
{
    partial class frmCarpetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetas));
            this.VentanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdUbicacion = new System.Windows.Forms.Button();
            this.cmdCrearArchivo = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdCargaArchivo = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUbicacion
            // 
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
            // cmdCargaArchivo
            // 
            this.cmdCargaArchivo.Location = new System.Drawing.Point(12, 154);
            this.cmdCargaArchivo.Name = "cmdCargaArchivo";
            this.cmdCargaArchivo.Size = new System.Drawing.Size(177, 49);
            this.cmdCargaArchivo.TabIndex = 4;
            this.cmdCargaArchivo.Text = "Cargar Aseguradores";
            this.cmdCargaArchivo.UseVisualStyleBackColor = true;
            this.cmdCargaArchivo.Click += new System.EventHandler(this.cmdCargaArchivo_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(212, 105);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(391, 241);
            this.dgvGrilla.TabIndex = 5;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(12, 209);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(177, 49);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(14, 268);
            this.txtRegistrar.Multiline = true;
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(174, 78);
            this.txtRegistrar.TabIndex = 7;
            // 
            // frmCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 358);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.cmdCargaArchivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.cmdCrearArchivo);
            this.Controls.Add(this.cmdUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarpetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpetas";
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
        private System.Windows.Forms.Button cmdCargaArchivo;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.TextBox txtRegistrar;
    }
}