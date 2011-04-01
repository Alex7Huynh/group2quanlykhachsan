namespace QLKS_5Star
{
    partial class frmManHinhChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbc_chucNangChinh = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbgc_quanLyPhong = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.lbl_xoaPhong = new System.Windows.Forms.Label();
            this.lbl_themPhong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_themPhong = new System.Windows.Forms.Button();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc_chucNangChinh)).BeginInit();
            this.nbc_chucNangChinh.SuspendLayout();
            this.nvbgc_quanLyPhong.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // nbc_chucNangChinh
            // 
            this.nbc_chucNangChinh.ActiveGroup = this.navBarGroup1;
            this.nbc_chucNangChinh.BackColor = System.Drawing.SystemColors.Control;
            this.nbc_chucNangChinh.ContentButtonHint = null;
            this.nbc_chucNangChinh.Controls.Add(this.nvbgc_quanLyPhong);
            this.nbc_chucNangChinh.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.nbc_chucNangChinh.Location = new System.Drawing.Point(0, 27);
            this.nbc_chucNangChinh.Name = "nbc_chucNangChinh";
            this.nbc_chucNangChinh.OptionsNavPane.ExpandedWidth = 139;
            this.nbc_chucNangChinh.Size = new System.Drawing.Size(129, 388);
            this.nbc_chucNangChinh.TabIndex = 1;
            this.nbc_chucNangChinh.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý phòng";
            this.navBarGroup1.ControlContainer = this.nvbgc_quanLyPhong;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 193;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nvbgc_quanLyPhong
            // 
            this.nvbgc_quanLyPhong.Controls.Add(this.lbl_xoaPhong);
            this.nvbgc_quanLyPhong.Controls.Add(this.lbl_themPhong);
            this.nvbgc_quanLyPhong.Controls.Add(this.button1);
            this.nvbgc_quanLyPhong.Controls.Add(this.btn_themPhong);
            this.nvbgc_quanLyPhong.Name = "nvbgc_quanLyPhong";
            this.nvbgc_quanLyPhong.Size = new System.Drawing.Size(125, 191);
            this.nvbgc_quanLyPhong.TabIndex = 0;
            // 
            // lbl_xoaPhong
            // 
            this.lbl_xoaPhong.AutoSize = true;
            this.lbl_xoaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_xoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xoaPhong.Location = new System.Drawing.Point(28, 152);
            this.lbl_xoaPhong.Name = "lbl_xoaPhong";
            this.lbl_xoaPhong.Size = new System.Drawing.Size(68, 13);
            this.lbl_xoaPhong.TabIndex = 1;
            this.lbl_xoaPhong.Text = "Xóa phòng";
            // 
            // lbl_themPhong
            // 
            this.lbl_themPhong.AutoSize = true;
            this.lbl_themPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_themPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_themPhong.Location = new System.Drawing.Point(24, 69);
            this.lbl_themPhong.Name = "lbl_themPhong";
            this.lbl_themPhong.Size = new System.Drawing.Size(77, 13);
            this.lbl_themPhong.TabIndex = 1;
            this.lbl_themPhong.Text = "Thêm phòng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::QLKS_5Star.Properties.Resources.Button_xoaphong;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(38, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_themPhong
            // 
            this.btn_themPhong.BackColor = System.Drawing.Color.Transparent;
            this.btn_themPhong.BackgroundImage = global::QLKS_5Star.Properties.Resources.Button_themphong;
            this.btn_themPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_themPhong.FlatAppearance.BorderSize = 0;
            this.btn_themPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themPhong.Location = new System.Drawing.Point(38, 17);
            this.btn_themPhong.Name = "btn_themPhong";
            this.btn_themPhong.Size = new System.Drawing.Size(50, 49);
            this.btn_themPhong.TabIndex = 0;
            this.btn_themPhong.UseVisualStyleBackColor = false;
            this.btn_themPhong.Click += new System.EventHandler(this.btn_themPhong_Click);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS_5Star.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(588, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nbc_chucNangChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmManHinhChinh";
            this.Text = "Quan ly khach san 5-STAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc_chucNangChinh)).EndInit();
            this.nbc_chucNangChinh.ResumeLayout(false);
            this.nvbgc_quanLyPhong.ResumeLayout(false);
            this.nvbgc_quanLyPhong.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private DevExpress.XtraNavBar.NavBarControl nbc_chucNangChinh;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer nvbgc_quanLyPhong;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private System.Windows.Forms.Button btn_themPhong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_xoaPhong;
        private System.Windows.Forms.Label lbl_themPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

