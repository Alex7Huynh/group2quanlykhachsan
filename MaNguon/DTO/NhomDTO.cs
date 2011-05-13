using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhomDTO
    {
        private int _maNhom;

        public int MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }
        private string _maKhacHang;

        public string MaKhacHang
        {
            get { return _maKhacHang; }
            set { _maKhacHang = value; }
        }
    }
}
