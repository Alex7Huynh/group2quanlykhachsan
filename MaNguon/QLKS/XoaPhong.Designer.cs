namespace QLKS
{
    partial class XoaPhong
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
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.clMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhong,
            this.clTenPhong,
            this.clLoaiPhong,
            this.clGhiChu,
            this.clTinhTrang});
            this.dtg1.Location = new System.Drawing.Point(-3, 88);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(583, 206);
            this.dtg1.TabIndex = 0;
            this.dtg1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dtg1_MouseMove);
            this.dtg1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtg1_MouseUp);
            // 
            // clMaPhong
            // 
            this.clMaPhong.HeaderText = "MaPhong";
            this.clMaPhong.Name = "clMaPhong";
            // 
            // clTenPhong
            // 
            this.clTenPhong.HeaderText = "TenPhong";
            this.clTenPhong.Name = "clTenPhong";
            // 
            // clLoaiPhong
            // 
            this.clLoaiPhong.HeaderText = "LoaiPhong";
            this.clLoaiPhong.Name = "clLoaiPhong";
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "TinhTrang";
            this.clTinhTrang.Name = "clTinhTrang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SACH PHONG";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(80, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(409, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // XoaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 357);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg1);
            this.Name = "XoaPhong";
            this.Text = "XoaPhong";
            this.Load += new System.EventHandler(this.XoaPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}