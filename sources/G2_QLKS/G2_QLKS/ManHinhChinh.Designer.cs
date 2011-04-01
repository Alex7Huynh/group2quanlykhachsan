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
            this.simpleButton_DieuChinhDanhMucPhong = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroup_QuanLyPhong = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.simpleButton_DatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.simpleButton_ThongTinPhong = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroup_QuanLyThuePhong = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup_TraCuu = new DevExpress.XtraNavBar.NavBarGroup();
            this.toolStrip_ToolBarChinh = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Truoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sau = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ViewThanhChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_HelpDiaglog = new System.Windows.Forms.ToolStripMenuItem();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            this.navBarGroupControlContainer2.SuspendLayout();
            this.navBarGroupControlContainer3.SuspendLayout();
            this.toolStrip_ToolBarChinh.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton_DieuChinhDanhMucPhong
            // 
            this.simpleButton_DieuChinhDanhMucPhong.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.simpleButton_DieuChinhDanhMucPhong.Appearance.Options.UseBackColor = true;
            this.simpleButton_DieuChinhDanhMucPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton_DieuChinhDanhMucPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_DieuChinhDanhMucPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_DieuChinhDanhMucPhong.Image = global::G2_QLKS.Properties.Resources.Home1;
            this.simpleButton_DieuChinhDanhMucPhong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton_DieuChinhDanhMucPhong.ImeMode = System.Windows.Forms.ImeMode.On;
            this.simpleButton_DieuChinhDanhMucPhong.Location = new System.Drawing.Point(-1, 0);
            this.simpleButton_DieuChinhDanhMucPhong.Name = "simpleButton_DieuChinhDanhMucPhong";
            this.simpleButton_DieuChinhDanhMucPhong.Size = new System.Drawing.Size(195, 75);
            this.simpleButton_DieuChinhDanhMucPhong.TabIndex = 2;
            this.simpleButton_DieuChinhDanhMucPhong.Text = "Điều chỉnh danh mục phòng";
            this.simpleButton_DieuChinhDanhMucPhong.Click += new System.EventHandler(this.simpleButton_DieuChinhDanhMucPhong_Click);
            // 
            // navBarGroup_QuanLyPhong
            // 
            this.navBarGroup_QuanLyPhong.Caption = "Quản lý phòng";
            this.navBarGroup_QuanLyPhong.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup_QuanLyPhong.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag;
            this.navBarGroup_QuanLyPhong.Expanded = true;
            this.navBarGroup_QuanLyPhong.GroupClientHeight = 75;
            this.navBarGroup_QuanLyPhong.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup_QuanLyPhong.Name = "navBarGroup_QuanLyPhong";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.simpleButton_DieuChinhDanhMucPhong);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(195, 73);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroup_QuanLyPhong;
            this.navBarControl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.navBarControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBarControl.ContentButtonHint = null;
            this.navBarControl.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_QuanLyPhong,
            this.navBarGroup_QuanLyThuePhong,
            this.navBarGroup_TraCuu});
            this.navBarControl.Location = new System.Drawing.Point(0, 49);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl.Size = new System.Drawing.Size(199, 317);
            this.navBarControl.TabIndex = 4;
            this.navBarControl.Text = "navBarControl1";
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Controls.Add(this.simpleButton_DatPhong);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(195, 78);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // simpleButton_DatPhong
            // 
            this.simpleButton_DatPhong.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.simpleButton_DatPhong.Appearance.Options.UseBackColor = true;
            this.simpleButton_DatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton_DatPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_DatPhong.Image = global::G2_QLKS.Properties.Resources.Calendario;
            this.simpleButton_DatPhong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton_DatPhong.ImeMode = System.Windows.Forms.ImeMode.On;
            this.simpleButton_DatPhong.Location = new System.Drawing.Point(-1, 0);
            this.simpleButton_DatPhong.Name = "simpleButton_DatPhong";
            this.simpleButton_DatPhong.Size = new System.Drawing.Size(195, 75);
            this.simpleButton_DatPhong.TabIndex = 3;
            this.simpleButton_DatPhong.Text = "Đặt phòng";
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Controls.Add(this.simpleButton_ThongTinPhong);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(195, 77);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // simpleButton_ThongTinPhong
            // 
            this.simpleButton_ThongTinPhong.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.simpleButton_ThongTinPhong.Appearance.Options.UseBackColor = true;
            this.simpleButton_ThongTinPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton_ThongTinPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton_ThongTinPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton_ThongTinPhong.Image = global::G2_QLKS.Properties.Resources.book_cd_vide;
            this.simpleButton_ThongTinPhong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton_ThongTinPhong.ImeMode = System.Windows.Forms.ImeMode.On;
            this.simpleButton_ThongTinPhong.Location = new System.Drawing.Point(0, -1);
            this.simpleButton_ThongTinPhong.Name = "simpleButton_ThongTinPhong";
            this.simpleButton_ThongTinPhong.Size = new System.Drawing.Size(195, 75);
            this.simpleButton_ThongTinPhong.TabIndex = 7;
            this.simpleButton_ThongTinPhong.Text = "Thông tin phòng";
            // 
            // navBarGroup_QuanLyThuePhong
            // 
            this.navBarGroup_QuanLyThuePhong.Caption = "Quản lý thuê phòng";
            this.navBarGroup_QuanLyThuePhong.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup_QuanLyThuePhong.Expanded = true;
            this.navBarGroup_QuanLyThuePhong.GroupClientHeight = 80;
            this.navBarGroup_QuanLyThuePhong.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup_QuanLyThuePhong.Name = "navBarGroup_QuanLyThuePhong";
            // 
            // navBarGroup_TraCuu
            // 
            this.navBarGroup_TraCuu.Caption = "Tra cứu";
            this.navBarGroup_TraCuu.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup_TraCuu.Expanded = true;
            this.navBarGroup_TraCuu.GroupClientHeight = 79;
            this.navBarGroup_TraCuu.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup_TraCuu.Name = "navBarGroup_TraCuu";
            // 
            // toolStrip_ToolBarChinh
            // 
            this.toolStrip_ToolBarChinh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip_ToolBarChinh.CanOverflow = false;
            this.toolStrip_ToolBarChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Truoc,
            this.toolStripButton_Sau});
            this.toolStrip_ToolBarChinh.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_ToolBarChinh.Name = "toolStrip_ToolBarChinh";
            this.toolStrip_ToolBarChinh.Size = new System.Drawing.Size(1251, 25);
            this.toolStrip_ToolBarChinh.TabIndex = 5;
            this.toolStrip_ToolBarChinh.Text = "ToolBar Chính";
            // 
            // toolStripButton_Truoc
            // 
            this.toolStripButton_Truoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Truoc.Image = global::G2_QLKS.Properties.Resources.Arrow_Right;
            this.toolStripButton_Truoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_Truoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Truoc.Name = "toolStripButton_Truoc";
            this.toolStripButton_Truoc.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Truoc.Text = "Trước";
            this.toolStripButton_Truoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_Truoc.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton_Truoc.ToolTipText = "Trước";
            this.toolStripButton_Truoc.Click += new System.EventHandler(this.toolStripButton_Truoc_Click);
            // 
            // toolStripButton_Sau
            // 
            this.toolStripButton_Sau.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Sau.Image = global::G2_QLKS.Properties.Resources.Arrow_Left;
            this.toolStripButton_Sau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_Sau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sau.Name = "toolStripButton_Sau";
            this.toolStripButton_Sau.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Sau.Text = "Sau";
            this.toolStripButton_Sau.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton_Sau.ToolTipText = "Sau";
            this.toolStripButton_Sau.Click += new System.EventHandler(this.toolStripButton_Sau_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Edit,
            this.toolStripMenuItem_View,
            this.toolStripMenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem_File.Text = "File";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem_Exit.Text = "Exit";
            this.toolStripMenuItem_Exit.Click += new System.EventHandler(this.toolStripMenuItem_Exit_Click);
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem_Edit.Text = "Edit";
            // 
            // toolStripMenuItem_View
            // 
            this.toolStripMenuItem_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ViewToolbar,
            this.toolStripMenuItem_ViewThanhChucNang});
            this.toolStripMenuItem_View.Name = "toolStripMenuItem_View";
            this.toolStripMenuItem_View.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem_View.Text = "View";
            // 
            // toolStripMenuItem_ViewToolbar
            // 
            this.toolStripMenuItem_ViewToolbar.Checked = true;
            this.toolStripMenuItem_ViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_ViewToolbar.Name = "toolStripMenuItem_ViewToolbar";
            this.toolStripMenuItem_ViewToolbar.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem_ViewToolbar.Text = "Toolbar";
            this.toolStripMenuItem_ViewToolbar.Click += new System.EventHandler(this.toolStripMenuItem_ViewToolbar_Click);
            // 
            // toolStripMenuItem_ViewThanhChucNang
            // 
            this.toolStripMenuItem_ViewThanhChucNang.Checked = true;
            this.toolStripMenuItem_ViewThanhChucNang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_ViewThanhChucNang.Name = "toolStripMenuItem_ViewThanhChucNang";
            this.toolStripMenuItem_ViewThanhChucNang.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem_ViewThanhChucNang.Text = "Thanh chức năng";
            this.toolStripMenuItem_ViewThanhChucNang.Click += new System.EventHandler(this.toolStripMenuItem_ViewThanhChucNang_Click);
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_About,
            this.toolStripMenuItem_HelpDiaglog});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem_Help.Text = "Help";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem_About.Text = "About";
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.toolStripMenuItem_About_Click);
            // 
            // toolStripMenuItem_HelpDiaglog
            // 
            this.toolStripMenuItem_HelpDiaglog.Name = "toolStripMenuItem_HelpDiaglog";
            this.toolStripMenuItem_HelpDiaglog.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem_HelpDiaglog.Text = "Help";
            this.toolStripMenuItem_HelpDiaglog.Click += new System.EventHandler(this.toolStripMenuItem_HelpDiaglog_Click);
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::G2_QLKS.Properties.Resources.libertador_paracas04low;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 672);
            this.Controls.Add(this.toolStrip_ToolBarChinh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.navBarControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManHinhChinh";
            this.Text = "G2_QLKS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            this.navBarGroupControlContainer2.ResumeLayout(false);
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.toolStrip_ToolBarChinh.ResumeLayout(false);
            this.toolStrip_ToolBarChinh.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton_DieuChinhDanhMucPhong;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_QuanLyPhong;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_QuanLyThuePhong;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_DatPhong;
        private System.Windows.Forms.ToolStrip toolStrip_ToolBarChinh;
        private System.Windows.Forms.ToolStripButton toolStripButton_Truoc;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_View;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_HelpDiaglog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_TraCuu;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ThongTinPhong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ViewToolbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ViewThanhChucNang;



    }
}

