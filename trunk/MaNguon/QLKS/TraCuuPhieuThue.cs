using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLKS
{
    /// <summary>
    /// Lop tra cuu phieu thue
    /// /author Vo Xuan Tien - 0812517
    /// </summary>
    public partial class frmTraCuuPhieuThue : Form
    {
        // Dành cho di chuyển
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public Form ParentForm;

        // Hàm di chuyển menu
        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }

        public frmTraCuuPhieuThue()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtgDanhSachPhieuThue.Rows.Clear();
            String maPhieuThue;
            String tenPhong;
            DateTime ngayBatDauThue;
            int soNgayThue;
            string tenKhachHangDaiDien;
            if (txtMaPhieuThue.Text == "")
            {
                maPhieuThue = "";
            }
            else
            {
                maPhieuThue = txtMaPhieuThue.Text.Trim();
            }

            if (txtTenPhong.Text == "")
            {
                tenPhong = "";
            }
            else
            {
                tenPhong = txtTenPhong.Text.Trim();
            }

            if (txtTenKhachDaiDien.Text == "")
            {
                tenKhachHangDaiDien = "";
            }
            else
            {
                tenKhachHangDaiDien = txtTenKhachDaiDien.Text.Trim();
            }

            ngayBatDauThue = dtmNgayBatDauThue.Value;
            if (chbTimTheoNgay.Checked)
            {
                soNgayThue = (int)nudSoNgayThue.Value;
            }
            else
            {
                soNgayThue = -1;
            }

            string kieuTimKiem = string.Empty;
            if (rdoAnd.Checked)
            {
                kieuTimKiem = "and";
            }
            else if (rdoOr.Checked)
            {
                kieuTimKiem = "or";
            }

            List<PHIEUTHUE> danhSachPhieuThue = PHIEUTHUEBUS.TimPhieu(kieuTimKiem, maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
            for (int i = 0; i < danhSachPhieuThue.Count; i++)
                dtgDanhSachPhieuThue.Rows.Add(danhSachPhieuThue[i].MaPhieuThue, danhSachPhieuThue[i].MaPhong, danhSachPhieuThue[i].NgayThue.ToShortDateString(), danhSachPhieuThue[i].SoNgayThue.ToString(), danhSachPhieuThue[i].TenKhachHangDaiDien, danhSachPhieuThue[i].DangThue?"Đang thuê":"Đặt Chỗ");
        }

        private void chbTimTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimTheoNgay.Checked)
            {
                dtmNgayBatDauThue.Enabled = true;
                nudSoNgayThue.Enabled = true;
            }
            else
            {
                dtmNgayBatDauThue.Enabled = true;
                nudSoNgayThue.Enabled = true;
            }
        }

        private void frmTraCuuPhieuThue_Load(object sender, EventArgs e)
        {
            chbTimTheoNgay.Checked = true;
            rdoAnd.Checked = true;
        }

        /// <summary>
        /// 0812604 - giao dien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgDanhSachPhieuThue_Paint(object sender, PaintEventArgs e)
        {
            for (int index = 0; index < dtgDanhSachPhieuThue.Columns.Count; index++)
            {
                dtgDanhSachPhieuThue.Columns[index].HeaderCell.Style.ForeColor = Color.White;
                dtgDanhSachPhieuThue.Columns[index].HeaderCell.Style.BackColor = Color.Black;
                dtgDanhSachPhieuThue.Columns[index].HeaderCell.Style.Font = new Font("Consolas", 9, FontStyle.Bold);
            }

            for (int index = 0; index < dtgDanhSachPhieuThue.Rows.Count; index++)
            {
                dtgDanhSachPhieuThue.Rows[index].HeaderCell.Style.ForeColor = Color.White;
                dtgDanhSachPhieuThue.Rows[index].HeaderCell.Style.BackColor = Color.Black;
                dtgDanhSachPhieuThue.Rows[index].Height = 30;
            }
        }

        private void TraCuuPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void BT_Thoat_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = null;
        }

        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonExitFocus;
        }

        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonMinimizeFocus;
        }

        private void btnTim_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonSearchFocus;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonQuayLaiFocus;
        } 
    }
}
