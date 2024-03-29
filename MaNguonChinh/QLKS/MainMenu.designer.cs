﻿namespace QLKS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BT_SoDoPhieuThue = new System.Windows.Forms.Button();
            this.BT_TCKH = new System.Windows.Forms.Button();
            this.BT_BCDoanhThu = new System.Windows.Forms.Button();
            this.BT_DatPhong = new System.Windows.Forms.Button();
            this.BT_TCPhieuThue = new System.Windows.Forms.Button();
            this.BT_TCPhong = new System.Windows.Forms.Button();
            this.BT_SuaPhong = new System.Windows.Forms.Button();
            this.BT_XoaPhong = new System.Windows.Forms.Button();
            this.BT_ThemPhong = new System.Windows.Forms.Button();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.PB_MainMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_SoDoPhieuThue
            // 
            this.BT_SoDoPhieuThue.BackgroundImage = global::QLKS.Properties.Resources.ButtonMatrixTick;
            this.BT_SoDoPhieuThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_SoDoPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_SoDoPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SoDoPhieuThue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_SoDoPhieuThue.ForeColor = System.Drawing.Color.Snow;
            this.BT_SoDoPhieuThue.Location = new System.Drawing.Point(541, 368);
            this.BT_SoDoPhieuThue.Name = "BT_SoDoPhieuThue";
            this.BT_SoDoPhieuThue.Size = new System.Drawing.Size(188, 47);
            this.BT_SoDoPhieuThue.TabIndex = 102;
            this.BT_SoDoPhieuThue.UseVisualStyleBackColor = true;
            this.BT_SoDoPhieuThue.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_SoDoPhieuThue.Click += new System.EventHandler(this.PB_DatPhong_Click);
            this.BT_SoDoPhieuThue.MouseEnter += new System.EventHandler(this.BT_SoDoPhieuThue_MouseEnter);
            // 
            // BT_TCKH
            // 
            this.BT_TCKH.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCKH.BackgroundImage = global::QLKS.Properties.Resources.ButtonCustomer;
            this.BT_TCKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCKH.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCKH.Location = new System.Drawing.Point(307, 423);
            this.BT_TCKH.Name = "BT_TCKH";
            this.BT_TCKH.Size = new System.Drawing.Size(188, 47);
            this.BT_TCKH.TabIndex = 6;
            this.BT_TCKH.UseVisualStyleBackColor = false;
            this.BT_TCKH.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_TCKH.Click += new System.EventHandler(this.BT_TCKH_Click);
            this.BT_TCKH.MouseEnter += new System.EventHandler(this.BT_TCKH_MouseEnter);
            // 
            // BT_BCDoanhThu
            // 
            this.BT_BCDoanhThu.BackColor = System.Drawing.Color.Khaki;
            this.BT_BCDoanhThu.BackgroundImage = global::QLKS.Properties.Resources.ButtonMoneyReport;
            this.BT_BCDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_BCDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_BCDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_BCDoanhThu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_BCDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_BCDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_BCDoanhThu.ForeColor = System.Drawing.Color.Snow;
            this.BT_BCDoanhThu.Location = new System.Drawing.Point(773, 314);
            this.BT_BCDoanhThu.Name = "BT_BCDoanhThu";
            this.BT_BCDoanhThu.Size = new System.Drawing.Size(188, 47);
            this.BT_BCDoanhThu.TabIndex = 8;
            this.BT_BCDoanhThu.UseVisualStyleBackColor = false;
            this.BT_BCDoanhThu.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_BCDoanhThu.Click += new System.EventHandler(this.PB_BaoCaoDoanhThu_Click);
            this.BT_BCDoanhThu.MouseEnter += new System.EventHandler(this.BT_BCDoanhThu_MouseEnter);
            // 
            // BT_DatPhong
            // 
            this.BT_DatPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_DatPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonChecked;
            this.BT_DatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_DatPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_DatPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_DatPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_DatPhong.Location = new System.Drawing.Point(541, 314);
            this.BT_DatPhong.Name = "BT_DatPhong";
            this.BT_DatPhong.Size = new System.Drawing.Size(188, 47);
            this.BT_DatPhong.TabIndex = 7;
            this.BT_DatPhong.UseVisualStyleBackColor = false;
            this.BT_DatPhong.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_DatPhong.Click += new System.EventHandler(this.button1_Click);
            this.BT_DatPhong.MouseEnter += new System.EventHandler(this.BT_DatPhong_MouseEnter);
            // 
            // BT_TCPhieuThue
            // 
            this.BT_TCPhieuThue.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCPhieuThue.BackgroundImage = global::QLKS.Properties.Resources.ButtonTick;
            this.BT_TCPhieuThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCPhieuThue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCPhieuThue.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCPhieuThue.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCPhieuThue.Location = new System.Drawing.Point(307, 368);
            this.BT_TCPhieuThue.Name = "BT_TCPhieuThue";
            this.BT_TCPhieuThue.Size = new System.Drawing.Size(188, 47);
            this.BT_TCPhieuThue.TabIndex = 5;
            this.BT_TCPhieuThue.UseVisualStyleBackColor = false;
            this.BT_TCPhieuThue.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_TCPhieuThue.Click += new System.EventHandler(this.PB_TraCuuPhieuThue_Click);
            this.BT_TCPhieuThue.MouseEnter += new System.EventHandler(this.BT_TCPhieuThue_MouseEnter);
            // 
            // BT_TCPhong
            // 
            this.BT_TCPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonRoom;
            this.BT_TCPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCPhong.Location = new System.Drawing.Point(307, 314);
            this.BT_TCPhong.Name = "BT_TCPhong";
            this.BT_TCPhong.Size = new System.Drawing.Size(188, 47);
            this.BT_TCPhong.TabIndex = 4;
            this.BT_TCPhong.UseVisualStyleBackColor = false;
            this.BT_TCPhong.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_TCPhong.Click += new System.EventHandler(this.PB_TraCuuPhong_Click);
            this.BT_TCPhong.MouseEnter += new System.EventHandler(this.BT_TCPhong_MouseEnter);
            // 
            // BT_SuaPhong
            // 
            this.BT_SuaPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_SuaPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonFix;
            this.BT_SuaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_SuaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_SuaPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_SuaPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_SuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_SuaPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_SuaPhong.Location = new System.Drawing.Point(73, 423);
            this.BT_SuaPhong.Name = "BT_SuaPhong";
            this.BT_SuaPhong.Size = new System.Drawing.Size(188, 47);
            this.BT_SuaPhong.TabIndex = 3;
            this.BT_SuaPhong.UseVisualStyleBackColor = false;
            this.BT_SuaPhong.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_SuaPhong.Click += new System.EventHandler(this.PB_SuaPhong_Click);
            this.BT_SuaPhong.MouseEnter += new System.EventHandler(this.BT_SuaPhong_MouseEnter);
            // 
            // BT_XoaPhong
            // 
            this.BT_XoaPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_XoaPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonDelete;
            this.BT_XoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_XoaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_XoaPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_XoaPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_XoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_XoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_XoaPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_XoaPhong.Location = new System.Drawing.Point(73, 368);
            this.BT_XoaPhong.Name = "BT_XoaPhong";
            this.BT_XoaPhong.Size = new System.Drawing.Size(188, 47);
            this.BT_XoaPhong.TabIndex = 2;
            this.BT_XoaPhong.UseVisualStyleBackColor = false;
            this.BT_XoaPhong.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_XoaPhong.Click += new System.EventHandler(this.PB_XoaPhong_Click);
            this.BT_XoaPhong.MouseEnter += new System.EventHandler(this.BT_XoaPhong_MouseEnter);
            // 
            // BT_ThemPhong
            // 
            this.BT_ThemPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_ThemPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonAdd;
            this.BT_ThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ThemPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_ThemPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_ThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThemPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThemPhong.Location = new System.Drawing.Point(73, 314);
            this.BT_ThemPhong.Name = "BT_ThemPhong";
            this.BT_ThemPhong.Size = new System.Drawing.Size(188, 47);
            this.BT_ThemPhong.TabIndex = 1;
            this.BT_ThemPhong.UseVisualStyleBackColor = false;
            this.BT_ThemPhong.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_ThemPhong.Click += new System.EventHandler(this.PB_ThemPhong_Click);
            this.BT_ThemPhong.MouseEnter += new System.EventHandler(this.BT_ThemPhong_MouseEnter);
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.BackgroundImage = global::QLKS.Properties.Resources.ButtonMinimize;
            this.BT_ThuNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(870, 3);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(60, 36);
            this.BT_ThuNho.TabIndex = 100;
            this.BT_ThuNho.UseVisualStyleBackColor = false;
            this.BT_ThuNho.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_ThuNho.Click += new System.EventHandler(this.BT_ThuNho_Click);
            this.BT_ThuNho.MouseEnter += new System.EventHandler(this.BT_ThuNho_MouseEnter);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.BackColor = System.Drawing.Color.DarkRed;
            this.BT_Thoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonExit;
            this.BT_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(940, 3);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(60, 36);
            this.BT_Thoat.TabIndex = 101;
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.MouseLeave += new System.EventHandler(this.BT_ThemPhong_MouseLeave);
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.MouseEnter += new System.EventHandler(this.BT_Thoat_MouseEnter);
            // 
            // PB_MainMenu
            // 
            this.PB_MainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PB_MainMenu.Image = global::QLKS.Properties.Resources.MainMenu;
            this.PB_MainMenu.Location = new System.Drawing.Point(0, 21);
            this.PB_MainMenu.Name = "PB_MainMenu";
            this.PB_MainMenu.Size = new System.Drawing.Size(1024, 768);
            this.PB_MainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainMenu.TabIndex = 13;
            this.PB_MainMenu.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 784);
            this.Controls.Add(this.BT_SoDoPhieuThue);
            this.Controls.Add(this.BT_TCKH);
            this.Controls.Add(this.BT_BCDoanhThu);
            this.Controls.Add(this.BT_DatPhong);
            this.Controls.Add(this.BT_TCPhieuThue);
            this.Controls.Add(this.BT_TCPhong);
            this.Controls.Add(this.BT_SuaPhong);
            this.Controls.Add(this.BT_XoaPhong);
            this.Controls.Add(this.BT_ThemPhong);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.PB_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MainMenu;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_ThemPhong;
        private System.Windows.Forms.Button BT_XoaPhong;
        private System.Windows.Forms.Button BT_SuaPhong;
        private System.Windows.Forms.Button BT_TCPhong;
        private System.Windows.Forms.Button BT_TCPhieuThue;
        private System.Windows.Forms.Button BT_DatPhong;
        private System.Windows.Forms.Button BT_BCDoanhThu;
        private System.Windows.Forms.Button BT_TCKH;
        private System.Windows.Forms.Button BT_SoDoPhieuThue;
    }
}