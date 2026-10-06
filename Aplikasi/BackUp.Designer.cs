namespace Aplikasi
{
    partial class BackUp
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnKembaliDashboard = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1041, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // btnKembaliDashboard
            // 
            this.btnKembaliDashboard.Location = new System.Drawing.Point(57, 85);
            this.btnKembaliDashboard.Name = "btnKembaliDashboard";
            this.btnKembaliDashboard.Size = new System.Drawing.Size(138, 46);
            this.btnKembaliDashboard.TabIndex = 25;
            this.btnKembaliDashboard.Text = "Dashboard";
            this.btnKembaliDashboard.UseVisualStyleBackColor = true;
            this.btnKembaliDashboard.Click += new System.EventHandler(this.btnKembaliDashboard_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(632, 280);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(356, 115);
            this.btnRestore.TabIndex = 24;
            this.btnRestore.Text = "Restone";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(234, 280);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(357, 115);
            this.btnBackup.TabIndex = 23;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Aksi Pengamanan File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(224, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 54);
            this.label1.TabIndex = 21;
            this.label1.Text = "BACK UP DAN RESTONE DATA SYSTEM";
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 569);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKembaliDashboard);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BackUp";
            this.Text = "BackUp";
            this.Load += new System.EventHandler(this.BackUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKembaliDashboard;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}