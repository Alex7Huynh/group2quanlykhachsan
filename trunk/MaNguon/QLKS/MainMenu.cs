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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTraCuuPhieuThue_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuThue frmTraCuuPT = new frmTraCuuPhieuThue();
            frmTraCuuPT.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmManDinhDatPhong frmDatPhong = new frmManDinhDatPhong();
            frmDatPhong.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong frmThemPhong = new ThemPhong();
            frmThemPhong.Show();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            XoaPhong frmXoaPhong = new XoaPhong();
            frmXoaPhong.Show();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong frmSuaPhong = new SuaPhong();
            frmSuaPhong.Show();
        }

        private void btnTraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuPhong frmTraCuuPhong = new TraCuuPhong();
            frmTraCuuPhong.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frmBaoCao = new frmBaoCaoDoanhThu();
            frmBaoCao.Show();
        }
    }
}
