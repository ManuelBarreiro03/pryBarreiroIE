namespace pryBarreiroIE
{
    partial class frmVentanas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanas));
            this.cmdSeguros = new System.Windows.Forms.Button();
            this.cmdUbicacionCarpeta = new System.Windows.Forms.Button();
            this.VentanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSeguros
            // 
            this.cmdSeguros.Location = new System.Drawing.Point(12, 12);
            this.cmdSeguros.Name = "cmdSeguros";
            this.cmdSeguros.Size = new System.Drawing.Size(179, 61);
            this.cmdSeguros.TabIndex = 0;
            this.cmdSeguros.Text = "Proveedores";
            this.cmdSeguros.UseVisualStyleBackColor = true;
            this.cmdSeguros.Click += new System.EventHandler(this.cmdSeguros_Click);
            // 
            // cmdUbicacionCarpeta
            // 
            this.cmdUbicacionCarpeta.Location = new System.Drawing.Point(12, 96);
            this.cmdUbicacionCarpeta.Name = "cmdUbicacionCarpeta";
            this.cmdUbicacionCarpeta.Size = new System.Drawing.Size(179, 61);
            this.cmdUbicacionCarpeta.TabIndex = 1;
            this.cmdUbicacionCarpeta.Text = "Archivos";
            this.cmdUbicacionCarpeta.UseVisualStyleBackColor = true;
            this.cmdUbicacionCarpeta.Click += new System.EventHandler(this.cmdUbicacionCarpeta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Carga Venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVentanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdUbicacionCarpeta);
            this.Controls.Add(this.cmdSeguros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventanas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSeguros;
        private System.Windows.Forms.Button cmdUbicacionCarpeta;
        private System.Windows.Forms.FolderBrowserDialog VentanaCarpetas;
        private System.Windows.Forms.Button button1;
    }
}