namespace QLKS
{
    partial class MainMenu
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
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnTraCuuPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnTraCuuPhieuThue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(36, 51);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(108, 45);
            this.btnThemPhong.TabIndex = 1;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnTraCuuPhong
            // 
            this.btnTraCuuPhong.Location = new System.Drawing.Point(46, 51);
            this.btnTraCuuPhong.Name = "btnTraCuuPhong";
            this.btnTraCuuPhong.Size = new System.Drawing.Size(108, 45);
            this.btnTraCuuPhong.TabIndex = 2;
            this.btnTraCuuPhong.Text = "Tra Cứu Phòng";
            this.btnTraCuuPhong.UseVisualStyleBackColor = true;
            this.btnTraCuuPhong.Click += new System.EventHandler(this.btnTraCuuPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(48, 150);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(108, 45);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(51, 150);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(108, 45);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo Cáo Doanh Thu";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(36, 251);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(108, 45);
            this.btnSuaPhong.TabIndex = 5;
            this.btnSuaPhong.Text = "Sửa Phòng";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(36, 150);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(108, 45);
            this.btnXoaPhong.TabIndex = 6;
            this.btnXoaPhong.Text = "Xóa Phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnTraCuuPhieuThue
            // 
            this.btnTraCuuPhieuThue.Location = new System.Drawing.Point(46, 150);
            this.btnTraCuuPhieuThue.Name = "btnTraCuuPhieuThue";
            this.btnTraCuuPhieuThue.Size = new System.Drawing.Size(108, 45);
            this.btnTraCuuPhieuThue.TabIndex = 7;
            this.btnTraCuuPhieuThue.Text = "Tra Cứu Phiếu Thuê";
            this.btnTraCuuPhieuThue.UseVisualStyleBackColor = true;
            this.btnTraCuuPhieuThue.Click += new System.EventHandler(this.btnTraCuuPhieuThue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaPhong);
            this.groupBox1.Controls.Add(this.btnThemPhong);
            this.groupBox1.Controls.Add(this.btnSuaPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(27, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 322);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Phòng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTraCuuPhong);
            this.groupBox2.Controls.Add(this.btnTraCuuPhieuThue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(256, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 322);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Cứu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDatPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(495, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 322);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt Phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBaoCao);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(736, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 322);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Báo Cáo";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(437, 429);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 474);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Quản Lý Khách Sạn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnTraCuuPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnTraCuuPhieuThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThoat;
    }
}