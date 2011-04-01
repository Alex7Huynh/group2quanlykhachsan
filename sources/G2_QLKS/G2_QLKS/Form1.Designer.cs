namespace G2_QLKS
{
    partial class ManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.groupControl_ChucNangChinh = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_DatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_DieuChinhDanhMucPhong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChucNangChinh)).BeginInit();
            this.groupControl_ChucNangChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_ChucNangChinh
            // 
            this.groupControl_ChucNangChinh.Controls.Add(this.simpleButton_DatPhong);
            this.groupControl_ChucNangChinh.Controls.Add(this.simpleButton_DieuChinhDanhMucPhong);
            this.groupControl_ChucNangChinh.Location = new System.Drawing.Point(3, 147);
            this.groupControl_ChucNangChinh.Name = "groupControl_ChucNangChinh";
            this.groupControl_ChucNangChinh.Size = new System.Drawing.Size(200, 528);
            this.groupControl_ChucNangChinh.TabIndex = 1;
            this.groupControl_ChucNangChinh.Text = "Chức năng chính";
            // 
            // simpleButton_DatPhong
            // 
            this.simpleButton_DatPhong.Image = global::G2_QLKS.Properties.Resources.Calendario;
            this.simpleButton_DatPhong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton_DatPhong.Location = new System.Drawing.Point(0, 94);
            this.simpleButton_DatPhong.Name = "simpleButton_DatPhong";
            this.simpleButton_DatPhong.Size = new System.Drawing.Size(195, 75);
            this.simpleButton_DatPhong.TabIndex = 3;
            this.simpleButton_DatPhong.Text = "Đặt phòng";
            this.simpleButton_DatPhong.Click += new System.EventHandler(this.simpleButton_DatPhong_Click);
            // 
            // simpleButton_DieuChinhDanhMucPhong
            // 
            this.simpleButton_DieuChinhDanhMucPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton_DieuChinhDanhMucPhong.Image = global::G2_QLKS.Properties.Resources.Home1;
            this.simpleButton_DieuChinhDanhMucPhong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton_DieuChinhDanhMucPhong.ImeMode = System.Windows.Forms.ImeMode.On;
            this.simpleButton_DieuChinhDanhMucPhong.Location = new System.Drawing.Point(0, 20);
            this.simpleButton_DieuChinhDanhMucPhong.Name = "simpleButton_DieuChinhDanhMucPhong";
            this.simpleButton_DieuChinhDanhMucPhong.Size = new System.Drawing.Size(195, 75);
            this.simpleButton_DieuChinhDanhMucPhong.TabIndex = 2;
            this.simpleButton_DieuChinhDanhMucPhong.Text = "Điều chỉnh danh mục phòng";
            this.simpleButton_DieuChinhDanhMucPhong.Click += new System.EventHandler(this.simpleButton_DieuChinhDanhMucPhong_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(206, 147);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1033, 528);
            this.panelControl1.TabIndex = 2;
            //this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1251, 672);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl_ChucNangChinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManHinhChinh";
            this.Text = "G2_QLKS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChucNangChinh)).EndInit();
            this.groupControl_ChucNangChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_ChucNangChinh;
        private DevExpress.XtraEditors.SimpleButton simpleButton_DatPhong;
        private DevExpress.XtraEditors.SimpleButton simpleButton_DieuChinhDanhMucPhong;
        private DevExpress.XtraEditors.PanelControl panelControl1;



    }
}

