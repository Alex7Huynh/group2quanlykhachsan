namespace QLKS
{
    partial class frmCheckOut
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
            this.txtCMND2 = new System.Windows.Forms.TextBox();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuThue = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCMND2
            // 
            this.txtCMND2.Location = new System.Drawing.Point(20, 155);
            this.txtCMND2.Multiline = true;
            this.txtCMND2.Name = "txtCMND2";
            this.txtCMND2.Size = new System.Drawing.Size(188, 47);
            this.txtCMND2.TabIndex = 16;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonTraPhong;
            this.btnTraPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Location = new System.Drawing.Point(448, 143);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(188, 47);
            this.btnTraPhong.TabIndex = 19;
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            this.btnTraPhong.MouseEnter += new System.EventHandler(this.btnTraPhong_MouseEnter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::QLKS.Properties.Resources.ButtonQuayLai;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(448, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 47);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnThoat_MouseEnter);
            // 
            // dgvDanhSachPhieuThue
            // 
            this.dgvDanhSachPhieuThue.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvDanhSachPhieuThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDanhSachPhieuThue.Location = new System.Drawing.Point(17, 308);
            this.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue";
            this.dgvDanhSachPhieuThue.ReadOnly = true;
            this.dgvDanhSachPhieuThue.RowHeadersVisible = false;
            this.dgvDanhSachPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuThue.Size = new System.Drawing.Size(631, 103);
            this.dgvDanhSachPhieuThue.TabIndex = 22;
            this.dgvDanhSachPhieuThue.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieuThue_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã phiếu thuê";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng đại diện";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày bắt đầu thuê";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số ngày thuê";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(20, 241);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(188, 47);
            this.txtTongTien.TabIndex = 24;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = ".000 VND";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QLKS.Properties.Resources.ButtonSearch;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(219, 155);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(188, 47);
            this.btnTim.TabIndex = 17;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.MouseLeave += new System.EventHandler(this.btnTim_MouseLeave);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.MouseEnter += new System.EventHandler(this.btnTim_MouseEnter);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS.Properties.Resources.TraPhong;
            this.ClientSize = new System.Drawing.Size(665, 426);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtCMND2);
            this.Controls.Add(this.dgvDanhSachPhieuThue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTraPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCheckOut";
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND2;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
    }
}