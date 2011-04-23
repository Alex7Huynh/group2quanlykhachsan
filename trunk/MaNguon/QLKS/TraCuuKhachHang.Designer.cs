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
            this.lblTraCuuKhachHang = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThongTinKH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTraCuuKhachHang
            // 
            this.lblTraCuuKhachHang.AutoSize = true;
            this.lblTraCuuKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraCuuKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblTraCuuKhachHang.Location = new System.Drawing.Point(153, 9);
            this.lblTraCuuKhachHang.Name = "lblTraCuuKhachHang";
            this.lblTraCuuKhachHang.Size = new System.Drawing.Size(215, 26);
            this.lblTraCuuKhachHang.TabIndex = 15;
            this.lblTraCuuKhachHang.Text = "Tra Cứu Khách Hàng";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Location = new System.Drawing.Point(114, 62);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(123, 20);
            this.tbMaKH.TabIndex = 17;
            // 
            // rbtnMaKH
            // 
            this.rbtnMaKH.AutoSize = true;
            this.rbtnMaKH.Location = new System.Drawing.Point(13, 62);
            this.rbtnMaKH.Name = "rbtnMaKH";
            this.rbtnMaKH.Size = new System.Drawing.Size(86, 17);
            this.rbtnMaKH.TabIndex = 16;
            this.rbtnMaKH.TabStop = true;
            this.rbtnMaKH.Text = "Theo Mã KH";
            this.rbtnMaKH.UseVisualStyleBackColor = true;
            this.rbtnMaKH.CheckedChanged += new System.EventHandler(this.rbtnMaKH_CheckedChanged);
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.Location = new System.Drawing.Point(13, 104);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(89, 17);
            this.rbtnHoTen.TabIndex = 19;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Theo Họ Tên";
            this.rbtnHoTen.UseVisualStyleBackColor = true;
            this.rbtnHoTen.CheckedChanged += new System.EventHandler(this.rbtnHoTen_CheckedChanged);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Enabled = false;
            this.tbHoTen.Location = new System.Drawing.Point(114, 104);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(123, 20);
            this.tbHoTen.TabIndex = 20;
            // 
            // rbtnLoaiKH
            // 
            this.rbtnLoaiKH.AutoSize = true;
            this.rbtnLoaiKH.Location = new System.Drawing.Point(13, 145);
            this.rbtnLoaiKH.Name = "rbtnLoaiKH";
            this.rbtnLoaiKH.Size = new System.Drawing.Size(91, 17);
            this.rbtnLoaiKH.TabIndex = 21;
            this.rbtnLoaiKH.TabStop = true;
            this.rbtnLoaiKH.Text = "Theo Loại KH";
            this.rbtnLoaiKH.UseVisualStyleBackColor = true;
            this.rbtnLoaiKH.CheckedChanged += new System.EventHandler(this.rbtnLoaiKH_CheckedChanged);
            // 
            // cbLoaiKH
            // 
            this.cbLoaiKH.Enabled = false;
            this.cbLoaiKH.FormattingEnabled = true;
            this.cbLoaiKH.Location = new System.Drawing.Point(114, 145);
            this.cbLoaiKH.Name = "cbLoaiKH";
            this.cbLoaiKH.Size = new System.Drawing.Size(123, 21);
            this.cbLoaiKH.TabIndex = 22;
            // 
            // rbtnSoGiayTo
            // 
            this.rbtnSoGiayTo.AutoSize = true;
            this.rbtnSoGiayTo.Location = new System.Drawing.Point(283, 65);
            this.rbtnSoGiayTo.Name = "rbtnSoGiayTo";
            this.rbtnSoGiayTo.Size = new System.Drawing.Size(100, 17);
            this.rbtnSoGiayTo.TabIndex = 23;
            this.rbtnSoGiayTo.TabStop = true;
            this.rbtnSoGiayTo.Text = "Theo Số giấy tờ";
            this.rbtnSoGiayTo.UseVisualStyleBackColor = true;
            this.rbtnSoGiayTo.CheckedChanged += new System.EventHandler(this.rbtnSoGiayTo_CheckedChanged);
            // 
            // tbSoGiayTo
            // 
            this.tbSoGiayTo.Enabled = false;
            this.tbSoGiayTo.Location = new System.Drawing.Point(389, 62);
            this.tbSoGiayTo.Name = "tbSoGiayTo";
            this.tbSoGiayTo.Size = new System.Drawing.Size(123, 20);
            this.tbSoGiayTo.TabIndex = 24;
            // 
            // rbtnDiaChi
            // 
            this.rbtnDiaChi.AutoSize = true;
            this.rbtnDiaChi.Location = new System.Drawing.Point(283, 104);
            this.rbtnDiaChi.Name = "rbtnDiaChi";
            this.rbtnDiaChi.Size = new System.Drawing.Size(86, 17);
            this.rbtnDiaChi.TabIndex = 25;
            this.rbtnDiaChi.TabStop = true;
            this.rbtnDiaChi.Text = "Theo Địa chỉ";
            this.rbtnDiaChi.UseVisualStyleBackColor = true;
            this.rbtnDiaChi.CheckedChanged += new System.EventHandler(this.rbtnDiaChi_CheckedChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(389, 104);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(123, 20);
            this.tbDiaChi.TabIndex = 26;
            // 
            // dataGrid_ThongTinKH
            // 
            this.dataGrid_ThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ThongTinKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.LoaiKH,
            this.SoGiayTo,
            this.DiaChi});
            this.dataGrid_ThongTinKH.Location = new System.Drawing.Point(12, 191);
            this.dataGrid_ThongTinKH.Name = "dataGrid_ThongTinKH";
            this.dataGrid_ThongTinKH.RowHeadersVisible = false;
            this.dataGrid_ThongTinKH.Size = new System.Drawing.Size(507, 150);
            this.dataGrid_ThongTinKH.TabIndex = 27;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loại KH";
            this.LoaiKH.Name = "LoaiKH";
            // 
            // SoGiayTo
            // 
            this.SoGiayTo.HeaderText = "Số giấy tờ";
            this.SoGiayTo.Name = "SoGiayTo";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // btnTraCuuNangCao
            // 
            this.btnTraCuuNangCao.Location = new System.Drawing.Point(330, 357);
            this.btnTraCuuNangCao.Name = "btnTraCuuNangCao";
            this.btnTraCuuNangCao.Size = new System.Drawing.Size(108, 23);
            this.btnTraCuuNangCao.TabIndex = 28;
            this.btnTraCuuNangCao.Text = "Tra cứu nâng cao";
            this.btnTraCuuNangCao.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(444, 357);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 28;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // TraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 392);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnTraCuuNangCao);
            this.Controls.Add(this.dataGrid_ThongTinKH);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.rbtnDiaChi);
            this.Controls.Add(this.tbSoGiayTo);
            this.Controls.Add(this.rbtnSoGiayTo);
            this.Controls.Add(this.cbLoaiKH);
            this.Controls.Add(this.rbtnLoaiKH);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.rbtnHoTen);
            this.Controls.Add(this.rbtnMaKH);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.lblTraCuuKhachHang);
            this.Name = "TraCuuKhachHang";
            this.Text = "TraCuuKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThongTinKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraCuuKhachHang;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGiayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;

    }
}