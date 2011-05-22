using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PHIEUTHUE
    {
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
        /// Mã phòng
        /// </summary>
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        /// <summary>
        /// Ngày thuê
        /// </summary>
        private DateTime ngayThue;

        public DateTime NgayThue
        {
            get { return ngayThue; }
            set { ngayThue = value; }
        }

        /// <summary>
        /// Số ngày thuê
        /// </summary>
        private int soNgayThue;

        public int SoNgayThue
        {
            get { return soNgayThue; }
            set { soNgayThue = value; }
        }
        
        /// <summary>
        /// Tên khách hàng đại diện
        /// </summary>
        private string tenKhachHangDaiDien;

        public string TenKhachHangDaiDien
        {
            get { return tenKhachHangDaiDien; }
            set { tenKhachHangDaiDien = value; }
        }
        /// <summary>
        /// Đang thuê
        /// </summary>
        private bool _dangThue = false;

        public bool DangThue
        {
            get { return _dangThue; }
            set { _dangThue = value; }
        }
        /// <summary>
        /// Mã nhóm
        /// </summary>
        private int _maNhom;

        public int MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }

        /// <summary>
        /// Phòng
        /// </summary>
        private PHONG phong;

        public PHONG Phong
        {
            get { return phong; }
            set { phong = value; }
        }

        /// <summary>
        /// Đã thanh toán
        /// </summary>
        bool _daThanhToan;

        public bool DaThanhToan
        {
            get { return _daThanhToan; }
            set { _daThanhToan = value; }
        }
    }
}
