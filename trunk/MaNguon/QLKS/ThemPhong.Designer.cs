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
            this.PB_Main = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Information = new System.Windows.Forms.Panel();
            this.Panel_Them = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main)).BeginInit();
            this.Panel_Information.SuspendLayout();
            this.Panel_Them.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_MaPhong
            // 
            this.LB_MaPhong.AutoSize = true;
            this.LB_MaPhong.BackColor = System.Drawing.Color.White;
            this.LB_MaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_MaPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_MaPhong.Location = new System.Drawing.Point(21, 18);
            this.LB_MaPhong.Name = "LB_MaPhong";
            this.LB_MaPhong.Size = new System.Drawing.Size(80, 16);
            this.LB_MaPhong.TabIndex = 0;
            this.LB_MaPhong.Text = "Mã phòng :";
            // 
            // txtMP
            // 
            this.txtMP.BackColor = System.Drawing.Color.OliveDrab;
            this.txtMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMP.ForeColor = System.Drawing.Color.White;
            this.txtMP.Location = new System.Drawing.Point(126, 15);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(249, 23);
            this.txtMP.TabIndex = 1;
            this.txtMP.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtMP.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_TenPhong
            // 
            this.LB_TenPhong.AutoSize = true;
            this.LB_TenPhong.BackColor = System.Drawing.Color.White;
            this.LB_TenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_TenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_TenPhong.Location = new System.Drawing.Point(385, 18);
            this.LB_TenPhong.Name = "LB_TenPhong";
            this.LB_TenPhong.Size = new System.Drawing.Size(84, 16);
            this.LB_TenPhong.TabIndex = 0;
            this.LB_TenPhong.Text = "Tên phòng :";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(484, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(249, 23);
            this.txtTen.TabIndex = 3;
            this.txtTen.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtTen.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_LoaiPhong
            // 
            this.LB_LoaiPhong.AutoSize = true;
            this.LB_LoaiPhong.BackColor = System.Drawing.Color.White;
            this.LB_LoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_LoaiPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_LoaiPhong.Location = new System.Drawing.Point(21, 71);
            this.LB_LoaiPhong.Name = "LB_LoaiPhong";
            this.LB_LoaiPhong.Size = new System.Drawing.Size(87, 16);
            this.LB_LoaiPhong.TabIndex = 0;
            this.LB_LoaiPhong.Text = "Loại phòng :";
            // 
            // LB_GhiChu
            // 
            this.LB_GhiChu.AutoSize = true;
            this.LB_GhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_GhiChu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_GhiChu.Location = new System.Drawing.Point(385, 71);
            this.LB_GhiChu.Name = "LB_GhiChu";
            this.LB_GhiChu.Size = new System.Drawing.Size(63, 16);
            this.LB_GhiChu.TabIndex = 0;
            this.LB_GhiChu.Text = "Ghi chú :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.OliveDrab;
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(484, 68);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(249, 23);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.Leave += new System.EventHandler(this.txtMP_Leave);
            this.txtGhiChu.Enter += new System.EventHandler(this.txtMP_Enter);
            // 
            // LB_TinhTrang
            // 
            this.LB_TinhTrang.AutoSize = true;
            this.LB_TinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_TinhTrang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_TinhTrang.Location = new System.Drawing.Point(385, 121);
            this.LB_TinhTrang.Name = "LB_TinhTrang";
            this.LB_TinhTrang.Size = new System.Drawing.Size(83, 16);
            this.LB_TinhTrang.TabIndex = 0;
            this.LB_TinhTrang.Text = "Tình trạng :";
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.OliveDrab;
            this.txtTT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTT.ForeColor = System.Drawing.Color.White;
            this.txtTT.Location = new System.Drawing.Point(484, 118);
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
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 17);
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
            this.btnXoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(29, 16);
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
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(25, 16);
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
            this.cmbLoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoai.ForeColor = System.Drawing.Color.White;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(126, 68);
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
            this.BT_ThuNho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.BT_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            // PB_Main
            // 
            this.PB_Main.Image = global::QLKS.Properties.Resources.MHThemPhong;
            this.PB_Main.Location = new System.Drawing.Point(3, 28);
            this.PB_Main.Name = "PB_Main";
            this.PB_Main.Size = new System.Drawing.Size(1123, 720);
            this.PB_Main.TabIndex = 5;
            this.PB_Main.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "(Maphong theo dang : Axxx---A:Loai Phong , xxx:Ma So Phong)";
            // 
            // Panel_Information
            // 
            this.Panel_Information.BackColor = System.Drawing.Color.White;
            this.Panel_Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Information.Controls.Add(this.LB_LoaiPhong);
            this.Panel_Information.Controls.Add(this.label1);
            this.Panel_Information.Controls.Add(this.LB_MaPhong);
            this.Panel_Information.Controls.Add(this.txtMP);
            this.Panel_Information.Controls.Add(this.cmbLoai);
            this.Panel_Information.Controls.Add(this.txtGhiChu);
            this.Panel_Information.Controls.Add(this.LB_TenPhong);
            this.Panel_Information.Controls.Add(this.txtTT);
            this.Panel_Information.Controls.Add(this.txtTen);
            this.Panel_Information.Controls.Add(this.LB_TinhTrang);
            this.Panel_Information.Controls.Add(this.LB_GhiChu);
            this.Panel_Information.Location = new System.Drawing.Point(182, 179);
            this.Panel_Information.Name = "Panel_Information";
            this.Panel_Information.Size = new System.Drawing.Size(771, 155);
            this.Panel_Information.TabIndex = 105;
            // 
            // Panel_Them
            // 
            this.Panel_Them.BackColor = System.Drawing.Color.White;
            this.Panel_Them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Them.Controls.Add(this.btnThem);
            this.Panel_Them.Location = new System.Drawing.Point(12, 425);
            this.Panel_Them.Name = "Panel_Them";
            this.Panel_Them.Size = new System.Drawing.Size(154, 92);
            this.Panel_Them.TabIndex = 106;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(12, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 92);
            this.panel1.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(972, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 92);
            this.panel2.TabIndex = 107;
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Them);
            this.Controls.Add(this.Panel_Information);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PB_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            this.Load += new System.EventHandler(this.ThemPhong_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main)).EndInit();
            this.Panel_Information.ResumeLayout(false);
            this.Panel_Information.PerformLayout();
            this.Panel_Them.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox PB_Main;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Information;
        private System.Windows.Forms.Panel Panel_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}