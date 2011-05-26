namespace QLKS
{
    partial class TraCuuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuPhong));
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.dtgDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.cMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.cbxTimChinhXac = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.Color.White;
            this.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.ForeColor = System.Drawing.Color.Black;
            this.txtMaPhong.Location = new System.Drawing.Point(51, 222);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(193, 23);
            this.txtMaPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.White;
            this.txtTenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.Black;
            this.txtTenPhong.Location = new System.Drawing.Point(51, 303);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(193, 23);
            this.txtTenPhong.TabIndex = 2;
            // 
            // dtgDanhSachPhong
            // 
            this.dtgDanhSachPhong.BackgroundColor = System.Drawing.Color.Indigo;
            this.dtgDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaPhong,
            this.cTenPhong,
            this.cMaLoaiPhong,
            this.cGhiChu,
            this.cTinhTrang});
            this.dtgDanhSachPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgDanhSachPhong.EnableHeadersVisualStyles = false;
            this.dtgDanhSachPhong.GridColor = System.Drawing.Color.Orange;
            this.dtgDanhSachPhong.Location = new System.Drawing.Point(49, 372);
            this.dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            this.dtgDanhSachPhong.RowHeadersVisible = false;
            this.dtgDanhSachPhong.Size = new System.Drawing.Size(927, 349);
            this.dtgDanhSachPhong.TabIndex = 8;
            this.dtgDanhSachPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgDanhSachPhong_Paint);
            // 
            // cMaPhong
            // 
            this.cMaPhong.HeaderText = "Mã phòng";
            this.cMaPhong.Name = "cMaPhong";
            this.cMaPhong.ReadOnly = true;
            this.cMaPhong.Width = 150;
            // 
            // cTenPhong
            // 
            this.cTenPhong.HeaderText = "Tên phòng";
            this.cTenPhong.Name = "cTenPhong";
            this.cTenPhong.ReadOnly = true;
            this.cTenPhong.Width = 200;
            // 
            // cMaLoaiPhong
            // 
            this.cMaLoaiPhong.HeaderText = "Mã loại phòng";
            this.cMaLoaiPhong.Name = "cMaLoaiPhong";
            this.cMaLoaiPhong.ReadOnly = true;
            this.cMaLoaiPhong.Width = 170;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            this.cGhiChu.Width = 250;
            // 
            // cTinhTrang
            // 
            this.cTinhTrang.HeaderText = "Tình trạng";
            this.cTinhTrang.Name = "cTinhTrang";
            this.cTinhTrang.ReadOnly = true;
            this.cTinhTrang.Width = 150;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.BackColor = System.Drawing.Color.White;
            this.cmbLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(283, 222);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(194, 24);
            this.cmbLoaiPhong.TabIndex = 3;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.White;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.txtTinhTrang.Location = new System.Drawing.Point(283, 303);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(194, 23);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // cbxTimChinhXac
            // 
            this.cbxTimChinhXac.AutoSize = true;
            this.cbxTimChinhXac.BackColor = System.Drawing.Color.White;
            this.cbxTimChinhXac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxTimChinhXac.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxTimChinhXac.Location = new System.Drawing.Point(545, 190);
            this.cbxTimChinhXac.Name = "cbxTimChinhXac";
            this.cbxTimChinhXac.Size = new System.Drawing.Size(15, 14);
            this.cbxTimChinhXac.TabIndex = 5;
            this.cbxTimChinhXac.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonQuayLai;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(768, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 47);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnThoat_MouseEnter);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTim.BackgroundImage = global::QLKS.Properties.Resources.ButtonSearch;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(768, 198);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(188, 47);
            this.btnTim.TabIndex = 6;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.MouseEnter += new System.EventHandler(this.btnTim_MouseEnter);
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
            this.BT_ThuNho.TabIndex = 104;
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
            this.BT_Thoat.TabIndex = 105;
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.MouseLeave += new System.EventHandler(this.BT_Thoat_MouseLeave);
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.MouseEnter += new System.EventHandler(this.BT_Thoat_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHTraCuuPhong;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 790);
            this.Controls.Add(this.cbxTimChinhXac);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.dtgDanhSachPhong);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TraCuuPhong";
            this.Text = "TraCuuPhong";
            this.Load += new System.EventHandler(this.TraCuuPhong_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraCuuPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.CheckBox cbxTimChinhXac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTinhTrang;
    }
}