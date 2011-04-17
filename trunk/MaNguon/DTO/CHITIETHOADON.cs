using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CHITIETHOADON
    {
        private string maChiTietHoaDon;

        public string MaChiTietHoaDon
        {
            get { return maChiTietHoaDon; }
            set { maChiTietHoaDon = value; }
        }

        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private int tongCong;

        public int TongCong
        {
            get { return tongCong; }
            set { tongCong = value; }
        }
        private PHIEUTHUE phieuthue;

        public PHIEUTHUE Phieuthue
        {
            get { return phieuthue; }
            set { phieuthue = value; }
        }
    }
}
