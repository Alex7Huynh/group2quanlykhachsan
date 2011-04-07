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
            this.dtgTheHienPhieuThuePhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheHienPhieuThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTheHienPhieuThuePhong
            // 
            this.dtgTheHienPhieuThuePhong.AllowUserToAddRows = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToDeleteRows = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToResizeColumns = false;
            this.dtgTheHienPhieuThuePhong.AllowUserToResizeRows = false;
            this.dtgTheHienPhieuThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheHienPhieuThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTheHienPhieuThuePhong.Location = new System.Drawing.Point(0, 0);
            this.dtgTheHienPhieuThuePhong.Name = "dtgTheHienPhieuThuePhong";
            this.dtgTheHienPhieuThuePhong.ReadOnly = true;
            this.dtgTheHienPhieuThuePhong.RowHeadersWidth = 100;
            this.dtgTheHienPhieuThuePhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTheHienPhieuThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgTheHienPhieuThuePhong.Size = new System.Drawing.Size(860, 373);
            this.dtgTheHienPhieuThuePhong.TabIndex = 0;
            this.dtgTheHienPhieuThuePhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgTheHienPhieuThuePhong_CellFormatting);
            this.dtgTheHienPhieuThuePhong.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgTheHienPhieuThuePhong_CellPainting);
            // 
            // UCXemPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgTheHienPhieuThuePhong);
            this.Name = "UCXemPhieuThuePhong";
            this.Size = new System.Drawing.Size(860, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheHienPhieuThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTheHienPhieuThuePhong;
    }
}
