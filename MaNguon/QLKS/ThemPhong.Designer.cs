namespace QLKS
{
    partial class ThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhong));
            this.LB_MaPhong = new System.Windows.Forms.Label();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.LB_TenPhong = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.LB_LoaiPhong = new System.Windows.Forms.Label();
            this.LB_GhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.LB_TinhTrang = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_MaPhong
            // 
            this.LB_MaPhong.AutoSize = true;
            this.LB_MaPhong.BackColor = System.Drawing.Color.Black;
            this.LB_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_MaPhong.ForeColor = System.Drawing.Color.White;
            this.LB_MaPhong.Location = new System.Drawing.Point(94, 190);
            this.LB_MaPhong.Name = "LB_MaPhong";
            this.LB_MaPhong.Size = new System.Drawing.Size(89, 17);
            this.LB_MaPhong.TabIndex = 0;
            this.LB_MaPhong.Text = "Mã phòng :";
            // 
            // txtMP
            // 
            this.txtMP.BackColor = System.Drawing.Color.OliveDrab;
            this.txtMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMP.ForeColor = System.Drawing.Color.White;
            this.txtMP.Location = new System.Drawing.Point(223, 187);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(249, 23);
            this.txtMP.TabIndex = 1;
            this.txtMP.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtMP.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_TenPhong
            // 
            this.LB_TenPhong.AutoSize = true;
            this.LB_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_TenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_TenPhong.Location = new System.Drawing.Point(607, 194);
            this.LB_TenPhong.Name = "LB_TenPhong";
            this.LB_TenPhong.Size = new System.Drawing.Size(96, 17);
            this.LB_TenPhong.TabIndex = 0;
            this.LB_TenPhong.Text = "Tên phòng :";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(761, 188);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(249, 23);
            this.txtTen.TabIndex = 3;
            this.txtTen.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtTen.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_LoaiPhong
            // 
            this.LB_LoaiPhong.AutoSize = true;
            this.LB_LoaiPhong.BackColor = System.Drawing.Color.Black;
            this.LB_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_LoaiPhong.ForeColor = System.Drawing.Color.White;
            this.LB_LoaiPhong.Location = new System.Drawing.Point(94, 247);
            this.LB_LoaiPhong.Name = "LB_LoaiPhong";
            this.LB_LoaiPhong.Size = new System.Drawing.Size(99, 17);
            this.LB_LoaiPhong.TabIndex = 0;
            this.LB_LoaiPhong.Text = "Loại phòng :";
            // 
            // LB_GhiChu
            // 
            this.LB_GhiChu.AutoSize = true;
            this.LB_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_GhiChu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_GhiChu.Location = new System.Drawing.Point(607, 247);
            this.LB_GhiChu.Name = "LB_GhiChu";
            this.LB_GhiChu.Size = new System.Drawing.Size(74, 17);
            this.LB_GhiChu.TabIndex = 0;
            this.LB_GhiChu.Text = "Ghi chú :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.OliveDrab;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(761, 244);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(249, 23);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtGhiChu.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_TinhTrang
            // 
            this.LB_TinhTrang.AutoSize = true;
            this.LB_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_TinhTrang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_TinhTrang.Location = new System.Drawing.Point(607, 297);
            this.LB_TinhTrang.Name = "LB_TinhTrang";
            this.LB_TinhTrang.Size = new System.Drawing.Size(93, 17);
            this.LB_TinhTrang.TabIndex = 0;
            this.LB_TinhTrang.Text = "Tình trạng :";
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTT.ForeColor = System.Drawing.Color.White;
            this.txtTT.Location = new System.Drawing.Point(761, 294);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(249, 23);
            this.txtTT.TabIndex = 5;
            this.txtTT.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtTT.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMP,
            this.clTenPhong,
            this.clLoaiPhong,
            this.clGhiChu,
            this.clTinhTrang});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.Location = new System.Drawing.Point(182, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(771, 381);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // clMP
            // 
            this.clMP.HeaderText = "Mã phòng";
            this.clMP.Name = "clMP";
            // 
            // clTenPhong
            // 
            this.clTenPhong.HeaderText = "Tên phòng";
            this.clTenPhong.Name = "clTenPhong";
            this.clTenPhong.Width = 180;
            // 
            // clLoaiPhong
            // 
            this.clLoaiPhong.HeaderText = "Loại phòng";
            this.clLoaiPhong.Name = "clLoaiPhong";
            this.clLoaiPhong.Width = 120;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Width = 200;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "Tình trạng";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 160;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Orange;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(56, 423);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 58);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.Leave += new System.EventHandler(this.btnXoa_Leave);
            this.btnThem.Enter += new System.EventHandler(this.btnXoa_Enter);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Orange;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(56, 540);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 58);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.Leave += new System.EventHandler(this.btnXoa_Leave);
            this.btnXoa.Enter += new System.EventHandler(this.btnXoa_Enter);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Orange;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(980, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 58);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.Leave += new System.EventHandler(this.btnXoa_Leave);
            this.btnOK.Enter += new System.EventHandler(this.btnXoa_Enter);
            // 
            // cmbLoai
            // 
            this.cmbLoai.BackColor = System.Drawing.Color.OliveDrab;
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoai.ForeColor = System.Drawing.Color.White;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(223, 244);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(249, 24);
            this.cmbLoai.TabIndex = 2;
            this.cmbLoai.Leave += new System.EventHandler(this.cmbLoai_Leave);
            this.cmbLoai.Enter += new System.EventHandler(this.cmbLoai_Enter);
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(911, 4);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(84, 44);
            this.BT_ThuNho.TabIndex = 102;
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
            this.BT_Thoat.Location = new System.Drawing.Point(1000, 4);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 103;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHThemPhong;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 720);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.LB_TinhTrang);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.LB_GhiChu);
            this.Controls.Add(this.LB_LoaiPhong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.LB_TenPhong);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.LB_MaPhong);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            this.Load += new System.EventHandler(this.ThemPhong_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_MaPhong;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Label LB_TenPhong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label LB_LoaiPhong;
        private System.Windows.Forms.Label LB_GhiChu;
        private System.Windows.Forms.Label LB_TinhTrang;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
    }
}