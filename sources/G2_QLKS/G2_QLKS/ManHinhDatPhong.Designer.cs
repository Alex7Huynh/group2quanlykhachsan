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
            this.BT_QuayLai = new System.Windows.Forms.Button();
            this.BT_HuyBo = new System.Windows.Forms.Button();
            this.BT_XacNhan = new System.Windows.Forms.Button();
            this.ucDatPhong = new G2_QLKS.UCDatPhong();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
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
            this.pictureBoxMain.Size = new System.Drawing.Size(1232, 771);
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
            this.labelDatPhong.Location = new System.Drawing.Point(494, 43);
            this.labelDatPhong.Name = "labelDatPhong";
            this.labelDatPhong.Size = new System.Drawing.Size(231, 48);
            this.labelDatPhong.TabIndex = 1;
            this.labelDatPhong.Text = "Đặt phòng";
            // 
            // BT_QuayLai
            // 
            this.BT_QuayLai.BackColor = System.Drawing.Color.Gray;
            this.BT_QuayLai.BackgroundImage = global::G2_QLKS.Properties.Resources.Arrow_Right;
            this.BT_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_QuayLai.Location = new System.Drawing.Point(29, 636);
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
            this.BT_HuyBo.Location = new System.Drawing.Point(1030, 647);
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
            this.BT_XacNhan.Location = new System.Drawing.Point(800, 647);
            this.BT_XacNhan.Name = "BT_XacNhan";
            this.BT_XacNhan.Size = new System.Drawing.Size(115, 37);
            this.BT_XacNhan.TabIndex = 15;
            this.BT_XacNhan.Text = "Xác nhận";
            this.BT_XacNhan.UseVisualStyleBackColor = true;
            this.BT_XacNhan.Click += new System.EventHandler(this.BT_XacNhan_Click);
            // 
            // ucDatPhong
            // 
            this.ucDatPhong.Location = new System.Drawing.Point(29, 94);
            this.ucDatPhong.Name = "ucDatPhong";
            this.ucDatPhong.Size = new System.Drawing.Size(1116, 536);
            this.ucDatPhong.TabIndex = 17;
            // 
            // ManHinhDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 703);
            this.Controls.Add(this.ucDatPhong);
            this.Controls.Add(this.BT_XacNhan);
            this.Controls.Add(this.BT_HuyBo);
            this.Controls.Add(this.BT_QuayLai);
            this.Controls.Add(this.labelDatPhong);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManHinhDatPhong";
            this.Opacity = 0.97;
            this.Text = "Màn hình đặt phòng";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelDatPhong;
        private System.Windows.Forms.Button BT_QuayLai;
        private System.Windows.Forms.Button BT_HuyBo;
        private System.Windows.Forms.Button BT_XacNhan;
        private UCDatPhong ucDatPhong;
    }
}