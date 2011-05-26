using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class MainMenu : Form
    {
        // Dành cho di chuyển menu
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }


        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //BT_ThemPhong.BackColor = Color.Transparent;
            BT_ThemPhong.Focus();
        }

        private void PB_ThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong frmThemPhong = new ThemPhong();
            frmThemPhong.Show();

            frmThemPhong.Location = Location;
            this.Visible = false;
            frmThemPhong.ParentForm = this;
        }

        private void PB_XoaPhong_Click(object sender, EventArgs e)
        {
            XoaPhong frmXoaPhong = new XoaPhong();
            frmXoaPhong.Show();

            frmXoaPhong.Location = Location;
            this.Visible = false;
            frmXoaPhong.ParentForm = this;
        }

        private void PB_SuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong frmSuaPhong = new SuaPhong();
            frmSuaPhong.Show();

            frmSuaPhong.Location = Location;
            this.Visible = false;
            frmSuaPhong.ParentForm = this;
        }

        private void PB_TraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong frmTraCuuPhong = new TraCuuPhong();
            frmTraCuuPhong.Show();

            frmTraCuuPhong.Location = Location;
            this.Visible = false;
            frmTraCuuPhong.ParentForm = this;
        }

        private void PB_TraCuuPhieuThue_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuThue frmTraCuuPT = new frmTraCuuPhieuThue();
            frmTraCuuPT.Show();

            frmTraCuuPT.Location = Location;
            this.Visible = false;
            frmTraCuuPT.ParentForm = this;
        }

        private void BT_TCKH_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang traCuuKH = new TraCuuKhachHang();
            traCuuKH.Show();

            traCuuKH.Location = Location;
            this.Visible = false;
            traCuuKH.ParentForm = this;
        }

        private void PB_DatPhong_Click(object sender, EventArgs e)
        {
            frmManDinhDatPhong frmDatPhong = new frmManDinhDatPhong();
            frmDatPhong.Show();

            frmDatPhong.Location = Location;
            this.Visible = false;
            frmDatPhong.ParentForm = this;
        }

        private void PB_BaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frmBaoCao = new frmBaoCaoDoanhThu();
            frmBaoCao.Show();

            frmBaoCao.Location = Location;
            this.Visible = false;
            frmBaoCao.ParentForm = this;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        // Hàm di chuyển menu
        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }               

        private void PB_Add_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Width -= 4;
            pb.Height -= 4;

            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void PB_Add_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Width += 4;
            pb.Height += 4;

            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }

        private void BT_ThemPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonAddFocus;
        }

        private void BT_ThemPhong_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void BT_XoaPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonDeleteFocus;
        }

        private void BT_SuaPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonFixFocus;
        }

        private void BT_TCPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonRoomFocus;
        }

        private void BT_TCPhieuThue_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonTickFocus;
        }

        private void BT_TCKH_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonCustomerFocus;
        }

        private void BT_DatPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonCheckedFocus;
        }

        private void BT_BCDoanhThu_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMoneyReportFocus;
        }

        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
        }

        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonExitFocus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiepNhanDatPhong frmDatPhong = new TiepNhanDatPhong();
            frmDatPhong.Show();
            frmDatPhong.Location = Location;
            frmDatPhong.ParentForm = this;
            this.Visible = false;
        }

        private void BT_SoDoPhieuThue_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMatrixTickFocus;
        }         
    }
}
