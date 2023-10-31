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
            this.cmdCargaABM = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSeguros
            // 
            this.cmdSeguros.Location = new System.Drawing.Point(12, 12);
            this.cmdSeguros.Name = "cmdSeguros";
            this.cmdSeguros.Size = new System.Drawing.Size(179, 61);
            this.cmdSeguros.TabIndex = 0;
            this.cmdSeguros.Text = "Muestra Archivos";
            this.cmdSeguros.UseVisualStyleBackColor = true;
            this.cmdSeguros.Click += new System.EventHandler(this.cmdSeguros_Click);
            // 
            // cmdUbicacionCarpeta
            // 
            this.cmdUbicacionCarpeta.Location = new System.Drawing.Point(12, 90);
            this.cmdUbicacionCarpeta.Name = "cmdUbicacionCarpeta";
            this.cmdUbicacionCarpeta.Size = new System.Drawing.Size(179, 61);
            this.cmdUbicacionCarpeta.TabIndex = 1;
            this.cmdUbicacionCarpeta.Text = "Creacion de archivos";
            this.cmdUbicacionCarpeta.UseVisualStyleBackColor = true;
            this.cmdUbicacionCarpeta.Click += new System.EventHandler(this.cmdUbicacionCarpeta_Click);
            // 
            // cmdCargaABM
            // 
            this.cmdCargaABM.Location = new System.Drawing.Point(197, 12);
            this.cmdCargaABM.Name = "cmdCargaABM";
            this.cmdCargaABM.Size = new System.Drawing.Size(179, 61);
            this.cmdCargaABM.TabIndex = 2;
            this.cmdCargaABM.Text = "Carga ABM ";
            this.cmdCargaABM.UseVisualStyleBackColor = true;
            this.cmdCargaABM.Click += new System.EventHandler(this.cmdCargaABM_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(197, 90);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(179, 61);
            this.cmdLogin.TabIndex = 3;
            this.cmdLogin.Text = "Base de Datos";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdBaseDatos_Click);
            // 
            // cmdRegistros
            // 
            this.cmdRegistros.Location = new System.Drawing.Point(108, 157);
            this.cmdRegistros.Name = "cmdRegistros";
            this.cmdRegistros.Size = new System.Drawing.Size(179, 61);
            this.cmdRegistros.TabIndex = 4;
            this.cmdRegistros.Text = "Registros/Logs";
            this.cmdRegistros.UseVisualStyleBackColor = true;
            this.cmdRegistros.Click += new System.EventHandler(this.cmdRegistros_Click);
            // 
            // frmVentanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.cmdRegistros);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdCargaABM);
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
        private System.Windows.Forms.Button cmdCargaABM;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdRegistros;
    }
}