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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.dtgDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.cMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.cbxTimChinhXac = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(503, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(503, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.Color.OliveDrab;
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.ForeColor = System.Drawing.Color.White;
            this.txtMaPhong.Location = new System.Drawing.Point(297, 228);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(155, 23);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtMaPhong.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.White;
            this.txtTenPhong.Location = new System.Drawing.Point(297, 286);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(155, 23);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtTenPhong.Enter += new System.EventHandler(this.txtMaPhong_Enter);
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
            this.dtgDanhSachPhong.Location = new System.Drawing.Point(175, 372);
            this.dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            this.dtgDanhSachPhong.RowHeadersVisible = false;
            this.dtgDanhSachPhong.Size = new System.Drawing.Size(780, 342);
            this.dtgDanhSachPhong.TabIndex = 8;
            this.dtgDanhSachPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgDanhSachPhong_Paint);
            // 
            // cMaPhong
            // 
            this.cMaPhong.HeaderText = "Mã phòng";
            this.cMaPhong.Name = "cMaPhong";
            this.cMaPhong.ReadOnly = true;
            this.cMaPhong.Width = 120;
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
            this.cMaLoaiPhong.Width = 120;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            this.cGhiChu.Width = 180;
            // 
            // cTinhTrang
            // 
            this.cTinhTrang.HeaderText = "Tình trạng";
            this.cTinhTrang.Name = "cTinhTrang";
            this.cTinhTrang.ReadOnly = true;
            this.cTinhTrang.Width = 150;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(829, 228);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 52);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnTim.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(829, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnThoat.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.BackColor = System.Drawing.Color.OliveDrab;
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(619, 228);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(155, 24);
            this.cmbLoaiPhong.TabIndex = 3;
            this.cmbLoaiPhong.Leave += new System.EventHandler(this.cmbLoaiPhong_Leave);
            this.cmbLoaiPhong.Enter += new System.EventHandler(this.cmbLoaiPhong_Enter);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.White;
            this.txtTinhTrang.Location = new System.Drawing.Point(619, 286);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(155, 23);
            this.txtTinhTrang.TabIndex = 4;
            this.txtTinhTrang.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.txtTinhTrang.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // cbxTimChinhXac
            // 
            this.cbxTimChinhXac.AutoSize = true;
            this.cbxTimChinhXac.BackColor = System.Drawing.Color.Black;
            this.cbxTimChinhXac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimChinhXac.ForeColor = System.Drawing.Color.Gold;
            this.cbxTimChinhXac.Location = new System.Drawing.Point(337, 334);
            this.cbxTimChinhXac.Name = "cbxTimChinhXac";
            this.cbxTimChinhXac.Size = new System.Drawing.Size(126, 21);
            this.cbxTimChinhXac.TabIndex = 5;
            this.cbxTimChinhXac.Text = "Tìm chính xác";
            this.cbxTimChinhXac.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHTCPhong;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 720);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(899, 5);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(84, 44);
            this.BT_ThuNho.TabIndex = 104;
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
            this.BT_Thoat.Location = new System.Drawing.Point(988, 5);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 105;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // TraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.cbxTimChinhXac);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgDanhSachPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.CheckBox cbxTimChinhXac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTinhTrang;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
    }
}