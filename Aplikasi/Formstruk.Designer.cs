namespace Aplikasi
{
    partial class Formstruk
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
            this.ppcStruk = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // ppcStruk
            // 
            this.ppcStruk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppcStruk.Location = new System.Drawing.Point(0, 0);
            this.ppcStruk.Name = "ppcStruk";
            this.ppcStruk.Size = new System.Drawing.Size(453, 494);
            this.ppcStruk.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Formstruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 494);
            this.Controls.Add(this.ppcStruk);
            this.Name = "Formstruk";
            this.Text = "Formstruk";
            this.Load += new System.EventHandler(this.Formstruk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl ppcStruk;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}