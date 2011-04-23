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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayThue)).BeginInit();
            this.grbTimTheoNgay.SuspendLayout();
            this.grpKieuTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaPhieuThue
            // 
            this.lblMaPhieuThue.AutoSize = true;
            this.lblMaPhieuThue.BackColor = System.Drawing.Color.Black;
            this.lblMaPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieuThue.ForeColor = System.Drawing.Color.Gold;
            this.lblMaPhieuThue.Location = new System.Drawing.Point(369, 188);
            this.lblMaPhieuThue.Name = "lblMaPhieuThue";
            this.lblMaPhieuThue.Size = new System.Drawing.Size(111, 17);
            this.lblMaPhieuThue.TabIndex = 0;
            this.lblMaPhieuThue.Text = "Mã phiếu thuê";
            // 
            // lblTenKhachDaiDien
            // 
            this.lblTenKhachDaiDien.AutoSize = true;
            this.lblTenKhachDaiDien.BackColor = System.Drawing.Color.Black;
            this.lblTenKhachDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhachDaiDien.ForeColor = System.Drawing.Color.Gold;
            this.lblTenKhachDaiDien.Location = new System.Drawing.Point(369, 308);
            this.lblTenKhachDaiDien.Name = "lblTenKhachDaiDien";
            this.lblTenKhachDaiDien.Size = new System.Drawing.Size(153, 17);
            this.lblTenKhachDaiDien.TabIndex = 2;
            this.lblTenKhachDaiDien.Text = "Tên Khách Đại Diện";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.BackColor = System.Drawing.Color.Black;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.Gold;
            this.lblTenPhong.Location = new System.Drawing.Point(369, 248);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(86, 17);
            this.lblTenPhong.TabIndex = 3;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.BackColor = System.Drawing.Color.OliveDrab;
            this.txtMaPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhieuThue.ForeColor = System.Drawing.Color.White;
            this.txtMaPhieuThue.Location = new System.Drawing.Point(558, 185);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(284, 23);
            this.txtMaPhieuThue.TabIndex = 1;
            this.txtMaPhieuThue.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtMaPhieuThue.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.White;
            this.txtTenPhong.Location = new System.Drawing.Point(558, 245);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(284, 23);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtTenPhong.Enter += new System.EventHandler(this.txtMaPhong_Enter);
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
            this.dtgDanhSachPhieuThue.Location = new System.Drawing.Point(333, 363);
            this.dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            this.dtgDanhSachPhieuThue.RowHeadersVisible = false;
            this.dtgDanhSachPhieuThue.Size = new System.Drawing.Size(772, 375);
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
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(935, 188);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 52);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnTim.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(935, 273);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnThoat.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // txtTenKhachDaiDien
            // 
            this.txtTenKhachDaiDien.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTenKhachDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachDaiDien.ForeColor = System.Drawing.Color.White;
            this.txtTenKhachDaiDien.Location = new System.Drawing.Point(558, 305);
            this.txtTenKhachDaiDien.Name = "txtTenKhachDaiDien";
            this.txtTenKhachDaiDien.Size = new System.Drawing.Size(284, 23);
            this.txtTenKhachDaiDien.TabIndex = 3;
            this.txtTenKhachDaiDien.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtTenKhachDaiDien.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // dtmNgayBatDauThue
            // 
            this.dtmNgayBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayBatDauThue.Location = new System.Drawing.Point(10, 76);
            this.dtmNgayBatDauThue.Name = "dtmNgayBatDauThue";
            this.dtmNgayBatDauThue.Size = new System.Drawing.Size(260, 23);
            this.dtmNgayBatDauThue.TabIndex = 8;
            // 
            // lblNgayBatDauThue
            // 
            this.lblNgayBatDauThue.AutoSize = true;
            this.lblNgayBatDauThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayBatDauThue.Location = new System.Drawing.Point(7, 46);
            this.lblNgayBatDauThue.Name = "lblNgayBatDauThue";
            this.lblNgayBatDauThue.Size = new System.Drawing.Size(150, 17);
            this.lblNgayBatDauThue.TabIndex = 17;
            this.lblNgayBatDauThue.Text = "Ngày Bắt Đầu Thuê";
            // 
            // nudSoNgayThue
            // 
            this.nudSoNgayThue.BackColor = System.Drawing.Color.OliveDrab;
            this.nudSoNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoNgayThue.ForeColor = System.Drawing.Color.White;
            this.nudSoNgayThue.Location = new System.Drawing.Point(10, 166);
            this.nudSoNgayThue.Name = "nudSoNgayThue";
            this.nudSoNgayThue.Size = new System.Drawing.Size(260, 23);
            this.nudSoNgayThue.TabIndex = 9;
            this.nudSoNgayThue.Leave += new System.EventHandler(this.nudSoNgayThue_Leave);
            this.nudSoNgayThue.Enter += new System.EventHandler(this.nudSoNgayThue_Enter);
            // 
            // lblSoNgayThue
            // 
            this.lblSoNgayThue.AutoSize = true;
            this.lblSoNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoNgayThue.Location = new System.Drawing.Point(7, 135);
            this.lblSoNgayThue.Name = "lblSoNgayThue";
            this.lblSoNgayThue.Size = new System.Drawing.Size(111, 17);
            this.lblSoNgayThue.TabIndex = 19;
            this.lblSoNgayThue.Text = "Số Ngày Thuê";
            // 
            // chbTimTheoNgay
            // 
            this.chbTimTheoNgay.AutoSize = true;
            this.chbTimTheoNgay.BackColor = System.Drawing.Color.Black;
            this.chbTimTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbTimTheoNgay.ForeColor = System.Drawing.Color.White;
            this.chbTimTheoNgay.Location = new System.Drawing.Point(30, 346);
            this.chbTimTheoNgay.Name = "chbTimTheoNgay";
            this.chbTimTheoNgay.Size = new System.Drawing.Size(137, 21);
            this.chbTimTheoNgay.TabIndex = 6;
            this.chbTimTheoNgay.Text = "Tìm Theo Ngày";
            this.chbTimTheoNgay.UseVisualStyleBackColor = false;
            this.chbTimTheoNgay.CheckedChanged += new System.EventHandler(this.chbTimTheoNgay_CheckedChanged);
            // 
            // grbTimTheoNgay
            // 
            this.grbTimTheoNgay.BackColor = System.Drawing.Color.Brown;
            this.grbTimTheoNgay.Controls.Add(this.lblSoNgayThue);
            this.grbTimTheoNgay.Controls.Add(this.lblNgayBatDauThue);
            this.grbTimTheoNgay.Controls.Add(this.nudSoNgayThue);
            this.grbTimTheoNgay.Controls.Add(this.dtmNgayBatDauThue);
            this.grbTimTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTimTheoNgay.ForeColor = System.Drawing.Color.White;
            this.grbTimTheoNgay.Location = new System.Drawing.Point(30, 397);
            this.grbTimTheoNgay.Name = "grbTimTheoNgay";
            this.grbTimTheoNgay.Size = new System.Drawing.Size(282, 245);
            this.grbTimTheoNgay.TabIndex = 7;
            this.grbTimTheoNgay.TabStop = false;
            this.grbTimTheoNgay.Text = "Tìm Theo Ngày";
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoAnd.Location = new System.Drawing.Point(6, 19);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(54, 21);
            this.rdoAnd.TabIndex = 4;
            this.rdoAnd.TabStop = true;
            this.rdoAnd.Text = "And";
            this.rdoAnd.UseVisualStyleBackColor = true;
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoOr.Location = new System.Drawing.Point(6, 42);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(44, 21);
            this.rdoOr.TabIndex = 5;
            this.rdoOr.TabStop = true;
            this.rdoOr.Text = "Or";
            this.rdoOr.UseVisualStyleBackColor = true;
            // 
            // grpKieuTimKiem
            // 
            this.grpKieuTimKiem.BackColor = System.Drawing.Color.Brown;
            this.grpKieuTimKiem.Controls.Add(this.rdoAnd);
            this.grpKieuTimKiem.Controls.Add(this.rdoOr);
            this.grpKieuTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpKieuTimKiem.ForeColor = System.Drawing.Color.White;
            this.grpKieuTimKiem.Location = new System.Drawing.Point(30, 188);
            this.grpKieuTimKiem.Name = "grpKieuTimKiem";
            this.grpKieuTimKiem.Size = new System.Drawing.Size(157, 88);
            this.grpKieuTimKiem.TabIndex = 4;
            this.grpKieuTimKiem.TabStop = false;
            this.grpKieuTimKiem.Text = "Kiểu Tìm Kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHTCPhieuThue;
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 720);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(919, 5);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(84, 44);
            this.BT_ThuNho.TabIndex = 106;
            this.BT_ThuNho.Text = "Thu nhỏ";
            this.BT_ThuNho.UseVisualStyleBackColor = false;
            this.BT_ThuNho.Click += new System.EventHandler(this.BT_ThuNho_Click);
            this.BT_ThuNho.Leave += new System.EventHandler(this.BT_ThuNho_Leave);
            this.BT_ThuNho.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.BackColor = System.Drawing.Color.DarkRed;
            this.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(1008, 5);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 107;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // frmTraCuuPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.grpKieuTimKiem);
            this.Controls.Add(this.chbTimTheoNgay);
            this.Controls.Add(this.grbTimTheoNgay);
            this.Controls.Add(this.txtTenKhachDaiDien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgDanhSachPhieuThue);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhieuThue);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblTenKhachDaiDien);
            this.Controls.Add(this.lblMaPhieuThue);
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
            this.grbTimTheoNgay.ResumeLayout(false);
            this.grbTimTheoNgay.PerformLayout();
            this.grpKieuTimKiem.ResumeLayout(false);
            this.grpKieuTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
    }
}