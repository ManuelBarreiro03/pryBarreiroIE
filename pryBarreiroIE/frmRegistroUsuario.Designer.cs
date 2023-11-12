namespace pryBarreiroIE
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblContrasenaConfirmar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContarsena = new System.Windows.Forms.TextBox();
            this.txtContarsenaConfirmar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(15, 115);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(95, 28);
            this.cmdRegistrar.TabIndex = 0;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(232, 115);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 28);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            this.cmdCancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdCancelar_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblContrasena.Location = new System.Drawing.Point(12, 44);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 17);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblContrasenaConfirmar
            // 
            this.lblContrasenaConfirmar.AutoSize = true;
            this.lblContrasenaConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblContrasenaConfirmar.Location = new System.Drawing.Point(12, 79);
            this.lblContrasenaConfirmar.Name = "lblContrasenaConfirmar";
            this.lblContrasenaConfirmar.Size = new System.Drawing.Size(146, 17);
            this.lblContrasenaConfirmar.TabIndex = 4;
            this.lblContrasenaConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(173, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContarsena
            // 
            this.txtContarsena.Location = new System.Drawing.Point(173, 41);
            this.txtContarsena.Name = "txtContarsena";
            this.txtContarsena.Size = new System.Drawing.Size(154, 20);
            this.txtContarsena.TabIndex = 6;
            this.txtContarsena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContarsena_KeyPress);
            // 
            // txtContarsenaConfirmar
            // 
            this.txtContarsenaConfirmar.Location = new System.Drawing.Point(173, 76);
            this.txtContarsenaConfirmar.Name = "txtContarsenaConfirmar";
            this.txtContarsenaConfirmar.Size = new System.Drawing.Size(154, 20);
            this.txtContarsenaConfirmar.TabIndex = 7;
            this.txtContarsenaConfirmar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContarsenaConfirmar_KeyPress);
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 152);
            this.Controls.Add(this.txtContarsenaConfirmar);
            this.Controls.Add(this.txtContarsena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasenaConfirmar);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblContrasenaConfirmar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContarsena;
        private System.Windows.Forms.TextBox txtContarsenaConfirmar;
    }
}