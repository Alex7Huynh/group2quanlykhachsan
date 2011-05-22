using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LOAIPHONG
    {
        /// <summary>
        /// Mã loại phòng
        /// </summary>
        private string maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }
        /// <summary>
        /// Tên loại phòng
        /// </summary>
        private string tenLoaiPhong;

        public string TenLoaiPhong
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }
        /// <summary>
        /// Đơn giá
        /// </summary>
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        /// <summary>
        /// Số lượng khách hàng tối đa
        /// </summary>
        private int sLKhachToiDa;

        public int SLKhachToiDa
        {
            get { return sLKhachToiDa; }
            set { sLKhachToiDa = value; }
        }
    }
}
