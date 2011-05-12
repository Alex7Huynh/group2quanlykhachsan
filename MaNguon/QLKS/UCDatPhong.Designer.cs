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
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.btnNextLoaiPhong = new System.Windows.Forms.Button();
            this.btnPreviousLoaiPhong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucXemPhieuThuePhong = new QLKS.UCXemPhieuThuePhong();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mclCalendar
            // 
            this.mclCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.mclCalendar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mclCalendar.Location = new System.Drawing.Point(51, 158);
            this.mclCalendar.Name = "mclCalendar";
            this.mclCalendar.TabIndex = 1;
            this.mclCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclCalendar_DateChanged);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservation.Location = new System.Drawing.Point(870, 158);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(105, 41);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIn.Location = new System.Drawing.Point(870, 218);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(105, 41);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckOut.Location = new System.Drawing.Point(870, 279);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(105, 41);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BackColor = System.Drawing.Color.Gray;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.txtLoaiPhong.Location = new System.Drawing.Point(317, 207);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(220, 23);
            this.txtLoaiPhong.TabIndex = 5;
            // 
            // btnNextLoaiPhong
            // 
            this.btnNextLoaiPhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnNextLoaiPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonToi;
            this.btnNextLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLoaiPhong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextLoaiPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextLoaiPhong.Location = new System.Drawing.Point(433, 286);
            this.btnNextLoaiPhong.Name = "btnNextLoaiPhong";
            this.btnNextLoaiPhong.Size = new System.Drawing.Size(104, 35);
            this.btnNextLoaiPhong.TabIndex = 7;
            this.btnNextLoaiPhong.UseVisualStyleBackColor = false;
            this.btnNextLoaiPhong.MouseLeave += new System.EventHandler(this.btnPreviousLoaiPhong_MouseLeave);
            this.btnNextLoaiPhong.Click += new System.EventHandler(this.btnNextLoaiPhong_Click);
            this.btnNextLoaiPhong.MouseEnter += new System.EventHandler(this.btnNextLoaiPhong_MouseEnter);
            // 
            // btnPreviousLoaiPhong
            // 
            this.btnPreviousLoaiPhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnPreviousLoaiPhong.BackgroundImage = global::QLKS.Properties.Resources.ButtonLui;
            this.btnPreviousLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviousLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousLoaiPhong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousLoaiPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreviousLoaiPhong.Location = new System.Drawing.Point(317, 286);
            this.btnPreviousLoaiPhong.Name = "btnPreviousLoaiPhong";
            this.btnPreviousLoaiPhong.Size = new System.Drawing.Size(104, 35);
            this.btnPreviousLoaiPhong.TabIndex = 6;
            this.btnPreviousLoaiPhong.UseVisualStyleBackColor = false;
            this.btnPreviousLoaiPhong.MouseLeave += new System.EventHandler(this.btnPreviousLoaiPhong_MouseLeave);
            this.btnPreviousLoaiPhong.Click += new System.EventHandler(this.btnPreviousLoaiPhong_Click);
            this.btnPreviousLoaiPhong.MouseEnter += new System.EventHandler(this.btnPreviousLoaiPhong_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.MHDatPhong;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ucXemPhieuThuePhong
            // 
            this.ucXemPhieuThuePhong.flag = 0;
            this.ucXemPhieuThuePhong.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ucXemPhieuThuePhong.Location = new System.Drawing.Point(51, 351);
            this.ucXemPhieuThuePhong.Name = "ucXemPhieuThuePhong";
            this.ucXemPhieuThuePhong.Size = new System.Drawing.Size(924, 348);
            this.ucXemPhieuThuePhong.TabIndex = 8;
            // 
            // UCDatPhong
            // 
            this.Controls.Add(this.ucXemPhieuThuePhong);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.btnNextLoaiPhong);
            this.Controls.Add(this.btnPreviousLoaiPhong);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.mclCalendar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCDatPhong";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
