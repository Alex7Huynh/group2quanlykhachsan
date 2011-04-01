namespace G2_QLKS
{
    partial class DieuChinhDanhMucPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieuChinhDanhMucPhong));
            this.label_DieuChinhDanhMucPhong = new System.Windows.Forms.Label();
            this.simpleButton_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView_DanhMucPhong = new System.Windows.Forms.DataGridView();
            this.Column_MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton_HuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_XoaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_ThemPhong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhMucPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DieuChinhDanhMucPhong
            // 
            this.label_DieuChinhDanhMucPhong.AutoSize = true;
            this.label_DieuChinhDanhMucPhong.BackColor = System.Drawing.Color.Transparent;
            this.label_DieuChinhDanhMucPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DieuChinhDanhMucPhong.ForeColor = System.Drawing.Color.Aqua;
            this.label_DieuChinhDanhMucPhong.Location = new System.Drawing.Point(147, 32);
            this.label_DieuChinhDanhMucPhong.Name = "label_DieuChinhDanhMucPhong";
            this.label_DieuChinhDanhMucPhong.Size = new System.Drawing.Size(536, 37);
            this.label_DieuChinhDanhMucPhong.TabIndex = 0;
            this.label_DieuChinhDanhMucPhong.Text = "ĐIỀU CHỈNH DANH MỤC PHÒNG";
            // 
            // simpleButton_XacNhan
            // 
            this.simpleButton_XacNhan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton_XacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_XacNhan.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_XacNhan.Appearance.Options.UseBackColor = true;
            this.simpleButton_XacNhan.Appearance.Options.UseFont = true;
            this.simpleButton_XacNhan.Appearance.Options.UseForeColor = true;
            this.simpleButton_XacNhan.Appearance.Options.UseImage = true;
            this.simpleButton_XacNhan.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.simpleButton_XacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton_XacNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_XacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_XacNhan.Location = new System.Drawing.Point(570, 356);
            this.simpleButton_XacNhan.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton_XacNhan.Name = "simpleButton_XacNhan";
            this.simpleButton_XacNhan.Size = new System.Drawing.Size(101, 33);
            this.simpleButton_XacNhan.TabIndex = 1;
            this.simpleButton_XacNhan.Text = "Xác nhận";
            this.simpleButton_XacNhan.Click += new System.EventHandler(this.simpleButton_XacNhan_Click);
            // 
            // dataGridView_DanhMucPhong
            // 
            this.dataGridView_DanhMucPhong.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView_DanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhMucPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaPhong,
            this.Column_LoaiPhong,
            this.Column_GhiChu});
            this.dataGridView_DanhMucPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView_DanhMucPhong.Location = new System.Drawing.Point(60, 124);
            this.dataGridView_DanhMucPhong.Name = "dataGridView_DanhMucPhong";
            this.dataGridView_DanhMucPhong.Size = new System.Drawing.Size(684, 150);
            this.dataGridView_DanhMucPhong.TabIndex = 0;
            // 
            // Column_MaPhong
            // 
            this.Column_MaPhong.FillWeight = 200F;
            this.Column_MaPhong.HeaderText = "Mã phòng";
            this.Column_MaPhong.Name = "Column_MaPhong";
            this.Column_MaPhong.Width = 200;
            // 
            // Column_LoaiPhong
            // 
            this.Column_LoaiPhong.FillWeight = 200F;
            this.Column_LoaiPhong.HeaderText = "Loại phòng";
            this.Column_LoaiPhong.Name = "Column_LoaiPhong";
            this.Column_LoaiPhong.Width = 200;
            // 
            // Column_GhiChu
            // 
            this.Column_GhiChu.FillWeight = 250F;
            this.Column_GhiChu.HeaderText = "Ghi chú";
            this.Column_GhiChu.Name = "Column_GhiChu";
            this.Column_GhiChu.Width = 250;
            // 
            // simpleButton_HuyBo
            // 
            this.simpleButton_HuyBo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton_HuyBo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_HuyBo.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_HuyBo.Appearance.Options.UseBackColor = true;
            this.simpleButton_HuyBo.Appearance.Options.UseFont = true;
            this.simpleButton_HuyBo.Appearance.Options.UseForeColor = true;
            this.simpleButton_HuyBo.Appearance.Options.UseImage = true;
            this.simpleButton_HuyBo.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.simpleButton_HuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton_HuyBo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_HuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_HuyBo.Location = new System.Drawing.Point(702, 356);
            this.simpleButton_HuyBo.Name = "simpleButton_HuyBo";
            this.simpleButton_HuyBo.Size = new System.Drawing.Size(101, 33);
            this.simpleButton_HuyBo.TabIndex = 2;
            this.simpleButton_HuyBo.Text = "Hủy bỏ";
            this.simpleButton_HuyBo.Click += new System.EventHandler(this.simpleButton_HuyBo_Click);
            // 
            // simpleButton_XoaPhong
            // 
            this.simpleButton_XoaPhong.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton_XoaPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_XoaPhong.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_XoaPhong.Appearance.Options.UseBackColor = true;
            this.simpleButton_XoaPhong.Appearance.Options.UseFont = true;
            this.simpleButton_XoaPhong.Appearance.Options.UseForeColor = true;
            this.simpleButton_XoaPhong.Appearance.Options.UseImage = true;
            this.simpleButton_XoaPhong.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.simpleButton_XoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton_XoaPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_XoaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_XoaPhong.Location = new System.Drawing.Point(217, 290);
            this.simpleButton_XoaPhong.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton_XoaPhong.Name = "simpleButton_XoaPhong";
            this.simpleButton_XoaPhong.Size = new System.Drawing.Size(101, 33);
            this.simpleButton_XoaPhong.TabIndex = 3;
            this.simpleButton_XoaPhong.Text = "Xóa phòng";
            this.simpleButton_XoaPhong.Click += new System.EventHandler(this.simpleButton_XoaPhong_Click);
            // 
            // simpleButton_ThemPhong
            // 
            this.simpleButton_ThemPhong.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton_ThemPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_ThemPhong.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_ThemPhong.Appearance.Options.UseBackColor = true;
            this.simpleButton_ThemPhong.Appearance.Options.UseFont = true;
            this.simpleButton_ThemPhong.Appearance.Options.UseForeColor = true;
            this.simpleButton_ThemPhong.Appearance.Options.UseImage = true;
            this.simpleButton_ThemPhong.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.simpleButton_ThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton_ThemPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_ThemPhong.Location = new System.Drawing.Point(60, 290);
            this.simpleButton_ThemPhong.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton_ThemPhong.Name = "simpleButton_ThemPhong";
            this.simpleButton_ThemPhong.Size = new System.Drawing.Size(101, 33);
            this.simpleButton_ThemPhong.TabIndex = 4;
            this.simpleButton_ThemPhong.Text = "Thêm phòng";
            this.simpleButton_ThemPhong.Click += new System.EventHandler(this.simpleButton_ThemPhong_Click);
            // 
            // DieuChinhDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::G2_QLKS.Properties.Resources.backrounđanhmucphong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 411);
            this.Controls.Add(this.simpleButton_ThemPhong);
            this.Controls.Add(this.simpleButton_XoaPhong);
            this.Controls.Add(this.simpleButton_HuyBo);
            this.Controls.Add(this.dataGridView_DanhMucPhong);
            this.Controls.Add(this.simpleButton_XacNhan);
            this.Controls.Add(this.label_DieuChinhDanhMucPhong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DieuChinhDanhMucPhong";
            this.Text = "Điều chỉnh danh mục phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhMucPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DieuChinhDanhMucPhong;
        private DevExpress.XtraEditors.SimpleButton simpleButton_XacNhan;
        private System.Windows.Forms.DataGridView dataGridView_DanhMucPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GhiChu;
        private DevExpress.XtraEditors.SimpleButton simpleButton_HuyBo;
        private DevExpress.XtraEditors.SimpleButton simpleButton_XoaPhong;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ThemPhong;
    }
}