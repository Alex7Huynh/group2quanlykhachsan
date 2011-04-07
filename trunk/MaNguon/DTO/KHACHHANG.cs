using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KHACHHANG
    {
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string maLoaiKH;

        public string MaLoaiKH
        {
            get { return maLoaiKH; }
            set { maLoaiKH = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string soGiayTo;

        public string SoGiayTo
        {
            get { return soGiayTo; }
            set { soGiayTo = value; }
        }
    }
}
