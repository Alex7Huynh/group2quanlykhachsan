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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTraPhongDoan = new System.Windows.Forms.GroupBox();
            this.gbTraPhongDon = new System.Windows.Forms.GroupBox();
            this.rdoCMND = new System.Windows.Forms.RadioButton();
            this.rdoTenPhong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.gbThanhTien = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.rdoTraPhongDon = new System.Windows.Forms.RadioButton();
            this.rdoTraPhongDoan = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbTraPhongDoan.SuspendLayout();
            this.gbTraPhongDon.SuspendLayout();
            this.gbThanhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMND2
            // 
            this.txtCMND2.Location = new System.Drawing.Point(240, 32);
            this.txtCMND2.Name = "txtCMND2";
            this.txtCMND2.Size = new System.Drawing.Size(162, 20);
            this.txtCMND2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "CMND/PassPort người đại diện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhận Phòng";
            // 
            // gbTraPhongDoan
            // 
            this.gbTraPhongDoan.Controls.Add(this.label5);
            this.gbTraPhongDoan.Controls.Add(this.txtCMND2);
            this.gbTraPhongDoan.Location = new System.Drawing.Point(53, 228);
            this.gbTraPhongDoan.Name = "gbTraPhongDoan";
            this.gbTraPhongDoan.Size = new System.Drawing.Size(408, 71);
            this.gbTraPhongDoan.TabIndex = 17;
            this.gbTraPhongDoan.TabStop = false;
            this.gbTraPhongDoan.Text = "       Trả phòng theo đoàn";
            // 
            // gbTraPhongDon
            // 
            this.gbTraPhongDon.Controls.Add(this.rdoCMND);
            this.gbTraPhongDon.Controls.Add(this.rdoTenPhong);
            this.gbTraPhongDon.Controls.Add(this.label3);
            this.gbTraPhongDon.Controls.Add(this.txtCMND1);
            this.gbTraPhongDon.Controls.Add(this.label2);
            this.gbTraPhongDon.Controls.Add(this.txtTenPhong);
            this.gbTraPhongDon.Location = new System.Drawing.Point(53, 84);
            this.gbTraPhongDon.Name = "gbTraPhongDon";
            this.gbTraPhongDon.Size = new System.Drawing.Size(408, 100);
            this.gbTraPhongDon.TabIndex = 18;
            this.gbTraPhongDon.TabStop = false;
            this.gbTraPhongDon.Text = "       Trả phòng đơn";
            // 
            // rdoCMND
            // 
            this.rdoCMND.AutoSize = true;
            this.rdoCMND.Location = new System.Drawing.Point(12, 69);
            this.rdoCMND.Name = "rdoCMND";
            this.rdoCMND.Size = new System.Drawing.Size(14, 13);
            this.rdoCMND.TabIndex = 20;
            this.rdoCMND.TabStop = true;
            this.rdoCMND.UseVisualStyleBackColor = true;
            // 
            // rdoTenPhong
            // 
            this.rdoTenPhong.AutoSize = true;
            this.rdoTenPhong.Location = new System.Drawing.Point(12, 35);
            this.rdoTenPhong.Name = "rdoTenPhong";
            this.rdoTenPhong.Size = new System.Drawing.Size(14, 13);
            this.rdoTenPhong.TabIndex = 19;
            this.rdoTenPhong.TabStop = true;
            this.rdoTenPhong.UseVisualStyleBackColor = true;
            this.rdoTenPhong.CheckedChanged += new System.EventHandler(this.rdoTenPhong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "CMND/PassPort người đại diện";
            // 
            // txtCMND1
            // 
            this.txtCMND1.Location = new System.Drawing.Point(240, 66);
            this.txtCMND1.Name = "txtCMND1";
            this.txtCMND1.Size = new System.Drawing.Size(162, 20);
            this.txtCMND1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(240, 32);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(162, 20);
            this.txtTenPhong.TabIndex = 16;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(120, 410);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTraPhong.TabIndex = 19;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            // 
            // gbThanhTien
            // 
            this.gbThanhTien.Controls.Add(this.txtThanhTien);
            this.gbThanhTien.Location = new System.Drawing.Point(53, 317);
            this.gbThanhTien.Name = "gbThanhTien";
            this.gbThanhTien.Size = new System.Drawing.Size(408, 71);
            this.gbThanhTien.TabIndex = 18;
            this.gbThanhTien.TabStop = false;
            this.gbThanhTien.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(240, 32);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(162, 20);
            this.txtThanhTien.TabIndex = 16;
            // 
            // rdoTraPhongDon
            // 
            this.rdoTraPhongDon.AutoSize = true;
            this.rdoTraPhongDon.Location = new System.Drawing.Point(65, 59);
            this.rdoTraPhongDon.Name = "rdoTraPhongDon";
            this.rdoTraPhongDon.Size = new System.Drawing.Size(96, 17);
            this.rdoTraPhongDon.TabIndex = 20;
            this.rdoTraPhongDon.TabStop = true;
            this.rdoTraPhongDon.Text = "Trả phòng đơn";
            this.rdoTraPhongDon.UseVisualStyleBackColor = true;
            this.rdoTraPhongDon.CheckedChanged += new System.EventHandler(this.rdoTraPhongDon_CheckedChanged);
            // 
            // rdoTraPhongDoan
            // 
            this.rdoTraPhongDoan.AutoSize = true;
            this.rdoTraPhongDoan.Location = new System.Drawing.Point(65, 203);
            this.rdoTraPhongDoan.Name = "rdoTraPhongDoan";
            this.rdoTraPhongDoan.Size = new System.Drawing.Size(126, 17);
            this.rdoTraPhongDoan.TabIndex = 21;
            this.rdoTraPhongDoan.TabStop = true;
            this.rdoTraPhongDoan.Text = "Trả phòng theo đoàn";
            this.rdoTraPhongDoan.UseVisualStyleBackColor = true;
            this.rdoTraPhongDoan.CheckedChanged += new System.EventHandler(this.rdoTraPhongDoan_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(350, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 453);
            this.Controls.Add(this.rdoTraPhongDoan);
            this.Controls.Add(this.rdoTraPhongDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbThanhTien);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.gbTraPhongDon);
            this.Controls.Add(this.gbTraPhongDoan);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.gbTraPhongDoan.ResumeLayout(false);
            this.gbTraPhongDoan.PerformLayout();
            this.gbTraPhongDon.ResumeLayout(false);
            this.gbTraPhongDon.PerformLayout();
            this.gbThanhTien.ResumeLayout(false);
            this.gbThanhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTraPhongDoan;
        private System.Windows.Forms.GroupBox gbTraPhongDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.GroupBox gbThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.RadioButton rdoCMND;
        private System.Windows.Forms.RadioButton rdoTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND1;
        private System.Windows.Forms.RadioButton rdoTraPhongDoan;
        private System.Windows.Forms.RadioButton rdoTraPhongDon;
        private System.Windows.Forms.Button btnThoat;
    }
}