namespace Aplikasi
{
    partial class FormPaymentTransfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelesaiTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMOR REKENING TOKO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEABANK : 9010 1241 5444";
            // 
            // btnSelesaiTransfer
            // 
            this.btnSelesaiTransfer.Location = new System.Drawing.Point(76, 169);
            this.btnSelesaiTransfer.Name = "btnSelesaiTransfer";
            this.btnSelesaiTransfer.Size = new System.Drawing.Size(136, 31);
            this.btnSelesaiTransfer.TabIndex = 2;
            this.btnSelesaiTransfer.Text = "Konfirmasi Pembayaran";
            this.btnSelesaiTransfer.UseVisualStyleBackColor = true;
            this.btnSelesaiTransfer.Click += new System.EventHandler(this.btnSelesaiTransfer_Click);
            // 
            // FormPaymentTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 253);
            this.Controls.Add(this.btnSelesaiTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPaymentTransfer";
            this.Text = "FormPaymentTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelesaiTransfer;
    }
}