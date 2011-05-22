using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CHITIETPHIEUTHUE
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
        /// Mã khách hàng
        /// </summary>
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        /// <summary>
        /// Mã chi tiết phiếu thuê
        /// </summary>
        private string maChiTietPhieuThue;

        public string MaChiTietPhieuThue
        {
            get { return maChiTietPhieuThue; }
            set { maChiTietPhieuThue = value; }
        }
    }
}
