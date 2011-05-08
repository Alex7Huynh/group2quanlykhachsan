namespace QLKS
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
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.PB_BookRoom = new System.Windows.Forms.PictureBox();
            this.PB_Customer = new System.Windows.Forms.PictureBox();
            this.PB_Tick = new System.Windows.Forms.PictureBox();
            this.PB_Room = new System.Windows.Forms.PictureBox();
            this.PB_Fix = new System.Windows.Forms.PictureBox();
            this.PB_Delete = new System.Windows.Forms.PictureBox();
            this.PB_Add = new System.Windows.Forms.PictureBox();
            this.BT_TCKH = new System.Windows.Forms.Button();
            this.BT_BCDoanhThu = new System.Windows.Forms.Button();
            this.BT_DatPhong = new System.Windows.Forms.Button();
            this.BT_TCPhieuThue = new System.Windows.Forms.Button();
            this.BT_TCPhong = new System.Windows.Forms.Button();
            this.BT_SuaPhong = new System.Windows.Forms.Button();
            this.BT_XoaPhong = new System.Windows.Forms.Button();
            this.BT_ThemPhong = new System.Windows.Forms.Button();
            this.PB_MainMenu = new System.Windows.Forms.PictureBox();
            this.PB_MoneyReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BookRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MoneyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.BackColor = System.Drawing.Color.DarkRed;
            this.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(983, 2);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 101;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(894, 2);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(84, 44);
            this.BT_ThuNho.TabIndex = 100;
            this.BT_ThuNho.Text = "Thu nhỏ";
            this.BT_ThuNho.UseVisualStyleBackColor = false;
            this.BT_ThuNho.Click += new System.EventHandler(this.BT_ThuNho_Click);
            this.BT_ThuNho.Leave += new System.EventHandler(this.BT_ThuNho_Leave);
            this.BT_ThuNho.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // PB_BookRoom
            // 
            this.PB_BookRoom.BackgroundImage = global::QLKS.Properties.Resources.bookroom;
            this.PB_BookRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_BookRoom.Location = new System.Drawing.Point(722, 281);
            this.PB_BookRoom.Name = "PB_BookRoom";
            this.PB_BookRoom.Size = new System.Drawing.Size(39, 38);
            this.PB_BookRoom.TabIndex = 108;
            this.PB_BookRoom.TabStop = false;
            this.PB_BookRoom.Click += new System.EventHandler(this.PB_DatPhong_Click);
            this.PB_BookRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_BookRoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Customer
            // 
            this.PB_Customer.BackgroundImage = global::QLKS.Properties.Resources.customer;
            this.PB_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Customer.Location = new System.Drawing.Point(503, 369);
            this.PB_Customer.Name = "PB_Customer";
            this.PB_Customer.Size = new System.Drawing.Size(39, 38);
            this.PB_Customer.TabIndex = 107;
            this.PB_Customer.TabStop = false;
            this.PB_Customer.Click += new System.EventHandler(this.BT_TCKH_Click);
            this.PB_Customer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Customer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Tick
            // 
            this.PB_Tick.BackgroundImage = global::QLKS.Properties.Resources.tick;
            this.PB_Tick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Tick.Location = new System.Drawing.Point(503, 326);
            this.PB_Tick.Name = "PB_Tick";
            this.PB_Tick.Size = new System.Drawing.Size(39, 38);
            this.PB_Tick.TabIndex = 106;
            this.PB_Tick.TabStop = false;
            this.PB_Tick.Click += new System.EventHandler(this.PB_TraCuuPhieuThue_Click);
            this.PB_Tick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Tick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Room
            // 
            this.PB_Room.BackgroundImage = global::QLKS.Properties.Resources.room;
            this.PB_Room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Room.Location = new System.Drawing.Point(503, 281);
            this.PB_Room.Name = "PB_Room";
            this.PB_Room.Size = new System.Drawing.Size(39, 38);
            this.PB_Room.TabIndex = 105;
            this.PB_Room.TabStop = false;
            this.PB_Room.Click += new System.EventHandler(this.PB_TraCuuPhong_Click);
            this.PB_Room.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Room.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Fix
            // 
            this.PB_Fix.BackgroundImage = global::QLKS.Properties.Resources.fix;
            this.PB_Fix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fix.Location = new System.Drawing.Point(285, 369);
            this.PB_Fix.Name = "PB_Fix";
            this.PB_Fix.Size = new System.Drawing.Size(39, 38);
            this.PB_Fix.TabIndex = 104;
            this.PB_Fix.TabStop = false;
            this.PB_Fix.Click += new System.EventHandler(this.PB_SuaPhong_Click);
            this.PB_Fix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Fix.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Delete
            // 
            this.PB_Delete.BackgroundImage = global::QLKS.Properties.Resources.subtract;
            this.PB_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Delete.Location = new System.Drawing.Point(285, 325);
            this.PB_Delete.Name = "PB_Delete";
            this.PB_Delete.Size = new System.Drawing.Size(39, 38);
            this.PB_Delete.TabIndex = 103;
            this.PB_Delete.TabStop = false;
            this.PB_Delete.Click += new System.EventHandler(this.PB_XoaPhong_Click);
            this.PB_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // PB_Add
            // 
            this.PB_Add.BackgroundImage = global::QLKS.Properties.Resources.add;
            this.PB_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Add.Location = new System.Drawing.Point(285, 281);
            this.PB_Add.Name = "PB_Add";
            this.PB_Add.Size = new System.Drawing.Size(39, 38);
            this.PB_Add.TabIndex = 102;
            this.PB_Add.TabStop = false;
            this.PB_Add.Click += new System.EventHandler(this.PB_ThemPhong_Click);
            this.PB_Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // BT_TCKH
            // 
            this.BT_TCKH.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCKH.BackgroundImage = global::QLKS.Properties.Resources.TCKhachHang;
            this.BT_TCKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCKH.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCKH.Location = new System.Drawing.Point(544, 371);
            this.BT_TCKH.Name = "BT_TCKH";
            this.BT_TCKH.Size = new System.Drawing.Size(119, 38);
            this.BT_TCKH.TabIndex = 6;
            this.BT_TCKH.UseVisualStyleBackColor = false;
            this.BT_TCKH.Click += new System.EventHandler(this.BT_TCKH_Click);
            this.BT_TCKH.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_TCKH.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_BCDoanhThu
            // 
            this.BT_BCDoanhThu.BackColor = System.Drawing.Color.Khaki;
            this.BT_BCDoanhThu.BackgroundImage = global::QLKS.Properties.Resources.BCdoanhthu;
            this.BT_BCDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_BCDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_BCDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_BCDoanhThu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_BCDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_BCDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_BCDoanhThu.ForeColor = System.Drawing.Color.Snow;
            this.BT_BCDoanhThu.Location = new System.Drawing.Point(980, 281);
            this.BT_BCDoanhThu.Name = "BT_BCDoanhThu";
            this.BT_BCDoanhThu.Size = new System.Drawing.Size(119, 38);
            this.BT_BCDoanhThu.TabIndex = 8;
            this.BT_BCDoanhThu.UseVisualStyleBackColor = false;
            this.BT_BCDoanhThu.Click += new System.EventHandler(this.PB_BaoCaoDoanhThu_Click);
            this.BT_BCDoanhThu.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_BCDoanhThu.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_DatPhong
            // 
            this.BT_DatPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_DatPhong.BackgroundImage = global::QLKS.Properties.Resources.datphong;
            this.BT_DatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_DatPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_DatPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_DatPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_DatPhong.Location = new System.Drawing.Point(763, 281);
            this.BT_DatPhong.Name = "BT_DatPhong";
            this.BT_DatPhong.Size = new System.Drawing.Size(119, 38);
            this.BT_DatPhong.TabIndex = 7;
            this.BT_DatPhong.UseVisualStyleBackColor = false;
            this.BT_DatPhong.Click += new System.EventHandler(this.PB_DatPhong_Click);
            this.BT_DatPhong.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_DatPhong.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_TCPhieuThue
            // 
            this.BT_TCPhieuThue.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCPhieuThue.BackgroundImage = global::QLKS.Properties.Resources.TCphieuthue;
            this.BT_TCPhieuThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCPhieuThue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCPhieuThue.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCPhieuThue.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCPhieuThue.Location = new System.Drawing.Point(544, 326);
            this.BT_TCPhieuThue.Name = "BT_TCPhieuThue";
            this.BT_TCPhieuThue.Size = new System.Drawing.Size(119, 38);
            this.BT_TCPhieuThue.TabIndex = 5;
            this.BT_TCPhieuThue.UseVisualStyleBackColor = false;
            this.BT_TCPhieuThue.Click += new System.EventHandler(this.PB_TraCuuPhieuThue_Click);
            this.BT_TCPhieuThue.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_TCPhieuThue.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_TCPhong
            // 
            this.BT_TCPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_TCPhong.BackgroundImage = global::QLKS.Properties.Resources.TCphong;
            this.BT_TCPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_TCPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_TCPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_TCPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_TCPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TCPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TCPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_TCPhong.Location = new System.Drawing.Point(544, 281);
            this.BT_TCPhong.Name = "BT_TCPhong";
            this.BT_TCPhong.Size = new System.Drawing.Size(119, 38);
            this.BT_TCPhong.TabIndex = 4;
            this.BT_TCPhong.UseVisualStyleBackColor = false;
            this.BT_TCPhong.Click += new System.EventHandler(this.PB_TraCuuPhong_Click);
            this.BT_TCPhong.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_TCPhong.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_SuaPhong
            // 
            this.BT_SuaPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_SuaPhong.BackgroundImage = global::QLKS.Properties.Resources.btnsuaphong;
            this.BT_SuaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_SuaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_SuaPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_SuaPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_SuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_SuaPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_SuaPhong.Location = new System.Drawing.Point(326, 371);
            this.BT_SuaPhong.Name = "BT_SuaPhong";
            this.BT_SuaPhong.Size = new System.Drawing.Size(119, 38);
            this.BT_SuaPhong.TabIndex = 3;
            this.BT_SuaPhong.UseVisualStyleBackColor = false;
            this.BT_SuaPhong.Click += new System.EventHandler(this.PB_SuaPhong_Click);
            this.BT_SuaPhong.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_SuaPhong.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_XoaPhong
            // 
            this.BT_XoaPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_XoaPhong.BackgroundImage = global::QLKS.Properties.Resources.btnxoaphong;
            this.BT_XoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_XoaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_XoaPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_XoaPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_XoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_XoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_XoaPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_XoaPhong.Location = new System.Drawing.Point(326, 326);
            this.BT_XoaPhong.Name = "BT_XoaPhong";
            this.BT_XoaPhong.Size = new System.Drawing.Size(119, 38);
            this.BT_XoaPhong.TabIndex = 2;
            this.BT_XoaPhong.UseVisualStyleBackColor = false;
            this.BT_XoaPhong.Click += new System.EventHandler(this.PB_XoaPhong_Click);
            this.BT_XoaPhong.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_XoaPhong.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // BT_ThemPhong
            // 
            this.BT_ThemPhong.BackColor = System.Drawing.Color.Khaki;
            this.BT_ThemPhong.BackgroundImage = global::QLKS.Properties.Resources.btthemphong;
            this.BT_ThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ThemPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_ThemPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BT_ThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThemPhong.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThemPhong.Location = new System.Drawing.Point(326, 281);
            this.BT_ThemPhong.Name = "BT_ThemPhong";
            this.BT_ThemPhong.Size = new System.Drawing.Size(119, 38);
            this.BT_ThemPhong.TabIndex = 1;
            this.BT_ThemPhong.UseVisualStyleBackColor = false;
            this.BT_ThemPhong.Click += new System.EventHandler(this.PB_ThemPhong_Click);
            this.BT_ThemPhong.Leave += new System.EventHandler(this.BT_ThemPhong_Leave);
            this.BT_ThemPhong.Enter += new System.EventHandler(this.BT_ThemPhong_Enter);
            // 
            // PB_MainMenu
            // 
            this.PB_MainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PB_MainMenu.Image = global::QLKS.Properties.Resources.Menu;
            this.PB_MainMenu.Location = new System.Drawing.Point(3, 26);
            this.PB_MainMenu.Name = "PB_MainMenu";
            this.PB_MainMenu.Size = new System.Drawing.Size(1123, 720);
            this.PB_MainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainMenu.TabIndex = 13;
            this.PB_MainMenu.TabStop = false;
            // 
            // PB_MoneyReport
            // 
            this.PB_MoneyReport.BackgroundImage = global::QLKS.Properties.Resources.MoneyReport;
            this.PB_MoneyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_MoneyReport.Location = new System.Drawing.Point(939, 281);
            this.PB_MoneyReport.Name = "PB_MoneyReport";
            this.PB_MoneyReport.Size = new System.Drawing.Size(39, 38);
            this.PB_MoneyReport.TabIndex = 109;
            this.PB_MoneyReport.TabStop = false;
            this.PB_MoneyReport.Click += new System.EventHandler(this.PB_BaoCaoDoanhThu_Click);
            this.PB_MoneyReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseDown);
            this.PB_MoneyReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Add_MouseUp);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.PB_MoneyReport);
            this.Controls.Add(this.PB_BookRoom);
            this.Controls.Add(this.PB_Customer);
            this.Controls.Add(this.PB_Tick);
            this.Controls.Add(this.PB_Room);
            this.Controls.Add(this.PB_Fix);
            this.Controls.Add(this.PB_Delete);
            this.Controls.Add(this.PB_Add);
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_BookRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MoneyReport)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_Add;
        private System.Windows.Forms.PictureBox PB_Delete;
        private System.Windows.Forms.PictureBox PB_Fix;
        private System.Windows.Forms.PictureBox PB_Room;
        private System.Windows.Forms.PictureBox PB_Tick;
        private System.Windows.Forms.PictureBox PB_Customer;
        private System.Windows.Forms.PictureBox PB_BookRoom;
        private System.Windows.Forms.PictureBox PB_MoneyReport;
    }
}