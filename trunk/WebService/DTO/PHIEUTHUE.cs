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
    }
}
