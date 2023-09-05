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
            this.VentanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdUbicacion = new System.Windows.Forms.Button();
            this.cmdCrearArchivo = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
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
            this.cmdCrearArchivo.Location = new System.Drawing.Point(12, 195);
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
            this.lblUbicacion.Location = new System.Drawing.Point(12, 85);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(148, 36);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNombre.Location = new System.Drawing.Point(12, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // frmCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 293);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.cmdCrearArchivo);
            this.Controls.Add(this.cmdUbicacion);
            this.Name = "frmCarpetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog VentanaCarpetas;
        private System.Windows.Forms.Button cmdUbicacion;
        private System.Windows.Forms.Button cmdCrearArchivo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}