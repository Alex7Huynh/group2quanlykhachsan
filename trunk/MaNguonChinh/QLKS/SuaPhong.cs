using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLKS
{
    public partial class SuaPhong : Form
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

        /// <summary>
        /// Hàm khởi tạo màn hình Sửa phòng
        /// </summary>
        public SuaPhong()
        {
            InitializeComponent();
        }

        private void SuaPhong_Load(object sender, EventArgs e)
        {
            List<PHONG> dsphg = PHONGBUS.LayDSPhong();
            cmbMP.Items.Clear();
            for (int index = 0; index < dsphg.Count; index++)
                cmbMP.Items.Add(dsphg[index].MaPhong);
        }

        private void cmbMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMP.Text != string.Empty)
            {
                PHONG phong = PHONGBUS.LayPhongTheoMa(cmbMP.Text);
                txtTP.Text = phong.TenPhong;
                txtLP.Text = phong.MaLoaiPhong;
                txtTT.Text = phong.TinhTrang;
                txtGC.Text = phong.GhiChu;
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

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbMP.Text != string.Empty)
            {
                PHONG phong = new PHONG();
                phong.MaPhong = cmbMP.Text.Trim();
                phong.TenPhong = txtTP.Text.Trim();
                phong.MaLoaiPhong =txtLP.Text.Trim();
                phong.TinhTrang= txtTT.Text.Trim();
                phong.GhiChu=txtGC.Text.Trim();  
                if (PHONGBUS.KiemTraPhong(phong))
                {
                    PHONGBUS.CapNhatPhong(phong);
                    MessageBox.Show("Da Sua Xong");
                }
                else MessageBox.Show("That Bai");
            }
            else MessageBox.Show("xin chon phong muon sua");
        }

        
        // 0812604 - giaodien
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
        /// Hàm xử lý sự kiện clikc của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Huỷ bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hàm xử lý sự kiện FormClosing của màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManDinhDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
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
        /// Hàm xử lý sự kiện MouseEnter của nút Quay lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyBo_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonFixFocus;
        }
    }
}
