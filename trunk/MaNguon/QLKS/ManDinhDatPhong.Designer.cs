namespace QLKS
{
    partial class frmManDinhDatPhong
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
            this.ucDatPhong1 = new QLKS.UCDatPhong();
            this.SuspendLayout();
            // 
            // ucDatPhong1
            // 
            this.ucDatPhong1.Location = new System.Drawing.Point(29, 24);
            this.ucDatPhong1.Name = "ucDatPhong1";
            this.ucDatPhong1.Size = new System.Drawing.Size(1116, 536);
            this.ucDatPhong1.TabIndex = 0;
            // 
            // frmManDinhDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 574);
            this.Controls.Add(this.ucDatPhong1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManDinhDatPhong";
            this.Text = "ManDinhDatPhong";
            this.Load += new System.EventHandler(this.frmManDinhDatPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCDatPhong ucDatPhong1;
    }
}