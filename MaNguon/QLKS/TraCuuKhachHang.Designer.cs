namespace QLKS
{
    partial class TraCuuKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuKhachHang));
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.rbtnMaKH = new System.Windows.Forms.RadioButton();
            this.rbtnHoTen = new System.Windows.Forms.RadioButton();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.rbtnLoaiKH = new System.Windows.Forms.RadioButton();
            this.cbLoaiKH = new System.Windows.Forms.ComboBox();
            this.rbtnSoGiayTo = new System.Windows.Forms.RadioButton();
            this.tbSoGiayTo = new System.Windows.Forms.TextBox();
            this.rbtnDiaChi = new System.Windows.Forms.RadioButton();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.dataGrid_ThongTinKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGiayTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuuNangCao = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThongTinKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaKH
            // 
            this.tbMaKH.BackColor = System.Drawing.Color.OliveDrab;
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaKH.ForeColor = System.Drawing.Color.White;
            this.tbMaKH.Location = new System.Drawing.Point(149, 25);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(178, 23);
            this.tbMaKH.TabIndex = 2;
            this.tbMaKH.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.tbMaKH.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // rbtnMaKH
            // 
            this.rbtnMaKH.AutoSize = true;
            this.rbtnMaKH.BackColor = System.Drawing.Color.White;
            this.rbtnMaKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnMaKH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtnMaKH.Location = new System.Drawing.Point(13, 26);
            this.rbtnMaKH.Name = "rbtnMaKH";
            this.rbtnMaKH.Size = new System.Drawing.Size(101, 20);
            this.rbtnMaKH.TabIndex = 1;
            this.rbtnMaKH.TabStop = true;
            this.rbtnMaKH.Text = "Theo Mã KH";
            this.rbtnMaKH.UseVisualStyleBackColor = false;
            this.rbtnMaKH.CheckedChanged += new System.EventHandler(this.rbtnMaKH_CheckedChanged);
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.BackColor = System.Drawing.Color.White;
            this.rbtnHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnHoTen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtnHoTen.Location = new System.Drawing.Point(13, 86);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(105, 20);
            this.rbtnHoTen.TabIndex = 3;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Theo Họ Tên";
            this.rbtnHoTen.UseVisualStyleBackColor = false;
            this.rbtnHoTen.CheckedChanged += new System.EventHandler(this.rbtnHoTen_CheckedChanged);
            // 
            // tbHoTen
            // 
            this.tbHoTen.BackColor = System.Drawing.Color.OliveDrab;
            this.tbHoTen.Enabled = false;
            this.tbHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHoTen.ForeColor = System.Drawing.Color.White;
            this.tbHoTen.Location = new System.Drawing.Point(149, 85);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(178, 23);
            this.tbHoTen.TabIndex = 4;
            this.tbHoTen.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.tbHoTen.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // rbtnLoaiKH
            // 
            this.rbtnLoaiKH.AutoSize = true;
            this.rbtnLoaiKH.BackColor = System.Drawing.Color.White;
            this.rbtnLoaiKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnLoaiKH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtnLoaiKH.Location = new System.Drawing.Point(13, 146);
            this.rbtnLoaiKH.Name = "rbtnLoaiKH";
            this.rbtnLoaiKH.Size = new System.Drawing.Size(108, 20);
            this.rbtnLoaiKH.TabIndex = 5;
            this.rbtnLoaiKH.TabStop = true;
            this.rbtnLoaiKH.Text = "Theo Loại KH";
            this.rbtnLoaiKH.UseVisualStyleBackColor = false;
            this.rbtnLoaiKH.CheckedChanged += new System.EventHandler(this.rbtnLoaiKH_CheckedChanged);
            // 
            // cbLoaiKH
            // 
            this.cbLoaiKH.BackColor = System.Drawing.Color.OliveDrab;
            this.cbLoaiKH.Enabled = false;
            this.cbLoaiKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiKH.ForeColor = System.Drawing.Color.White;
            this.cbLoaiKH.FormattingEnabled = true;
            this.cbLoaiKH.Location = new System.Drawing.Point(149, 145);
            this.cbLoaiKH.Name = "cbLoaiKH";
            this.cbLoaiKH.Size = new System.Drawing.Size(178, 24);
            this.cbLoaiKH.TabIndex = 6;
            this.cbLoaiKH.Leave += new System.EventHandler(this.cbLoaiKH_Leave);
            this.cbLoaiKH.Enter += new System.EventHandler(this.cbLoaiKH_Enter);
            // 
            // rbtnSoGiayTo
            // 
            this.rbtnSoGiayTo.AutoSize = true;
            this.rbtnSoGiayTo.BackColor = System.Drawing.Color.White;
            this.rbtnSoGiayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnSoGiayTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtnSoGiayTo.Location = new System.Drawing.Point(348, 26);
            this.rbtnSoGiayTo.Name = "rbtnSoGiayTo";
            this.rbtnSoGiayTo.Size = new System.Drawing.Size(126, 20);
            this.rbtnSoGiayTo.TabIndex = 7;
            this.rbtnSoGiayTo.TabStop = true;
            this.rbtnSoGiayTo.Text = "Theo Số giấy tờ";
            this.rbtnSoGiayTo.UseVisualStyleBackColor = false;
            this.rbtnSoGiayTo.CheckedChanged += new System.EventHandler(this.rbtnSoGiayTo_CheckedChanged);
            // 
            // tbSoGiayTo
            // 
            this.tbSoGiayTo.BackColor = System.Drawing.Color.OliveDrab;
            this.tbSoGiayTo.Enabled = false;
            this.tbSoGiayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoGiayTo.ForeColor = System.Drawing.Color.White;
            this.tbSoGiayTo.Location = new System.Drawing.Point(497, 25);
            this.tbSoGiayTo.Name = "tbSoGiayTo";
            this.tbSoGiayTo.Size = new System.Drawing.Size(178, 23);
            this.tbSoGiayTo.TabIndex = 8;
            this.tbSoGiayTo.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.tbSoGiayTo.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // rbtnDiaChi
            // 
            this.rbtnDiaChi.AutoSize = true;
            this.rbtnDiaChi.BackColor = System.Drawing.Color.White;
            this.rbtnDiaChi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtnDiaChi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtnDiaChi.Location = new System.Drawing.Point(348, 86);
            this.rbtnDiaChi.Name = "rbtnDiaChi";
            this.rbtnDiaChi.Size = new System.Drawing.Size(104, 20);
            this.rbtnDiaChi.TabIndex = 9;
            this.rbtnDiaChi.TabStop = true;
            this.rbtnDiaChi.Text = "Theo Địa chỉ";
            this.rbtnDiaChi.UseVisualStyleBackColor = false;
            this.rbtnDiaChi.CheckedChanged += new System.EventHandler(this.rbtnDiaChi_CheckedChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.Color.OliveDrab;
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDiaChi.ForeColor = System.Drawing.Color.White;
            this.tbDiaChi.Location = new System.Drawing.Point(497, 85);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(178, 20);
            this.tbDiaChi.TabIndex = 10;
            this.tbDiaChi.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            this.tbDiaChi.Enter += new System.EventHandler(this.txtMaPhong_Enter);
            // 
            // dataGrid_ThongTinKH
            // 
            this.dataGrid_ThongTinKH.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGrid_ThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ThongTinKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.LoaiKH,
            this.SoGiayTo,
            this.DiaChi});
            this.dataGrid_ThongTinKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid_ThongTinKH.EnableHeadersVisualStyles = false;
            this.dataGrid_ThongTinKH.GridColor = System.Drawing.Color.YellowGreen;
            this.dataGrid_ThongTinKH.Location = new System.Drawing.Point(81, 394);
            this.dataGrid_ThongTinKH.Name = "dataGrid_ThongTinKH";
            this.dataGrid_ThongTinKH.ReadOnly = true;
            this.dataGrid_ThongTinKH.RowHeadersVisible = false;
            this.dataGrid_ThongTinKH.Size = new System.Drawing.Size(968, 333);
            this.dataGrid_ThongTinKH.TabIndex = 14;
            this.dataGrid_ThongTinKH.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGrid_ThongTinKH_Paint);
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 120;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 200;
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.ReadOnly = true;
            this.LoaiKH.Width = 180;
            // 
            // SoGiayTo
            // 
            this.SoGiayTo.HeaderText = "Số giấy tờ";
            this.SoGiayTo.Name = "SoGiayTo";
            this.SoGiayTo.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 350;
            // 
            // btnTraCuuNangCao
            // 
            this.btnTraCuuNangCao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTraCuuNangCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuNangCao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraCuuNangCao.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuNangCao.Location = new System.Drawing.Point(38, 110);
            this.btnTraCuuNangCao.Name = "btnTraCuuNangCao";
            this.btnTraCuuNangCao.Size = new System.Drawing.Size(195, 59);
            this.btnTraCuuNangCao.TabIndex = 12;
            this.btnTraCuuNangCao.Text = "Tra cứu nâng cao";
            this.btnTraCuuNangCao.UseVisualStyleBackColor = false;
            this.btnTraCuuNangCao.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnTraCuuNangCao.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(38, 24);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(95, 59);
            this.btnTraCuu.TabIndex = 11;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            this.btnTraCuu.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnTraCuu.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHTCKhachHang;
            this.pictureBox1.Location = new System.Drawing.Point(4, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 720);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(138, 24);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(95, 59);
            this.btnQuayLai.TabIndex = 13;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            this.btnQuayLai.Leave += new System.EventHandler(this.btnTim_Leave);
            this.btnQuayLai.Enter += new System.EventHandler(this.btnTim_Enter);
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(891, 5);
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
            this.BT_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(980, 5);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 107;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbHoTen);
            this.panel1.Controls.Add(this.tbMaKH);
            this.panel1.Controls.Add(this.rbtnMaKH);
            this.panel1.Controls.Add(this.rbtnHoTen);
            this.panel1.Controls.Add(this.rbtnLoaiKH);
            this.panel1.Controls.Add(this.cbLoaiKH);
            this.panel1.Controls.Add(this.rbtnSoGiayTo);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.tbSoGiayTo);
            this.panel1.Controls.Add(this.rbtnDiaChi);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(81, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 195);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTraCuuNangCao);
            this.panel2.Controls.Add(this.btnTraCuu);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Location = new System.Drawing.Point(776, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 195);
            this.panel2.TabIndex = 109;
            // 
            // TraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.dataGrid_ThongTinKH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraCuuKhachHang";
            this.Text = "TraCuuKhachHang";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraCuuPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThongTinKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.RadioButton rbtnMaKH;
        private System.Windows.Forms.RadioButton rbtnHoTen;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.RadioButton rbtnLoaiKH;
        private System.Windows.Forms.ComboBox cbLoaiKH;
        private System.Windows.Forms.RadioButton rbtnSoGiayTo;
        private System.Windows.Forms.TextBox tbSoGiayTo;
        private System.Windows.Forms.RadioButton rbtnDiaChi;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.DataGridView dataGrid_ThongTinKH;
        private System.Windows.Forms.Button btnTraCuuNangCao;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGiayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}