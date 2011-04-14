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
        public TraCuuPhong()
        {
            InitializeComponent();
        }
        List<string> strDanhSachLoaiPhong = new List<string>();
        List<string> danhSachTenLoaiPhong = new List<string>();
        List<LOAIPHONG> danhSachLoaiPhong ;
        private void TraCuuPhong_Load(object sender, EventArgs e)
        {
            danhSachLoaiPhong = PHONGBUS.LayDSLoaiPhong();
            LayDanhSachMaLoaiPhong();
            LayDanhSachTenLoaiPhong();
            cmbLoaiPhong.DataSource = danhSachTenLoaiPhong;
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
            List<PHONG> danhSachPhong = PHONGBUS.TimPhong(maPhong, tenPhong, strDanhSachLoaiPhong[cmbLoaiPhong.SelectedIndex], tinhTrang);
            for (int i = 0; i < danhSachPhong.Count; i++)
                dtgDanhSachPhong.Rows.Add(danhSachPhong[i].MaPhong, danhSachPhong[i].TenPhong, danhSachPhong[i].MaLoaiPhong, danhSachPhong[i].GhiChu, danhSachPhong[i].TinhTrang);
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
    }
}
