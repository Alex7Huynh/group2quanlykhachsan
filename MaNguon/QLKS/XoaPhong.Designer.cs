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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaPhong));
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.clMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_DSPhong = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_ThuNho = new System.Windows.Forms.Button();
            this.BT_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg1
            // 
            this.dtg1.BackgroundColor = System.Drawing.Color.Black;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhong,
            this.clTenPhong,
            this.clLoaiPhong,
            this.clGhiChu,
            this.clTinhTrang});
            this.dtg1.EnableHeadersVisualStyles = false;
            this.dtg1.Location = new System.Drawing.Point(192, 309);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(755, 418);
            this.dtg1.TabIndex = 1;
            this.dtg1.Paint += new System.Windows.Forms.PaintEventHandler(this.dtg1_Paint);
            // 
            // clMaPhong
            // 
            this.clMaPhong.HeaderText = "Mã phòng";
            this.clMaPhong.Name = "clMaPhong";
            this.clMaPhong.Width = 110;
            // 
            // clTenPhong
            // 
            this.clTenPhong.HeaderText = "Tên phòng";
            this.clTenPhong.Name = "clTenPhong";
            this.clTenPhong.Width = 180;
            // 
            // clLoaiPhong
            // 
            this.clLoaiPhong.HeaderText = "Loại phòng";
            this.clLoaiPhong.Name = "clLoaiPhong";
            this.clLoaiPhong.Width = 120;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Width = 160;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "Tình trạng";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 135;
            // 
            // LB_DSPhong
            // 
            this.LB_DSPhong.AutoSize = true;
            this.LB_DSPhong.BackColor = System.Drawing.Color.White;
            this.LB_DSPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_DSPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_DSPhong.Location = new System.Drawing.Point(40, 33);
            this.LB_DSPhong.Name = "LB_DSPhong";
            this.LB_DSPhong.Size = new System.Drawing.Size(135, 17);
            this.LB_DSPhong.TabIndex = 1;
            this.LB_DSPhong.Text = "Danh sách phòng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(75, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.Leave += new System.EventHandler(this.btnXoa_Leave);
            this.btnXoa.Enter += new System.EventHandler(this.btnXoa_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(262, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 53);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Hủy bỏ";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.Leave += new System.EventHandler(this.btnXoa_Leave);
            this.btnThoat.Enter += new System.EventHandler(this.btnXoa_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHXoaPhong;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 720);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BT_ThuNho
            // 
            this.BT_ThuNho.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_ThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThuNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_ThuNho.ForeColor = System.Drawing.Color.Snow;
            this.BT_ThuNho.Location = new System.Drawing.Point(906, 5);
            this.BT_ThuNho.Name = "BT_ThuNho";
            this.BT_ThuNho.Size = new System.Drawing.Size(84, 44);
            this.BT_ThuNho.TabIndex = 104;
            this.BT_ThuNho.Text = "Thu nhỏ";
            this.BT_ThuNho.UseVisualStyleBackColor = false;
            this.BT_ThuNho.Click += new System.EventHandler(this.BT_ThuNho_Click);
            this.BT_ThuNho.Leave += new System.EventHandler(this.BT_ThuNho_Leave);
            this.BT_ThuNho.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // BT_Thoat
            // 
            this.BT_Thoat.BackColor = System.Drawing.Color.DarkRed;
            this.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Thoat.ForeColor = System.Drawing.Color.Snow;
            this.BT_Thoat.Location = new System.Drawing.Point(997, 5);
            this.BT_Thoat.Name = "BT_Thoat";
            this.BT_Thoat.Size = new System.Drawing.Size(84, 44);
            this.BT_Thoat.TabIndex = 105;
            this.BT_Thoat.Text = "Thoát";
            this.BT_Thoat.UseVisualStyleBackColor = false;
            this.BT_Thoat.Click += new System.EventHandler(this.BT_Thoat_Click);
            this.BT_Thoat.Leave += new System.EventHandler(this.BT_Thoat_Leave);
            this.BT_Thoat.Enter += new System.EventHandler(this.BT_ThuNho_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LB_DSPhong);
            this.panel1.Location = new System.Drawing.Point(192, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 84);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Location = new System.Drawing.Point(521, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 88);
            this.panel2.TabIndex = 107;
            // 
            // XoaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_ThuNho);
            this.Controls.Add(this.BT_Thoat);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XoaPhong";
            this.Text = "XoaPhong";
            this.Load += new System.EventHandler(this.XoaPhong_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XoaPhong_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Label LB_DSPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.Button BT_ThuNho;
        private System.Windows.Forms.Button BT_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}