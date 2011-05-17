using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PHIEUTHUE
    {
        private string maPhieuThue;

        public string MaPhieuThue
        {
            get { return maPhieuThue; }
            set { maPhieuThue = value; }
        }
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        private DateTime ngayThue;

        public DateTime NgayThue
        {
            get { return ngayThue; }
            set { ngayThue = value; }
        }

        private int soNgayThue;

        public int SoNgayThue
        {
            get { return soNgayThue; }
            set { soNgayThue = value; }
        }

        private string tenKhachHangDaiDien;

        public string TenKhachHangDaiDien
        {
            get { return tenKhachHangDaiDien; }
            set { tenKhachHangDaiDien = value; }
        }
        private bool _dangThue = false;

        public bool DangThue
        {
            get { return _dangThue; }
            set { _dangThue = value; }
        }
        private int _maNhom;

        public int MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }
        private PHONG phong;

        public PHONG Phong
        {
            get { return phong; }
            set { phong = value; }
        }

        bool _daThanhToan;

        public bool DaThanhToan
        {
            get { return _daThanhToan; }
            set { _daThanhToan = value; }
        }
    }
}
