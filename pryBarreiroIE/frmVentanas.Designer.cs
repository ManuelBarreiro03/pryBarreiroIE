﻿namespace pryBarreiroIE
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
            this.cmdSeguros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSeguros
            // 
            this.cmdSeguros.Location = new System.Drawing.Point(245, 229);
            this.cmdSeguros.Name = "cmdSeguros";
            this.cmdSeguros.Size = new System.Drawing.Size(164, 85);
            this.cmdSeguros.TabIndex = 0;
            this.cmdSeguros.Text = "Seguros";
            this.cmdSeguros.UseVisualStyleBackColor = true;
            this.cmdSeguros.Click += new System.EventHandler(this.cmdSeguros_Click);
            // 
            // frmVentanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 390);
            this.Controls.Add(this.cmdSeguros);
            this.Name = "frmVentanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventanas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSeguros;
    }
}