namespace pryBarreiroIE
{
    partial class frmCargaVentas
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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblNumeroExpe = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLiquiResp = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtNumeroExpe = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLiquiResp = new System.Windows.Forms.TextBox();
            this.cmdAlta = new System.Windows.Forms.Button();
            this.cmdBaja = new System.Windows.Forms.Button();
            this.cmdModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVolver.Location = new System.Drawing.Point(453, 311);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(134, 51);
            this.cmdVolver.TabIndex = 0;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(24, 18);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Nº";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(12, 55);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(57, 18);
            this.lblEntidad.TabIndex = 2;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(12, 101);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(63, 18);
            this.lblApertura.TabIndex = 3;
            this.lblApertura.Text = "Apertura";
            // 
            // lblNumeroExpe
            // 
            this.lblNumeroExpe.AutoSize = true;
            this.lblNumeroExpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroExpe.Location = new System.Drawing.Point(12, 147);
            this.lblNumeroExpe.Name = "lblNumeroExpe";
            this.lblNumeroExpe.Size = new System.Drawing.Size(119, 18);
            this.lblNumeroExpe.TabIndex = 4;
            this.lblNumeroExpe.Text = "Nª de expediente";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzgado.Location = new System.Drawing.Point(12, 193);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(65, 18);
            this.lblJuzgado.TabIndex = 5;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisdiccion.Location = new System.Drawing.Point(12, 239);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(87, 18);
            this.lblJurisdiccion.TabIndex = 6;
            this.lblJurisdiccion.Text = "Jurisdicción";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 285);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 18);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblLiquiResp
            // 
            this.lblLiquiResp.AutoSize = true;
            this.lblLiquiResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquiResp.Location = new System.Drawing.Point(12, 331);
            this.lblLiquiResp.Name = "lblLiquiResp";
            this.lblLiquiResp.Size = new System.Drawing.Size(161, 18);
            this.lblLiquiResp.TabIndex = 8;
            this.lblLiquiResp.Text = "Liquidador responsable";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(179, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(232, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(179, 105);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(232, 20);
            this.txtApertura.TabIndex = 10;
            // 
            // txtNumeroExpe
            // 
            this.txtNumeroExpe.Location = new System.Drawing.Point(179, 151);
            this.txtNumeroExpe.Name = "txtNumeroExpe";
            this.txtNumeroExpe.Size = new System.Drawing.Size(232, 20);
            this.txtNumeroExpe.TabIndex = 11;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(179, 59);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(232, 20);
            this.txtEntidad.TabIndex = 12;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(179, 197);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(232, 20);
            this.txtJuzgado.TabIndex = 13;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(179, 239);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(232, 20);
            this.txtJurisdiccion.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 285);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(232, 20);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtLiquiResp
            // 
            this.txtLiquiResp.Location = new System.Drawing.Point(179, 331);
            this.txtLiquiResp.Name = "txtLiquiResp";
            this.txtLiquiResp.Size = new System.Drawing.Size(232, 20);
            this.txtLiquiResp.TabIndex = 16;
            // 
            // cmdAlta
            // 
            this.cmdAlta.Location = new System.Drawing.Point(453, 20);
            this.cmdAlta.Name = "cmdAlta";
            this.cmdAlta.Size = new System.Drawing.Size(134, 51);
            this.cmdAlta.TabIndex = 17;
            this.cmdAlta.Text = "Alta";
            this.cmdAlta.UseVisualStyleBackColor = true;
            // 
            // cmdBaja
            // 
            this.cmdBaja.Location = new System.Drawing.Point(453, 214);
            this.cmdBaja.Name = "cmdBaja";
            this.cmdBaja.Size = new System.Drawing.Size(134, 51);
            this.cmdBaja.TabIndex = 18;
            this.cmdBaja.Text = "Baja";
            this.cmdBaja.UseVisualStyleBackColor = true;
            // 
            // cmdModificacion
            // 
            this.cmdModificacion.Location = new System.Drawing.Point(453, 117);
            this.cmdModificacion.Name = "cmdModificacion";
            this.cmdModificacion.Size = new System.Drawing.Size(134, 51);
            this.cmdModificacion.TabIndex = 19;
            this.cmdModificacion.Text = "Modificación";
            this.cmdModificacion.UseVisualStyleBackColor = true;
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 376);
            this.Controls.Add(this.cmdModificacion);
            this.Controls.Add(this.cmdBaja);
            this.Controls.Add(this.cmdAlta);
            this.Controls.Add(this.txtLiquiResp);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtJurisdiccion);
            this.Controls.Add(this.txtJuzgado);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtNumeroExpe);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblLiquiResp);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblJurisdiccion);
            this.Controls.Add(this.lblJuzgado);
            this.Controls.Add(this.lblNumeroExpe);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.lblEntidad);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cmdVolver);
            this.Name = "frmCargaVentas";
            this.Text = "frmCargaVentas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblNumeroExpe;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLiquiResp;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtNumeroExpe;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtJuzgado;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLiquiResp;
        private System.Windows.Forms.Button cmdAlta;
        private System.Windows.Forms.Button cmdBaja;
        private System.Windows.Forms.Button cmdModificacion;
    }
}