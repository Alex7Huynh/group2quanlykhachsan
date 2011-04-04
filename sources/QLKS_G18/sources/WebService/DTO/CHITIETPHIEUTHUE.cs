using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CHITIETPHIEUTHUE
    {
        private string maPhieuThue;

        public string MaPhieuThue
        {
            get { return maPhieuThue; }
            set { maPhieuThue = value; }
        }

        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string maChiTietPhieuThue;

        public string MaChiTietPhieuThue
        {
            get { return maChiTietPhieuThue; }
            set { maChiTietPhieuThue = value; }
        }
    }
}
