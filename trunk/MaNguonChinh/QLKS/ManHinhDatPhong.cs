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
    public partial class frmManHinhDatPhong : Form
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
        /// Hàm khởi tạo mành hình Đặt phòng
        /// </summary>
        public frmManHinhDatPhong()
        {
            InitializeComponent();
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
        /// Hàm xử lý sự kiện click của nút Thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
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
    }
}
