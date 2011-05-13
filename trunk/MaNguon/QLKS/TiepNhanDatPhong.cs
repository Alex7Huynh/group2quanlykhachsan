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
    public partial class TiepNhanDatPhong : Form
    {
        List<LOAIPHONG> dsLoaiPhong = new List<LOAIPHONG>();
        List<LOAIKHACH> dsLoaiKhach = new List<LOAIKHACH>();
        public TiepNhanDatPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TiepNhanDatPhong_Load(object sender, EventArgs e)
        {
            //load danh sach loai phong
            try
            {
                dsLoaiPhong = PHONGBUS.LayDSLoaiPhong();
                List<string> str_dsLoaiPhong = new List<string>();
                for (int i = 0; i < dsLoaiPhong.Count; i++)
                {
                    str_dsLoaiPhong.Add(dsLoaiPhong[i].TenLoaiPhong);
                }
                cmbLoaiPhong.DataSource = str_dsLoaiPhong;
                //load danh sach loai khach hang
                dsLoaiKhach = LOAIKHACHBUS.layDSLoaiKhach();
                List<string> str_dsLoaiKhacHang = new List<string>();
                for (int i = 0; i < dsLoaiKhach.Count; i++)
                {
                    str_dsLoaiKhacHang.Add(dsLoaiKhach[i].TenLoaiKH);
                }
                cmbLoaiKhacHang.DataSource = str_dsLoaiKhacHang;
                txtSoNgay.Text = "1";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // lấy các giá trị của các control
            // lấy khach hang
            KHACHHANG khachHangDaiDien = new KHACHHANG();
            PHIEUTHUE phieuThue = new PHIEUTHUE();
            try
            {
                try
                {
                    khachHangDaiDien.HoTen = txtTenKhachHang.Text.Trim();
                    khachHangDaiDien.DiaChi = txtDiaChi.Text.Trim();
                    khachHangDaiDien.SoGiayTo = txtCMND_PassPort.Text.Trim();
                    khachHangDaiDien.MaLoaiKH = dsLoaiKhach[cmbLoaiKhacHang.SelectedIndex].MaLoaiKH;
                    phieuThue.NgayThue = dtpNgayThue.Value.Date;
                }
                catch
                {
                    throw new Exception("Lỗi đọc dự liệu");
                }

/*
                //tao nhom moi
                NhomDTO nhom = new NhomDTO();
                int maNhom = 0;



                nhom.MaNhom = maNhom;
                nhom.MaKhacHang = 0;*/
                // lay thong tin dat phong

                phieuThue.TenKhachHangDaiDien = khachHangDaiDien.HoTen;

                try
                {
                    phieuThue.SoNgayThue = int.Parse(txtSoNgay.Text.Trim());
                }
                catch (System.Exception ex)
                {
                    throw new Exception("Có lỗi ở textbox số ngày");
                }
                phieuThue.MaPhong = dsLoaiPhong[cmbLoaiPhong.SelectedIndex].MaLoaiPhong;
                int soNguoi = 0;
                try
                {
                    soNguoi = int.Parse(txtSoNguoi.Text.Trim());
                }
                catch
                {
                    throw new Exception("số người không phải là số hoặc quá nhiều");
                }
                if(soNguoi <0)
                    throw new Exception("số người không được âm");
                int temp = soNguoi;
                // goi ham kiem tra
                try
                {
                    List<string> dsPhieuThueDuocDat = new List<string>();
                    List<string> dsPhongDatDuoc = PHIEUTHUEBUS.KiemTra(phieuThue, ref soNguoi, ref dsPhieuThueDuocDat);
                    DialogResult result;
                    if (dsLoaiPhong.Count > 0)
                    {
                        if (soNguoi <= 0)
                        {
                            result = MessageBox.Show("Phiếu thuê có thể được đặt. Bạn có muốn đặt phiếu thuê này không?", "Thông Báo", MessageBoxButtons.YesNo);
                        }
                        else if (soNguoi != temp)
                        {
                            result = MessageBox.Show("Phiếu thuê chỉ được đặt cho " + (temp - soNguoi).ToString() + "người. Xin vui lòng chọn loại phòng khác cho số khách còn lại. Bạn có muốn đặt phiếu thuê này không?", "Thông Báo", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            result = MessageBox.Show("Loại phòng " + phieuThue.MaPhong + " không còn phòng trống! Vui lòng chọn loại phòng khác.");
                        }
                        if (result == DialogResult.Yes)
                        {

                        }
                        else if (result == DialogResult.No)
                        {
                            PHIEUTHUEBUS.XoaPhieuThue(dsPhieuThueDuocDat);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
