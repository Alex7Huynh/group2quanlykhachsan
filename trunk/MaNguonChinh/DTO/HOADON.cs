using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HOADON
    {
        /// <summary>
        /// Mã hóa đơn
        /// </summary>
        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        /// <summary>
        /// Tên khách hàng thanh toán
        /// </summary>
        private string tenKhachHangThanhToan;

        public string TenKhachHangThanhToan
        {
            get { return tenKhachHangThanhToan; }
            set { tenKhachHangThanhToan = value; }
        }

        /// <summary>
        /// Ngày thanh toán
        /// </summary>
        private DateTime ngayThanhToan;

        public DateTime NgayThanhToan
        {
            get { return ngayThanhToan; }
            set { ngayThanhToan = value; }
        }

        /// <summary>
        /// Thanh tiền
        /// </summary>
        private int thanhtien;

        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        /// <summary>
        /// Mã phiếu thuê
        /// </summary>
        private string maPhieuThue;

        public string MaPhieuThue
        {
            get { return maPhieuThue; }
            set { maPhieuThue = value; }
        }
        /// <summary>
        /// Danh sách chi tiết phiếu thuê
        /// </summary>
        private List<CHITIETHOADON> dsCTHD;

        public List<CHITIETHOADON> DsCTHD
        {
            get { return dsCTHD; }
            set { dsCTHD = value; }
        }
    }
}
