using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhomDTO
    {
        /// <summary>
        /// Mã nhóm
        /// </summary>
        private int _maNhom;

        public int MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        private string _maKhacHang;

        public string MaKhacHang
        {
            get { return _maKhacHang; }
            set { _maKhacHang = value; }
        }
    }
}
