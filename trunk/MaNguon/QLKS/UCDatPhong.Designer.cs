namespace QLKS
{
    partial class UCDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mclCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnPreviousLoaiPhong = new System.Windows.Forms.Button();
            this.btnNextLoaiPhong = new System.Windows.Forms.Button();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.ucXemPhieuThuePhong = new QLKS.UCXemPhieuThuePhong();
            this.SuspendLayout();
            // 
            // mclCalendar
            // 
            this.mclCalendar.Location = new System.Drawing.Point(0, 0);
            this.mclCalendar.Name = "mclCalendar";
            this.mclCalendar.TabIndex = 1;
            this.mclCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclCalendar_DateChanged);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(239, 42);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(75, 23);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Enabled = false;
            this.btnCheckIn.Location = new System.Drawing.Point(239, 81);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(239, 122);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnPreviousLoaiPhong
            // 
            this.btnPreviousLoaiPhong.Location = new System.Drawing.Point(904, 132);
            this.btnPreviousLoaiPhong.Name = "btnPreviousLoaiPhong";
            this.btnPreviousLoaiPhong.Size = new System.Drawing.Size(65, 23);
            this.btnPreviousLoaiPhong.TabIndex = 7;
            this.btnPreviousLoaiPhong.Text = "<<<";
            this.btnPreviousLoaiPhong.UseVisualStyleBackColor = true;
            this.btnPreviousLoaiPhong.Click += new System.EventHandler(this.btnPreviousLoaiPhong_Click);
            // 
            // btnNextLoaiPhong
            // 
            this.btnNextLoaiPhong.Location = new System.Drawing.Point(975, 132);
            this.btnNextLoaiPhong.Name = "btnNextLoaiPhong";
            this.btnNextLoaiPhong.Size = new System.Drawing.Size(63, 23);
            this.btnNextLoaiPhong.TabIndex = 8;
            this.btnNextLoaiPhong.Text = ">>>";
            this.btnNextLoaiPhong.UseVisualStyleBackColor = true;
            this.btnNextLoaiPhong.Click += new System.EventHandler(this.btnNextLoaiPhong_Click);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(638, 137);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(64, 13);
            this.lblLoaiPhong.TabIndex = 9;
            this.lblLoaiPhong.Text = "Loại Phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(714, 134);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(128, 20);
            this.txtLoaiPhong.TabIndex = 10;
            this.txtLoaiPhong.TextChanged += new System.EventHandler(this.txtLoaiPhong_TextChanged);
            // 
            // ucXemPhieuThuePhong
            // 
            this.ucXemPhieuThuePhong.flag = 0;
            this.ucXemPhieuThuePhong.Location = new System.Drawing.Point(0, 161);
            this.ucXemPhieuThuePhong.Name = "ucXemPhieuThuePhong";
            this.ucXemPhieuThuePhong.Size = new System.Drawing.Size(1113, 373);
            this.ucXemPhieuThuePhong.TabIndex = 2;
            // 
            // UCDatPhong
            // 
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.btnNextLoaiPhong);
            this.Controls.Add(this.btnPreviousLoaiPhong);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.ucXemPhieuThuePhong);
            this.Controls.Add(this.mclCalendar);
            this.Name = "UCDatPhong";
            this.Size = new System.Drawing.Size(1116, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mclCalendar;
        private UCXemPhieuThuePhong ucXemPhieuThuePhong;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnPreviousLoaiPhong;
        private System.Windows.Forms.Button btnNextLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
    }
}
