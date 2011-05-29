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
        /// <summary>
        /// Điểm bắt được khi có sự kiện MousePressed
        /// </summary>
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        /// <summary>
        /// Lưu lại form gọi hiển thị màn hình này
        /// </summary>
        public Form ParentForm;

        /// <summary>
        /// Hàm xử lý sự kiện MouseDown để lấy điểm bắt đầu di chuyển màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Hàm di chuyển màn hình
        /// </summary>
        /// <param name="distance"></param>
        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseMove để cập nhật vị trí màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }

        public frmTraCuuPhieuThue()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        
        // 0812604 - giao dien

        /// <summary>
        /// Hàm xử lý sự kiện Paint của gridview Danh sách phiếu thuê
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

        /// <summary>
        /// Hàm xử lý sự kiện FormClosing của màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TraCuuPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Thủ nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        /// <summary>
        /// Hàm xử lý sự kiện MouseLeave của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonExitFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Tìm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonSearchFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        } 
    }
}
