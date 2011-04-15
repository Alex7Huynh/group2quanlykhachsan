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

            List<PHIEUTHUE> danhSachPhieuThue = PHIEUTHUEBUS.TimPhieu(maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
            for (int i = 0; i < danhSachPhieuThue.Count; i++)
                dtgDanhSachPhieuThue.Rows.Add(danhSachPhieuThue[i].MaPhieuThue, danhSachPhieuThue[i].MaPhong, danhSachPhieuThue[i].NgayThue.ToShortDateString(), danhSachPhieuThue[i].SoNgayThue.ToString(), danhSachPhieuThue[i].TenKhachHangDaiDien, danhSachPhieuThue[i].DangThue?"Đang thuê":"Đặt Chỗ");
        }

        private void chbTimTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimTheoNgay.Checked)
            {
                grbTimTheoNgay.Enabled = true;
            }
            else
            {
                grbTimTheoNgay.Enabled = false;
            }
        }

        private void frmTraCuuPhieuThue_Load(object sender, EventArgs e)
        {
            chbTimTheoNgay.Checked = true;
        }
    }
}
