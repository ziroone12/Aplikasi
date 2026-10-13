namespace Aplikasi
{
    partial class dashadmin
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
            this.dgvRiwayatSistem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatSistem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRiwayatSistem
            // 
            this.dgvRiwayatSistem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayatSistem.Location = new System.Drawing.Point(38, 238);
            this.dgvRiwayatSistem.Name = "dgvRiwayatSistem";
            this.dgvRiwayatSistem.RowHeadersWidth = 62;
            this.dgvRiwayatSistem.RowTemplate.Height = 28;
            this.dgvRiwayatSistem.Size = new System.Drawing.Size(1669, 504);
            this.dgvRiwayatSistem.TabIndex = 0;
            // 
            // dashadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 780);
            this.Controls.Add(this.dgvRiwayatSistem);
            this.Name = "dashadmin";
            this.Text = "dashadmin";
            this.Load += new System.EventHandler(this.FormLogAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatSistem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiwayatSistem;
    }
}