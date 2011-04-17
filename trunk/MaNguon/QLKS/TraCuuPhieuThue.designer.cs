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
            this.lblMaPhieuThue = new System.Windows.Forms.Label();
            this.lblTenKhachDaiDien = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
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
            this.lblTraCuuPhieuThue = new System.Windows.Forms.Label();
            this.txtTenKhachDaiDien = new System.Windows.Forms.TextBox();
            this.dtmNgayBatDauThue = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDauThue = new System.Windows.Forms.Label();
            this.nudSoNgayThue = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgayThue = new System.Windows.Forms.Label();
            this.chbTimTheoNgay = new System.Windows.Forms.CheckBox();
            this.grbTimTheoNgay = new System.Windows.Forms.GroupBox();
            this.rdoAnd = new System.Windows.Forms.RadioButton();
            this.rdoOr = new System.Windows.Forms.RadioButton();
            this.grpKieuTimKiem = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayThue)).BeginInit();
            this.grbTimTheoNgay.SuspendLayout();
            this.grpKieuTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaPhieuThue
            // 
            this.lblMaPhieuThue.AutoSize = true;
            this.lblMaPhieuThue.Location = new System.Drawing.Point(343, 146);
            this.lblMaPhieuThue.Name = "lblMaPhieuThue";
            this.lblMaPhieuThue.Size = new System.Drawing.Size(75, 13);
            this.lblMaPhieuThue.TabIndex = 0;
            this.lblMaPhieuThue.Text = "Mã phiếu thuê";
            // 
            // lblTenKhachDaiDien
            // 
            this.lblTenKhachDaiDien.AutoSize = true;
            this.lblTenKhachDaiDien.Location = new System.Drawing.Point(343, 235);
            this.lblTenKhachDaiDien.Name = "lblTenKhachDaiDien";
            this.lblTenKhachDaiDien.Size = new System.Drawing.Size(104, 13);
            this.lblTenKhachDaiDien.TabIndex = 2;
            this.lblTenKhachDaiDien.Text = "Tên Khách Đại Diện";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(343, 192);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(59, 13);
            this.lblTenPhong.TabIndex = 3;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.Location = new System.Drawing.Point(469, 143);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(155, 20);
            this.txtMaPhieuThue.TabIndex = 4;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(469, 192);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(155, 20);
            this.txtTenPhong.TabIndex = 7;
            // 
            // dtgDanhSachPhieuThue
            // 
            this.dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhieu,
            this.clMaPhong,
            this.clNgayThue,
            this.clSoNgayThue,
            this.clTenKhachHangDaiDien,
            this.clTinhTrang});
            this.dtgDanhSachPhieuThue.Location = new System.Drawing.Point(20, 281);
            this.dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            this.dtgDanhSachPhieuThue.RowHeadersVisible = false;
            this.dtgDanhSachPhieuThue.Size = new System.Drawing.Size(604, 233);
            this.dtgDanhSachPhieuThue.TabIndex = 8;
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
            this.btnTim.Location = new System.Drawing.Point(61, 520);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 36);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(501, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 36);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTraCuuPhieuThue
            // 
            this.lblTraCuuPhieuThue.AutoSize = true;
            this.lblTraCuuPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraCuuPhieuThue.ForeColor = System.Drawing.Color.Blue;
            this.lblTraCuuPhieuThue.Location = new System.Drawing.Point(206, 14);
            this.lblTraCuuPhieuThue.Name = "lblTraCuuPhieuThue";
            this.lblTraCuuPhieuThue.Size = new System.Drawing.Size(205, 26);
            this.lblTraCuuPhieuThue.TabIndex = 14;
            this.lblTraCuuPhieuThue.Text = "Tra Cứu Phiếu Thuê";
            // 
            // txtTenKhachDaiDien
            // 
            this.txtTenKhachDaiDien.Location = new System.Drawing.Point(469, 232);
            this.txtTenKhachDaiDien.Name = "txtTenKhachDaiDien";
            this.txtTenKhachDaiDien.Size = new System.Drawing.Size(155, 20);
            this.txtTenKhachDaiDien.TabIndex = 15;
            // 
            // dtmNgayBatDauThue
            // 
            this.dtmNgayBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayBatDauThue.Location = new System.Drawing.Point(115, 40);
            this.dtmNgayBatDauThue.Name = "dtmNgayBatDauThue";
            this.dtmNgayBatDauThue.Size = new System.Drawing.Size(155, 20);
            this.dtmNgayBatDauThue.TabIndex = 16;
            // 
            // lblNgayBatDauThue
            // 
            this.lblNgayBatDauThue.AutoSize = true;
            this.lblNgayBatDauThue.Location = new System.Drawing.Point(7, 46);
            this.lblNgayBatDauThue.Name = "lblNgayBatDauThue";
            this.lblNgayBatDauThue.Size = new System.Drawing.Size(102, 13);
            this.lblNgayBatDauThue.TabIndex = 17;
            this.lblNgayBatDauThue.Text = "Ngày Bắt Đầu Thuê";
            // 
            // nudSoNgayThue
            // 
            this.nudSoNgayThue.Location = new System.Drawing.Point(115, 80);
            this.nudSoNgayThue.Name = "nudSoNgayThue";
            this.nudSoNgayThue.Size = new System.Drawing.Size(155, 20);
            this.nudSoNgayThue.TabIndex = 18;
            // 
            // lblSoNgayThue
            // 
            this.lblSoNgayThue.AutoSize = true;
            this.lblSoNgayThue.Location = new System.Drawing.Point(7, 82);
            this.lblSoNgayThue.Name = "lblSoNgayThue";
            this.lblSoNgayThue.Size = new System.Drawing.Size(76, 13);
            this.lblSoNgayThue.TabIndex = 19;
            this.lblSoNgayThue.Text = "Số Ngày Thuê";
            // 
            // chbTimTheoNgay
            // 
            this.chbTimTheoNgay.AutoSize = true;
            this.chbTimTheoNgay.Location = new System.Drawing.Point(20, 119);
            this.chbTimTheoNgay.Name = "chbTimTheoNgay";
            this.chbTimTheoNgay.Size = new System.Drawing.Size(99, 17);
            this.chbTimTheoNgay.TabIndex = 20;
            this.chbTimTheoNgay.Text = "Tìm Theo Ngày";
            this.chbTimTheoNgay.UseVisualStyleBackColor = true;
            this.chbTimTheoNgay.CheckedChanged += new System.EventHandler(this.chbTimTheoNgay_CheckedChanged);
            // 
            // grbTimTheoNgay
            // 
            this.grbTimTheoNgay.Controls.Add(this.lblSoNgayThue);
            this.grbTimTheoNgay.Controls.Add(this.lblNgayBatDauThue);
            this.grbTimTheoNgay.Controls.Add(this.nudSoNgayThue);
            this.grbTimTheoNgay.Controls.Add(this.dtmNgayBatDauThue);
            this.grbTimTheoNgay.Location = new System.Drawing.Point(20, 153);
            this.grbTimTheoNgay.Name = "grbTimTheoNgay";
            this.grbTimTheoNgay.Size = new System.Drawing.Size(276, 113);
            this.grbTimTheoNgay.TabIndex = 21;
            this.grbTimTheoNgay.TabStop = false;
            this.grbTimTheoNgay.Text = "Tìm Theo Ngày";
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Location = new System.Drawing.Point(6, 19);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(44, 17);
            this.rdoAnd.TabIndex = 22;
            this.rdoAnd.TabStop = true;
            this.rdoAnd.Text = "And";
            this.rdoAnd.UseVisualStyleBackColor = true;
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Location = new System.Drawing.Point(6, 42);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(36, 17);
            this.rdoOr.TabIndex = 23;
            this.rdoOr.TabStop = true;
            this.rdoOr.Text = "Or";
            this.rdoOr.UseVisualStyleBackColor = true;
            // 
            // grpKieuTimKiem
            // 
            this.grpKieuTimKiem.Controls.Add(this.rdoAnd);
            this.grpKieuTimKiem.Controls.Add(this.rdoOr);
            this.grpKieuTimKiem.Location = new System.Drawing.Point(30, 32);
            this.grpKieuTimKiem.Name = "grpKieuTimKiem";
            this.grpKieuTimKiem.Size = new System.Drawing.Size(114, 69);
            this.grpKieuTimKiem.TabIndex = 24;
            this.grpKieuTimKiem.TabStop = false;
            this.grpKieuTimKiem.Text = "Kiểu Tìm Kiếm";
            // 
            // frmTraCuuPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 568);
            this.Controls.Add(this.grpKieuTimKiem);
            this.Controls.Add(this.chbTimTheoNgay);
            this.Controls.Add(this.grbTimTheoNgay);
            this.Controls.Add(this.txtTenKhachDaiDien);
            this.Controls.Add(this.lblTraCuuPhieuThue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgDanhSachPhieuThue);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhieuThue);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblTenKhachDaiDien);
            this.Controls.Add(this.lblMaPhieuThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTraCuuPhieuThue";
            this.Text = "TraCuuPhieuThue";
            this.Load += new System.EventHandler(this.frmTraCuuPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayThue)).EndInit();
            this.grbTimTheoNgay.ResumeLayout(false);
            this.grbTimTheoNgay.PerformLayout();
            this.grpKieuTimKiem.ResumeLayout(false);
            this.grpKieuTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaPhieuThue;
        private System.Windows.Forms.Label lblTenKhachDaiDien;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhieuThue;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhieuThue;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTraCuuPhieuThue;
        private System.Windows.Forms.TextBox txtTenKhachDaiDien;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDauThue;
        private System.Windows.Forms.Label lblNgayBatDauThue;
        private System.Windows.Forms.NumericUpDown nudSoNgayThue;
        private System.Windows.Forms.Label lblSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhachHangDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.CheckBox chbTimTheoNgay;
        private System.Windows.Forms.GroupBox grbTimTheoNgay;
        private System.Windows.Forms.RadioButton rdoAnd;
        private System.Windows.Forms.RadioButton rdoOr;
        private System.Windows.Forms.GroupBox grpKieuTimKiem;
    }
}