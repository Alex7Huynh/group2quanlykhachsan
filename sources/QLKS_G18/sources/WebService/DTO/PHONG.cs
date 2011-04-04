using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PHONG
    {
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private string tenPhong;

        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        private string maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
    }
}
