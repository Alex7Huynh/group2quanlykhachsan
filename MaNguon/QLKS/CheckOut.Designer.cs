namespace QLKS
{
    partial class frmCheckOut
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
            this.txtCMND2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTraPhongDoan = new System.Windows.Forms.GroupBox();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.gbThanhTien = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbTraPhongDoan.SuspendLayout();
            this.gbThanhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMND2
            // 
            this.txtCMND2.Location = new System.Drawing.Point(240, 32);
            this.txtCMND2.Name = "txtCMND2";
            this.txtCMND2.Size = new System.Drawing.Size(162, 20);
            this.txtCMND2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "CMND/PassPort người đại diện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trả Phòng";
            // 
            // gbTraPhongDoan
            // 
            this.gbTraPhongDoan.Controls.Add(this.label5);
            this.gbTraPhongDoan.Controls.Add(this.txtCMND2);
            this.gbTraPhongDoan.Location = new System.Drawing.Point(58, 67);
            this.gbTraPhongDoan.Name = "gbTraPhongDoan";
            this.gbTraPhongDoan.Size = new System.Drawing.Size(408, 71);
            this.gbTraPhongDoan.TabIndex = 17;
            this.gbTraPhongDoan.TabStop = false;
            this.gbTraPhongDoan.Text = "Thông tin";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(113, 251);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTraPhong.TabIndex = 19;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // gbThanhTien
            // 
            this.gbThanhTien.Controls.Add(this.txtThanhTien);
            this.gbThanhTien.Location = new System.Drawing.Point(58, 156);
            this.gbThanhTien.Name = "gbThanhTien";
            this.gbThanhTien.Size = new System.Drawing.Size(408, 71);
            this.gbThanhTien.TabIndex = 18;
            this.gbThanhTien.TabStop = false;
            this.gbThanhTien.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(240, 32);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(162, 20);
            this.txtThanhTien.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(343, 251);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 290);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbThanhTien);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.gbTraPhongDoan);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.gbTraPhongDoan.ResumeLayout(false);
            this.gbTraPhongDoan.PerformLayout();
            this.gbThanhTien.ResumeLayout(false);
            this.gbThanhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTraPhongDoan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.GroupBox gbThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnThoat;
    }
}