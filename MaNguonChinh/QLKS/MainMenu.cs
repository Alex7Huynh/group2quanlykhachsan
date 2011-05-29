using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QLKS
{
    public partial class MainMenu : Form
    {
        // Dành cho di chuyển menu
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
        /// Hàm khởi tạo màn hình MainMenu
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm xử lý sự kiện Load của màn hình MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //BT_ThemPhong.BackColor = Color.Transparent;
            try
            {
                QLKSBUS.KiemTraKetNoi();
            }
            catch
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu. Vui lòng kiểm tra file dữ liệu trong thu mục /DataBase/ và chạy lại chương trình.");
                Application.Exit();
            }
            BT_ThemPhong.Focus();
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Thêm phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_ThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong frmThemPhong = new ThemPhong();
            frmThemPhong.Show();

            frmThemPhong.Location = Location;
            this.Visible = false;
            frmThemPhong.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sựn kiện click vào nút Xoá phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_XoaPhong_Click(object sender, EventArgs e)
        {
            XoaPhong frmXoaPhong = new XoaPhong();
            frmXoaPhong.Show();

            frmXoaPhong.Location = Location;
            this.Visible = false;
            frmXoaPhong.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Sửa phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_SuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong frmSuaPhong = new SuaPhong();
            frmSuaPhong.Show();

            frmSuaPhong.Location = Location;
            this.Visible = false;
            frmSuaPhong.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Tra cứu phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_TraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong frmTraCuuPhong = new TraCuuPhong();
            frmTraCuuPhong.Show();

            frmTraCuuPhong.Location = Location;
            this.Visible = false;
            frmTraCuuPhong.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Tra cứu phiếu thuê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_TraCuuPhieuThue_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuThue frmTraCuuPT = new frmTraCuuPhieuThue();
            frmTraCuuPT.Show();

            frmTraCuuPT.Location = Location;
            this.Visible = false;
            frmTraCuuPT.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Tra cứu khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_TCKH_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang traCuuKH = new TraCuuKhachHang();
            traCuuKH.Show();

            traCuuKH.Location = Location;
            this.Visible = false;
            traCuuKH.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_DatPhong_Click(object sender, EventArgs e)
        {
            frmManHinhDatPhong frmDatPhong = new frmManHinhDatPhong();
            frmDatPhong.Show();

            frmDatPhong.Location = Location;
            this.Visible = false;
            frmDatPhong.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Báo cáo doanh thu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_BaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frmBaoCao = new frmBaoCaoDoanhThu();
            frmBaoCao.Show();

            frmBaoCao.Location = Location;
            this.Visible = false;
            frmBaoCao.ParentForm = this;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào nút Thu nhỏ
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
            if(e.Button == MouseButtons.Left)
            MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }               

        /// <summary>
        /// Hàm xử lý sự kiện MouseDown cho các nút
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_Add_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Width -= 4;
            pb.Height -= 4;

            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseUp cho các nút
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_Add_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Width += 4;
            pb.Height += 4;

            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thêm phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThemPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonAddFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseLeave của nút Thêm phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThemPhong_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Xoá phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_XoaPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonDeleteFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Sửa phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_SuaPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonFixFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Tra cứu phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_TCPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonRoomFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Tra cứu phiếu thuê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_TCPhieuThue_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonTickFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Tra cứu khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_TCKH_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonCustomerFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_DatPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonCheckedFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Báo cáo doanh thu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_BCDoanhThu_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMoneyReportFocus;
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
        /// Hàm xử lý sự kiện click của nút Đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            TiepNhanDatPhong frmDatPhong = new TiepNhanDatPhong(false, "");
            frmDatPhong.Show();
            frmDatPhong.Location = Location;
            frmDatPhong.ParentForm = this;
            this.Visible = false;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Sơ đồ phiếu thuê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_SoDoPhieuThue_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMatrixTickFocus;
        }         
    }
}
