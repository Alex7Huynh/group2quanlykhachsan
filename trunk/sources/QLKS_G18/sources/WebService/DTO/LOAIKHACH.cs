using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LOAIKHACH
    {
        private string maLoaiKH;

        public string MaLoaiKH
        {
            get { return maLoaiKH; }
            set { maLoaiKH = value; }
        }
        private string tenLoaiKH;

        public string TenLoaiKH
        {
            get { return tenLoaiKH; }
            set { tenLoaiKH = value; }
        }
        private int heSo;

        public int HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }
    }
}
