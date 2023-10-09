namespace pryBarreiroIE
{
    partial class frmGrilla
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
            this.dgvMuestraGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestraGrilla
            // 
            this.dgvMuestraGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvMuestraGrilla.Name = "dgvMuestraGrilla";
            this.dgvMuestraGrilla.Size = new System.Drawing.Size(776, 426);
            this.dgvMuestraGrilla.TabIndex = 0;
            // 
            // frmGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMuestraGrilla);
            this.Name = "frmGrilla";
            this.Text = "Grilla";
            this.Load += new System.EventHandler(this.frmGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraGrilla;
    }
}