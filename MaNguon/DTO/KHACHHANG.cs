using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KHACHHANG
    {
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
        /// Họ tên
        /// </summary>
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        /// <summary>
        /// Mã loại khách hàng
        /// </summary>
        private string maLoaiKH;

        public string MaLoaiKH
        {
            get { return maLoaiKH; }
            set { maLoaiKH = value; }
        }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        /// <summary>
        /// Số giấy tờ
        /// </summary>
        private string soGiayTo;

        public string SoGiayTo
        {
            get { return soGiayTo; }
            set { soGiayTo = value; }
        }
    }
}
