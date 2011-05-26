namespace QLKS
{
    partial class UCXemPhieuThuePhong
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
            this.components = new System.ComponentModel.Container();
            this.dtgTheHienPhieuThuePhong = new System.Windows.Forms.DataGridView();
            this.TTip_MaPhieuThue = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheHienPhieuThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTheHienPhieuThuePhong
            // 
            this.dtgTheHienPhieuThuePhong.AllowUserToAddRows = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToDeleteRows = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToResizeColumns = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToResizeRows = false;
            this.dtgTheHienPhieuThuePhong.BackgroundColor = System.Drawing.Color.Indigo;
            this.dtgTheHienPhieuThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheHienPhieuThuePhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgTheHienPhieuThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTheHienPhieuThuePhong.EnableHeadersVisualStyles = false;
            this.dtgTheHienPhieuThuePhong.GridColor = System.Drawing.Color.Indigo;
            this.dtgTheHienPhieuThuePhong.Location = new System.Drawing.Point(0, 0);
            this.dtgTheHienPhieuThuePhong.Name = "dtgTheHienPhieuThuePhong";
            this.dtgTheHienPhieuThuePhong.ReadOnly = true;
            this.dtgTheHienPhieuThuePhong.RowHeadersWidth = 100;
            this.dtgTheHienPhieuThuePhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTheHienPhieuThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgTheHienPhieuThuePhong.ShowCellToolTips = false;
            this.dtgTheHienPhieuThuePhong.Size = new System.Drawing.Size(860, 504);
            this.dtgTheHienPhieuThuePhong.TabIndex = 0;
            this.dtgTheHienPhieuThuePhong.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTheHienPhieuThuePhong_CellMouseUp);
            this.dtgTheHienPhieuThuePhong.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTheHienPhieuThuePhong_CellMouseLeave);
            this.dtgTheHienPhieuThuePhong.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTheHienPhieuThuePhong_CellMouseDown);
            this.dtgTheHienPhieuThuePhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgTheHienPhieuThuePhong_CellFormatting);
            this.dtgTheHienPhieuThuePhong.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTheHienPhieuThuePhong_CellMouseEnter);
            this.dtgTheHienPhieuThuePhong.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgTheHienPhieuThuePhong_CellPainting);
            this.dtgTheHienPhieuThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTheHienPhieuThuePhong_CellClick);
            this.dtgTheHienPhieuThuePhong.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgTheHienPhieuThuePhong_Paint);
            this.dtgTheHienPhieuThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTheHienPhieuThuePhong_CellContentClick);
            // 
            // TTip_MaPhieuThue
            // 
            this.TTip_MaPhieuThue.AutoPopDelay = 5000;
            this.TTip_MaPhieuThue.BackColor = System.Drawing.Color.Orchid;
            this.TTip_MaPhieuThue.ForeColor = System.Drawing.Color.White;
            this.TTip_MaPhieuThue.InitialDelay = 50;
            this.TTip_MaPhieuThue.OwnerDraw = true;
            this.TTip_MaPhieuThue.ReshowDelay = 100;
            this.TTip_MaPhieuThue.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TTip_MaPhieuThue.ToolTipTitle = " MPT";
            this.TTip_MaPhieuThue.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.TTip_MaPhieuThue_Draw);
            // 
            // UCXemPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgTheHienPhieuThuePhong);
            this.Name = "UCXemPhieuThuePhong";
            this.Size = new System.Drawing.Size(860, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheHienPhieuThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTheHienPhieuThuePhong;
        private System.Windows.Forms.ToolTip TTip_MaPhieuThue;
    }
}
