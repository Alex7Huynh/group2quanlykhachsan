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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND/PassPort";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(219, 79);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 20);
            this.txtCMND.TabIndex = 7;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(114, 449);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(75, 23);
            this.btnNhanPhong.TabIndex = 9;
            this.btnNhanPhong.Text = "Nhận Phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(330, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSachPhieuThue
            // 
            this.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.maPhieuThue,
            this.ngayThue,
            this.soNgayThue,
            this.tenKH});
            this.dgvDanhSachPhieuThue.Location = new System.Drawing.Point(20, 167);
            this.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue";
            this.dgvDanhSachPhieuThue.RowHeadersVisible = false;
            this.dgvDanhSachPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuThue.Size = new System.Drawing.Size(502, 253);
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
            this.btnTim.Location = new System.Drawing.Point(434, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnNhanHet
            // 
            this.btnNhanHet.Location = new System.Drawing.Point(219, 449);
            this.btnNhanHet.Name = "btnNhanHet";
            this.btnNhanHet.Size = new System.Drawing.Size(75, 23);
            this.btnNhanHet.TabIndex = 14;
            this.btnNhanHet.Text = "Nhận hết";
            this.btnNhanHet.UseVisualStyleBackColor = true;
            this.btnNhanHet.Click += new System.EventHandler(this.btnNhanHet_Click);
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 484);
            this.Controls.Add(this.btnNhanHet);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDanhSachPhieuThue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckin";
            this.Text = "Nhận Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
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