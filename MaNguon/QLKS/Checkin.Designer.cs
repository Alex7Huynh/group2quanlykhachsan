namespace QLKS
{
    partial class frmCheckin
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
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuThue = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnNhanHet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(17, 146);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(211, 45);
            this.txtCMND.TabIndex = 7;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonNhanPhong;
            this.btnNhanPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.Location = new System.Drawing.Point(444, 167);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(188, 47);
            this.btnNhanPhong.TabIndex = 9;
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            this.btnNhanPhong.MouseEnter += new System.EventHandler(this.btnNhanPhong_MouseEnter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonQuayLai;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(444, 269);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 47);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnThoat_MouseEnter);
            // 
            // dgvDanhSachPhieuThue
            // 
            this.dgvDanhSachPhieuThue.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.maPhieuThue,
            this.ngayThue,
            this.soNgayThue,
            this.tenKH});
            this.dgvDanhSachPhieuThue.Location = new System.Drawing.Point(18, 215);
            this.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue";
            this.dgvDanhSachPhieuThue.RowHeadersVisible = false;
            this.dgvDanhSachPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuThue.Size = new System.Drawing.Size(402, 157);
            this.dgvDanhSachPhieuThue.TabIndex = 12;
            // 
            // maPhong
            // 
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.Name = "maPhong";
            // 
            // maPhieuThue
            // 
            this.maPhieuThue.HeaderText = "Mã phiếu thuê";
            this.maPhieuThue.Name = "maPhieuThue";
            // 
            // ngayThue
            // 
            this.ngayThue.HeaderText = "Ngày thuê";
            this.ngayThue.Name = "ngayThue";
            // 
            // soNgayThue
            // 
            this.soNgayThue.HeaderText = "Số ngày thuê";
            this.soNgayThue.Name = "soNgayThue";
            // 
            // tenKH
            // 
            this.tenKH.HeaderText = "Tên khách đại diện";
            this.tenKH.Name = "tenKH";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QLKS.Properties.Resources.ButtonSearch;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(232, 145);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(188, 47);
            this.btnTim.TabIndex = 13;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.MouseEnter += new System.EventHandler(this.btnTim_MouseEnter);
            // 
            // btnNhanHet
            // 
            this.btnNhanHet.BackgroundImage = global::QLKS.Properties.Resources.ButtonNhanHet;
            this.btnNhanHet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanHet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanHet.Location = new System.Drawing.Point(444, 218);
            this.btnNhanHet.Name = "btnNhanHet";
            this.btnNhanHet.Size = new System.Drawing.Size(188, 47);
            this.btnNhanHet.TabIndex = 14;
            this.btnNhanHet.UseVisualStyleBackColor = true;
            this.btnNhanHet.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnNhanHet.Click += new System.EventHandler(this.btnNhanHet_Click);
            this.btnNhanHet.MouseEnter += new System.EventHandler(this.btnNhanHet_MouseEnter);
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS.Properties.Resources.NhanPhong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 387);
            this.Controls.Add(this.btnNhanHet);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDanhSachPhieuThue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.txtCMND);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCheckin";
            this.Text = "Nhận phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnNhanHet;



    }
}