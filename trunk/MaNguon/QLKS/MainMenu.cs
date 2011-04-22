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
        }

        private void PB_SuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong frmSuaPhong = new SuaPhong();
            frmSuaPhong.Show();
        }

        private void PB_TraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong frmTraCuuPhong = new TraCuuPhong();
            frmTraCuuPhong.Show();
        }

        private void PB_TraCuuPhieuThue_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuThue frmTraCuuPT = new frmTraCuuPhieuThue();
            frmTraCuuPT.Show();
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

        private void BT_ThemPhong_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.GreenYellow;
        }

        private void BT_ThemPhong_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Khaki;
        }

        private void BT_SuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong suaphong = new SuaPhong();
            suaphong.ShowDialog();
        }

        private void BT_TCKH_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang traCuuKH = new TraCuuKhachHang();
            traCuuKH.ShowDialog();
        }

        private void BT_ThuNho_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;       
        }

        private void BT_ThuNho_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.OliveDrab;
        }

        private void BT_Thoat_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkRed;
        }       
    }
}
