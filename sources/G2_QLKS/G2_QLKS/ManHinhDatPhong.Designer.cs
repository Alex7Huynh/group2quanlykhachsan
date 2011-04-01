namespace G2_QLKS
{
    partial class ManHinhDatPhong
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelDatPhong = new System.Windows.Forms.Label();
            this.domainUpDownThang = new System.Windows.Forms.DomainUpDown();
            this.labelThang = new DevExpress.XtraEditors.LabelControl();
            this.labelNam = new DevExpress.XtraEditors.LabelControl();
            this.domainUpDownNam = new System.Windows.Forms.DomainUpDown();
            this.labelTuan = new DevExpress.XtraEditors.LabelControl();
            this.domainUpDownTuan = new System.Windows.Forms.DomainUpDown();
            this.DTP_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.BT_QuayLai = new System.Windows.Forms.Button();
            this.BT_HuyBo = new System.Windows.Forms.Button();
            this.BT_XacNhan = new System.Windows.Forms.Button();
            this.BT_TimPhong = new System.Windows.Forms.Button();
            this.LB_NgayMuon = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.Image = global::G2_QLKS.Properties.Resources.datphong;
            this.pictureBoxMain.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(845, 561);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // labelDatPhong
            // 
            this.labelDatPhong.AutoSize = true;
            this.labelDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.labelDatPhong.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.labelDatPhong.ForeColor = System.Drawing.Color.Maroon;
            this.labelDatPhong.Location = new System.Drawing.Point(25, 43);
            this.labelDatPhong.Name = "labelDatPhong";
            this.labelDatPhong.Size = new System.Drawing.Size(231, 48);
            this.labelDatPhong.TabIndex = 1;
            this.labelDatPhong.Text = "Đặt phòng";
            // 
            // domainUpDownThang
            // 
            this.domainUpDownThang.Location = new System.Drawing.Point(691, 41);
            this.domainUpDownThang.Name = "domainUpDownThang";
            this.domainUpDownThang.Size = new System.Drawing.Size(120, 21);
            this.domainUpDownThang.TabIndex = 3;
            this.domainUpDownThang.SelectedItemChanged += new System.EventHandler(this.domainUpDownThang_SelectedItemChanged);
            // 
            // labelThang
            // 
            this.labelThang.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelThang.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelThang.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelThang.Appearance.Options.UseBackColor = true;
            this.labelThang.Appearance.Options.UseFont = true;
            this.labelThang.Appearance.Options.UseForeColor = true;
            this.labelThang.Location = new System.Drawing.Point(631, 46);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(46, 14);
            this.labelThang.TabIndex = 4;
            this.labelThang.Text = "Tháng: ";
            // 
            // labelNam
            // 
            this.labelNam.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelNam.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelNam.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelNam.Appearance.Options.UseBackColor = true;
            this.labelNam.Appearance.Options.UseFont = true;
            this.labelNam.Appearance.Options.UseForeColor = true;
            this.labelNam.Location = new System.Drawing.Point(636, 78);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(34, 14);
            this.labelNam.TabIndex = 5;
            this.labelNam.Text = "Năm: ";
            // 
            // domainUpDownNam
            // 
            this.domainUpDownNam.Location = new System.Drawing.Point(691, 74);
            this.domainUpDownNam.Name = "domainUpDownNam";
            this.domainUpDownNam.Size = new System.Drawing.Size(120, 21);
            this.domainUpDownNam.TabIndex = 6;
            this.domainUpDownNam.SelectedItemChanged += new System.EventHandler(this.domainUpDownNam_SelectedItemChanged);
            // 
            // labelTuan
            // 
            this.labelTuan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelTuan.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelTuan.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.labelTuan.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelTuan.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelTuan.Appearance.Options.UseBackColor = true;
            this.labelTuan.Appearance.Options.UseBorderColor = true;
            this.labelTuan.Appearance.Options.UseFont = true;
            this.labelTuan.Appearance.Options.UseForeColor = true;
            this.labelTuan.Location = new System.Drawing.Point(437, 46);
            this.labelTuan.Name = "labelTuan";
            this.labelTuan.Size = new System.Drawing.Size(34, 14);
            this.labelTuan.TabIndex = 7;
            this.labelTuan.Text = "Tuần:";
            // 
            // domainUpDownTuan
            // 
            this.domainUpDownTuan.Location = new System.Drawing.Point(490, 42);
            this.domainUpDownTuan.Name = "domainUpDownTuan";
            this.domainUpDownTuan.Size = new System.Drawing.Size(120, 21);
            this.domainUpDownTuan.TabIndex = 8;
            this.domainUpDownTuan.SelectedItemChanged += new System.EventHandler(this.domainUpDownTuan_SelectedItemChanged);
            // 
            // DTP_NgayMuon
            // 
            this.DTP_NgayMuon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DTP_NgayMuon.Location = new System.Drawing.Point(33, 202);
            this.DTP_NgayMuon.Name = "DTP_NgayMuon";
            this.DTP_NgayMuon.Size = new System.Drawing.Size(200, 22);
            this.DTP_NgayMuon.TabIndex = 12;
            this.DTP_NgayMuon.ValueChanged += new System.EventHandler(this.DTP_NgayMuon_ValueChanged);
            // 
            // BT_QuayLai
            // 
            this.BT_QuayLai.BackColor = System.Drawing.Color.Gray;
            this.BT_QuayLai.BackgroundImage = global::G2_QLKS.Properties.Resources.Arrow_Right;
            this.BT_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_QuayLai.Location = new System.Drawing.Point(30, 480);
            this.BT_QuayLai.Name = "BT_QuayLai";
            this.BT_QuayLai.Size = new System.Drawing.Size(80, 60);
            this.BT_QuayLai.TabIndex = 13;
            this.BT_QuayLai.UseVisualStyleBackColor = true;
            this.BT_QuayLai.Click += new System.EventHandler(this.BT_QuayLai_Click);
            // 
            // BT_HuyBo
            // 
            this.BT_HuyBo.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.BT_HuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_HuyBo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.BT_HuyBo.ForeColor = System.Drawing.Color.White;
            this.BT_HuyBo.Location = new System.Drawing.Point(671, 492);
            this.BT_HuyBo.Name = "BT_HuyBo";
            this.BT_HuyBo.Size = new System.Drawing.Size(115, 37);
            this.BT_HuyBo.TabIndex = 14;
            this.BT_HuyBo.Text = "Hủy bỏ";
            this.BT_HuyBo.UseVisualStyleBackColor = true;
            this.BT_HuyBo.Click += new System.EventHandler(this.BT_HuyBo_Click);
            // 
            // BT_XacNhan
            // 
            this.BT_XacNhan.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.BT_XacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_XacNhan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.BT_XacNhan.ForeColor = System.Drawing.Color.White;
            this.BT_XacNhan.Location = new System.Drawing.Point(495, 492);
            this.BT_XacNhan.Name = "BT_XacNhan";
            this.BT_XacNhan.Size = new System.Drawing.Size(115, 37);
            this.BT_XacNhan.TabIndex = 15;
            this.BT_XacNhan.Text = "Xác nhận";
            this.BT_XacNhan.UseVisualStyleBackColor = true;
            this.BT_XacNhan.Click += new System.EventHandler(this.BT_XacNhan_Click);
            // 
            // BT_TimPhong
            // 
            this.BT_TimPhong.BackgroundImage = global::G2_QLKS.Properties.Resources.btn;
            this.BT_TimPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TimPhong.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.BT_TimPhong.ForeColor = System.Drawing.Color.White;
            this.BT_TimPhong.Location = new System.Drawing.Point(74, 333);
            this.BT_TimPhong.Name = "BT_TimPhong";
            this.BT_TimPhong.Size = new System.Drawing.Size(115, 37);
            this.BT_TimPhong.TabIndex = 16;
            this.BT_TimPhong.Text = "Tìm phòng";
            this.BT_TimPhong.UseVisualStyleBackColor = true;
            // 
            // LB_NgayMuon
            // 
            this.LB_NgayMuon.AutoSize = true;
            this.LB_NgayMuon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LB_NgayMuon.ForeColor = System.Drawing.Color.Navy;
            this.LB_NgayMuon.Location = new System.Drawing.Point(35, 172);
            this.LB_NgayMuon.Name = "LB_NgayMuon";
            this.LB_NgayMuon.Size = new System.Drawing.Size(81, 14);
            this.LB_NgayMuon.TabIndex = 17;
            this.LB_NgayMuon.Text = "Ngày mượn:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(251, 121);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(560, 356);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ManHinhDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 555);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.LB_NgayMuon);
            this.Controls.Add(this.BT_TimPhong);
            this.Controls.Add(this.BT_XacNhan);
            this.Controls.Add(this.BT_HuyBo);
            this.Controls.Add(this.BT_QuayLai);
            this.Controls.Add(this.DTP_NgayMuon);
            this.Controls.Add(this.domainUpDownTuan);
            this.Controls.Add(this.labelTuan);
            this.Controls.Add(this.domainUpDownNam);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.domainUpDownThang);
            this.Controls.Add(this.labelDatPhong);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManHinhDatPhong";
            this.Opacity = 0.97;
            this.Text = "Màn hình đặt phòng";
            this.Load += new System.EventHandler(this.ManHinhDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelDatPhong;
        private System.Windows.Forms.DomainUpDown domainUpDownThang;
        private DevExpress.XtraEditors.LabelControl labelThang;
        private DevExpress.XtraEditors.LabelControl labelNam;
        private System.Windows.Forms.DomainUpDown domainUpDownNam;
        private DevExpress.XtraEditors.LabelControl labelTuan;
        private System.Windows.Forms.DomainUpDown domainUpDownTuan;
        private System.Windows.Forms.DateTimePicker DTP_NgayMuon;
        private System.Windows.Forms.Button BT_QuayLai;
        private System.Windows.Forms.Button BT_HuyBo;
        private System.Windows.Forms.Button BT_XacNhan;
        private System.Windows.Forms.Button BT_TimPhong;
        private System.Windows.Forms.Label LB_NgayMuon;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}