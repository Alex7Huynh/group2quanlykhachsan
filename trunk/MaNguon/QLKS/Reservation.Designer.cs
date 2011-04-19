namespace QLKS
{
    partial class frmReservation
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
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.CustomFormat = "DD/MM/YYYY";
            this.dtpBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginDate.Location = new System.Drawing.Point(107, 143);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(156, 23);
            this.dtpBeginDate.TabIndex = 0;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.dtpBeginDate_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFrom.ForeColor = System.Drawing.Color.Orange;
            this.lblFrom.Location = new System.Drawing.Point(12, 148);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(27, 17);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Từ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTo.ForeColor = System.Drawing.Color.Orange;
            this.lblTo.Location = new System.Drawing.Point(12, 188);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 17);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Đến";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "DD/MM/YYYY";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(107, 183);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(156, 23);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDuration.ForeColor = System.Drawing.Color.Orange;
            this.lblDuration.Location = new System.Drawing.Point(11, 226);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(76, 17);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Thời gian";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.Pink;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDuration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDuration.Location = new System.Drawing.Point(107, 223);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(156, 23);
            this.txtDuration.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.ForeColor = System.Drawing.Color.Orange;
            this.lblTen.Location = new System.Drawing.Point(11, 75);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 17);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Pink;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTen.Location = new System.Drawing.Point(107, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 23);
            this.txtTen.TabIndex = 7;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Orange;
            this.lblLoaiPhong.Location = new System.Drawing.Point(11, 36);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(90, 17);
            this.lblLoaiPhong.TabIndex = 8;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.BackColor = System.Drawing.Color.Pink;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(107, 33);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(156, 24);
            this.cboLoaiPhong.TabIndex = 9;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDays.Location = new System.Drawing.Point(280, 226);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(43, 17);
            this.lblDays.TabIndex = 12;
            this.lblDays.Text = "ngày";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(118, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 36);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Xác nhận";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Olive;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(286, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGia.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDonGia.Location = new System.Drawing.Point(269, 36);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(67, 17);
            this.lblDonGia.TabIndex = 15;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.Black;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Orange;
            this.txtDonGia.Location = new System.Drawing.Point(342, 33);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(140, 23);
            this.txtDonGia.TabIndex = 16;
            // 
            // PB_Image
            // 
            this.PB_Image.BackgroundImage = global::QLKS.Properties.Resources.runningman;
            this.PB_Image.Location = new System.Drawing.Point(329, 74);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(117, 169);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image.TabIndex = 17;
            this.PB_Image.TabStop = false;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::QLKS.Properties.Resources.reservation1;
            this.ClientSize = new System.Drawing.Size(494, 326);
            this.Controls.Add(this.PB_Image);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpBeginDate);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.PictureBox PB_Image;
    }
}