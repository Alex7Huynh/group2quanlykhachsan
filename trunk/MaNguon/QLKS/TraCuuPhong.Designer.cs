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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.dtgDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.cbxTimChinhXac = new System.Windows.Forms.CheckBox();
            this.cMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(108, 74);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(155, 20);
            this.txtMaPhong.TabIndex = 4;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(108, 114);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(155, 20);
            this.txtTenPhong.TabIndex = 7;
            // 
            // dtgDanhSachPhong
            // 
            this.dtgDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaPhong,
            this.cTenPhong,
            this.cMaLoaiPhong,
            this.cGhiChu,
            this.cTinhTrang});
            this.dtgDanhSachPhong.Location = new System.Drawing.Point(30, 176);
            this.dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            this.dtgDanhSachPhong.RowHeadersVisible = false;
            this.dtgDanhSachPhong.Size = new System.Drawing.Size(503, 286);
            this.dtgDanhSachPhong.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(239, 477);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 36);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(475, 477);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 36);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(391, 73);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(155, 21);
            this.cmbLoaiPhong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(206, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tra Cứu Phòng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(391, 111);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(155, 20);
            this.txtTinhTrang.TabIndex = 15;
            // 
            // cbxTimChinhXac
            // 
            this.cbxTimChinhXac.AutoSize = true;
            this.cbxTimChinhXac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimChinhXac.ForeColor = System.Drawing.Color.Red;
            this.cbxTimChinhXac.Location = new System.Drawing.Point(239, 149);
            this.cbxTimChinhXac.Name = "cbxTimChinhXac";
            this.cbxTimChinhXac.Size = new System.Drawing.Size(113, 21);
            this.cbxTimChinhXac.TabIndex = 17;
            this.cbxTimChinhXac.Text = "Tìm chính xác";
            this.cbxTimChinhXac.UseVisualStyleBackColor = true;
            // 
            // cMaPhong
            // 
            this.cMaPhong.HeaderText = "MaPhong";
            this.cMaPhong.Name = "cMaPhong";
            this.cMaPhong.ReadOnly = true;
            // 
            // cTenPhong
            // 
            this.cTenPhong.HeaderText = "Tên Phòng";
            this.cTenPhong.Name = "cTenPhong";
            this.cTenPhong.ReadOnly = true;
            // 
            // cMaLoaiPhong
            // 
            this.cMaLoaiPhong.HeaderText = "Mã Loại Phòng";
            this.cMaLoaiPhong.Name = "cMaLoaiPhong";
            this.cMaLoaiPhong.ReadOnly = true;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi Chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            // 
            // cTinhTrang
            // 
            this.cTinhTrang.HeaderText = "Tình Trạng";
            this.cTinhTrang.Name = "cTinhTrang";
            this.cTinhTrang.ReadOnly = true;
            // 
            // TraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 520);
            this.Controls.Add(this.cbxTimChinhXac);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label6);
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
            this.MaximizeBox = false;
            this.Name = "TraCuuPhong";
            this.Text = "TraCuuPhong";
            this.Load += new System.EventHandler(this.TraCuuPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhong)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.CheckBox cbxTimChinhXac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTinhTrang;
    }
}