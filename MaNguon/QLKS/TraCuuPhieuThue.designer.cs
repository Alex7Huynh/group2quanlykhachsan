namespace QLKS
{
    partial class frmTraCuuPhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuThue));
            this.txtMaPhieuThue = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.dtgDanhSachPhieuThue = new System.Windows.Forms.DataGridView();
            this.clMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhachHangDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenKhachDaiDien = new System.Windows.Forms.TextBox();
            this.dtmNgayBatDauThue = new System.Windows.Forms.DateTimePicker();
            this.nudSoNgayThue = new System.Windows.Forms.NumericUpDown();
            this.chbTimTheoNgay = new System.Windows.Forms.CheckBox();
            this.rdoAnd = new System.Windows.Forms.RadioButton();
            this.rdoOr = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.BackColor = System.Drawing.Color.Gray;
            this.txtMaPhieuThue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaPhieuThue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhieuThue.ForeColor = System.Drawing.Color.White;
            this.txtMaPhieuThue.Location = new System.Drawing.Point(48, 221);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(225, 23);
            this.txtMaPhieuThue.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.Gray;
            this.txtTenPhong.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.White;
            this.txtTenPhong.Location = new System.Drawing.Point(48, 361);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(225, 23);
            this.txtTenPhong.TabIndex = 2;
            // 
            // dtgDanhSachPhieuThue
            // 
            this.dtgDanhSachPhieuThue.BackgroundColor = System.Drawing.Color.Indigo;
            this.dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhieu,
            this.clMaPhong,
            this.clNgayThue,
            this.clSoNgayThue,
            this.clTenKhachHangDaiDien,
            this.clTinhTrang});
            this.dtgDanhSachPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgDanhSachPhieuThue.EnableHeadersVisualStyles = false;
            this.dtgDanhSachPhieuThue.GridColor = System.Drawing.Color.YellowGreen;
            this.dtgDanhSachPhieuThue.Location = new System.Drawing.Point(48, 416);
            this.dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            this.dtgDanhSachPhieuThue.RowHeadersVisible = false;
            this.dtgDanhSachPhieuThue.Size = new System.Drawing.Size(928, 304);
            this.dtgDanhSachPhieuThue.TabIndex = 100;
            this.dtgDanhSachPhieuThue.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgDanhSachPhieuThue_Paint);
            // 
            // clMaPhieu
            // 
            this.clMaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaPhieu.HeaderText = "Mã Phiếu Thuê";
            this.clMaPhieu.Name = "clMaPhieu";
            this.clMaPhieu.ReadOnly = true;
            // 
            // clMaPhong
            // 
            this.clMaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaPhong.HeaderText = "Mã Phòng";
            this.clMaPhong.Name = "clMaPhong";
            this.clMaPhong.ReadOnly = true;
            // 
            // clNgayThue
            // 
            this.clNgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayThue.HeaderText = "Ngày Thuê";
            this.clNgayThue.Name = "clNgayThue";
            this.clNgayThue.ReadOnly = true;
            // 
            // clSoNgayThue
            // 
            this.clSoNgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoNgayThue.HeaderText = "Số Ngày Thuê";
            this.clSoNgayThue.Name = "clSoNgayThue";
            this.clSoNgayThue.ReadOnly = true;
            // 
            // clTenKhachHangDaiDien
            // 
            this.clTenKhachHangDaiDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenKhachHangDaiDien.HeaderText = "Tên Khách Hàng Đại Diện";
            this.clTenKhachHangDaiDien.Name = "clTenKhachHangDaiDien";
            this.clTenKhachHangDaiDien.ReadOnly = true;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTinhTrang.HeaderText = "Tình Trạng";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTim.BackgroundImage = global::QLKS.Properties.Resources.ButtonSearch;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(775, 233);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(188, 47);
            this.btnTim.TabIndex = 10;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.MouseEnter += new System.EventHandler(this.btnTim_MouseEnter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonQuayLai;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(775, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 47);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnThoat_MouseEnter);
            // 
            // txtTenKhachDaiDien
            // 
            this.txtTenKhachDaiDien.BackColor = System.Drawing.Color.Gray;
            this.txtTenKhachDaiDien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTenKhachDaiDien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachDaiDien.ForeColor = System.Drawing.Color.White;
            this.txtTenKhachDaiDien.Location = new System.Drawing.Point(288, 361);
            this.txtTenKhachDaiDien.Name = "txtTenKhachDaiDien";
            this.txtTenKhachDaiDien.Size = new System.Drawing.Size(220, 23);
            this.txtTenKhachDaiDien.TabIndex = 3;
            // 
            // dtmNgayBatDauThue
            // 
            this.dtmNgayBatDauThue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtmNgayBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayBatDauThue.Location = new System.Drawing.Point(523, 265);
            this.dtmNgayBatDauThue.Name = "dtmNgayBatDauThue";
            this.dtmNgayBatDauThue.Size = new System.Drawing.Size(218, 23);
            this.dtmNgayBatDauThue.TabIndex = 8;
            // 
            // nudSoNgayThue
            // 
            this.nudSoNgayThue.BackColor = System.Drawing.Color.Gray;
            this.nudSoNgayThue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nudSoNgayThue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoNgayThue.ForeColor = System.Drawing.Color.White;
            this.nudSoNgayThue.Location = new System.Drawing.Point(523, 361);
            this.nudSoNgayThue.Name = "nudSoNgayThue";
            this.nudSoNgayThue.Size = new System.Drawing.Size(218, 23);
            this.nudSoNgayThue.TabIndex = 9;
            // 
            // chbTimTheoNgay
            // 
            this.chbTimTheoNgay.AutoSize = true;
            this.chbTimTheoNgay.BackColor = System.Drawing.Color.White;
            this.chbTimTheoNgay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbTimTheoNgay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chbTimTheoNgay.Location = new System.Drawing.Point(554, 188);
            this.chbTimTheoNgay.Name = "chbTimTheoNgay";
            this.chbTimTheoNgay.Size = new System.Drawing.Size(15, 14);
            this.chbTimTheoNgay.TabIndex = 6;
            this.chbTimTheoNgay.UseVisualStyleBackColor = false;
            this.chbTimTheoNgay.CheckedChanged += new System.EventHandler(this.chbTimTheoNgay_CheckedChanged);
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoAnd.Location = new System.Drawing.Point(352, 233);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(14, 13);
            this.rdoAnd.TabIndex = 4;
            this.rdoAnd.TabStop = true;
            this.rdoAnd.UseVisualStyleBackColor = true;
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoOr.Location = new System.Drawing.Point(352, 275);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(14, 13);
            this.rdoOr.TabIndex = 5;
            this.rdoOr.TabStop = true;
            this.rdoOr.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHTraCuuPhieuThue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.BackgroundImage = global::QLKS.Properties.Resources.ButtonMinimize;
            this.BT_ThuNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(870, 3);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(60, 36);
            this.BT_ThuNho.TabIndex = 106;
            this.BT_ThuNho.UseVisualStyleBackColor = false;
            this.BT_ThuNho.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.BT_ThuNho.Click += new System.EventHandler(this.BT_ThuNho_Click);
            this.BT_ThuNho.MouseEnter += new System.EventHandler(this.BT_ThuNho_MouseEnter);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.BackColor = System.Drawing.Color.DarkRed;
            this.BT_Thoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonExit;
            this.BT_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(940, 3);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(60, 36);
            this.BT_Thoat.TabIndex = 107;
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.MouseEnter += new System.EventHandler(this.BT_Thoat_MouseEnter);
            // 
            // frmTraCuuPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 790);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.chbTimTheoNgay);
            this.Controls.Add(this.rdoOr);
            this.Controls.Add(this.rdoAnd);
            this.Controls.Add(this.nudSoNgayThue);
            this.Controls.Add(this.txtMaPhieuThue);
            this.Controls.Add(this.dtmNgayBatDauThue);
            this.Controls.Add(this.txtTenKhachDaiDien);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.dtgDanhSachPhieuThue);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTraCuuPhieuThue";
            this.Text = "TraCuuPhieuThue";
            this.Load += new System.EventHandler(this.frmTraCuuPhieuThue_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraCuuPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhieuThue;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhieuThue;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenKhachDaiDien;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDauThue;
        private System.Windows.Forms.NumericUpDown nudSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhachHangDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.CheckBox chbTimTheoNgay;
        private System.Windows.Forms.RadioButton rdoAnd;
        private System.Windows.Forms.RadioButton rdoOr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
    }
}