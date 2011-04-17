using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HOADON
    {
        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private string tenKhachHangThanhToan;

        public string TenKhachHangThanhToan
        {
            get { return tenKhachHangThanhToan; }
            set { tenKhachHangThanhToan = value; }
        }
        private DateTime ngayThanhToan;

        public DateTime NgayThanhToan
        {
            get { return ngayThanhToan; }
            set { ngayThanhToan = value; }
        }
        private int thanhtien;

        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        private string maPhieuThue;

        public string MaPhieuThue
        {
            get { return maPhieuThue; }
            set { maPhieuThue = value; }
        }
        private List<CHITIETHOADON> dsCTHD;

        public List<CHITIETHOADON> DsCTHD
        {
            get { return dsCTHD; }
            set { dsCTHD = value; }
        }
    }
}
