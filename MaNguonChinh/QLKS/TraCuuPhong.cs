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
    /// Lop tra cuu phong dung de tim thong tin phong mun tim kiem
    /// /author Luc Tan Binh - 0812033
    /// </summary>
    public partial class TraCuuPhong : Form
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

        public TraCuuPhong()
        {
            InitializeComponent();
        }
        List<string> strDanhSachLoaiPhong = new List<string>();
        List<string> danhSachTenLoaiPhong = new List<string>();
        List<LOAIPHONG> danhSachLoaiPhong ;
        private void TraCuuPhong_Load(object sender, EventArgs e)
        {
            try
            {
                danhSachLoaiPhong = PHONGBUS.LayDSLoaiPhong();
                LayDanhSachMaLoaiPhong();
                LayDanhSachTenLoaiPhong();
                cmbLoaiPhong.DataSource = danhSachTenLoaiPhong;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            dtgDanhSachPhong.Rows.Clear();
            String maPhong;
            String tenPhong;
            String tinhTrang;
            if (txtMaPhong.Text == "")
            {
                maPhong = " ";
            }
            else
            {
                maPhong = txtMaPhong.Text.Trim();
            }
            if (txtTenPhong.Text == "")
            {
                tenPhong = " ";
            }
            else
            {
                tenPhong = txtTenPhong.Text.Trim();
            }
            if (txtTinhTrang.Text == "")
            {
                tinhTrang = " ";
            }
            else
            {
                tinhTrang = txtTinhTrang.Text.Trim();
            }
            bool timChinhXac = cbxTimChinhXac.Checked;
            try
            {
                List<PHONG> danhSachPhong = PHONGBUS.TimPhong(maPhong, tenPhong, strDanhSachLoaiPhong[cmbLoaiPhong.SelectedIndex], tinhTrang, timChinhXac);
                for (int i = 0; i < danhSachPhong.Count; i++)
                    dtgDanhSachPhong.Rows.Add(danhSachPhong[i].MaPhong, danhSachPhong[i].TenPhong, danhSachPhong[i].MaLoaiPhong, danhSachPhong[i].GhiChu, danhSachPhong[i].TinhTrang);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LayDanhSachMaLoaiPhong()
        {
            for (int i = 0; i < danhSachLoaiPhong.Count; i++ )
            {
                strDanhSachLoaiPhong.Add(danhSachLoaiPhong[i].MaLoaiPhong);
            }
        }
        void LayDanhSachTenLoaiPhong()
        {
            
            for (int i = 0; i  < danhSachLoaiPhong.Count; i++)
            {
                danhSachTenLoaiPhong.Add(danhSachLoaiPhong[i].TenLoaiPhong);
            }
        }

        
        // 0812604 - giao dien

        /// <summary>
        /// Hàm xử lý sự kiện Paint của gridview Danh sách phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgDanhSachPhong_Paint(object sender, PaintEventArgs e)
        {
            for (int index = 0; index < dtgDanhSachPhong.Columns.Count; index++)
            {
                dtgDanhSachPhong.Columns[index].HeaderCell.Style.ForeColor = Color.White;
                dtgDanhSachPhong.Columns[index].HeaderCell.Style.BackColor = Color.Black;
                dtgDanhSachPhong.Columns[index].HeaderCell.Style.Font = new Font("Consolas", 10, FontStyle.Bold);
            }

            for (int index = 0; index < dtgDanhSachPhong.Rows.Count; index++)
            {
                dtgDanhSachPhong.Rows[index].HeaderCell.Style.ForeColor = Color.White;
                dtgDanhSachPhong.Rows[index].HeaderCell.Style.BackColor = Color.Black;
                dtgDanhSachPhong.Rows[index].Height = 30;
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
        /// Hàm xử lý sự kiện click của nút Thu nhỏ
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
