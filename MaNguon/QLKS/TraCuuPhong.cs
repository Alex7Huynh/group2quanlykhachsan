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

        /// <summary>
        /// 0812604 - giao dien
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
