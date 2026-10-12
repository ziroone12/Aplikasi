namespace Aplikasi
{
    partial class dashkasir
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
            this.dgvRiwayatPasokan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatPasokan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRiwayatPasokan
            // 
            this.dgvRiwayatPasokan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayatPasokan.Location = new System.Drawing.Point(23, 257);
            this.dgvRiwayatPasokan.Name = "dgvRiwayatPasokan";
            this.dgvRiwayatPasokan.RowHeadersWidth = 62;
            this.dgvRiwayatPasokan.RowTemplate.Height = 28;
            this.dgvRiwayatPasokan.Size = new System.Drawing.Size(1665, 490);
            this.dgvRiwayatPasokan.TabIndex = 0;
            // 
            // dashkasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 783);
            this.Controls.Add(this.dgvRiwayatPasokan);
            this.Name = "dashkasir";
            this.Text = "dashkasir";
            this.Load += new System.EventHandler(this.dashkasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatPasokan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiwayatPasokan;
    }
}