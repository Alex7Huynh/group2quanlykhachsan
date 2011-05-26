using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CHITIETHOADON
    {
        /// <summary>
        /// Mã chi tiết hóa đơn
        /// </summary>
        private string maChiTietHoaDon;

        public string MaChiTietHoaDon
        {
            get { return maChiTietHoaDon; }
            set { maChiTietHoaDon = value; }
        }

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
        /// Tổng cộng
        /// </summary>
        private int tongCong;

        public int TongCong
        {
            get { return tongCong; }
            set { tongCong = value; }
        }
        /// <summary>
        /// Phiếu thuê
        /// </summary>
        private PHIEUTHUE phieuthue;

        public PHIEUTHUE Phieuthue
        {
            get { return phieuthue; }
            set { phieuthue = value; }
        }
    }
}
