using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LOAIPHONG
    {
        private string maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }
        private string tenLoaiPhong;

        public string TenLoaiPhong
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int sLKhachToiDa;

        public int SLKhachToiDa
        {
            get { return sLKhachToiDa; }
            set { sLKhachToiDa = value; }
        }
    }
}
