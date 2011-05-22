using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PHONG
    {
        /// <summary>
        /// Mã phòng
        /// </summary>
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        /// <summary>
        /// Tên phòng
        /// </summary>
        private string tenPhong;

        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }

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
        /// Ghi chú
        /// </summary>
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        /// <summary>
        /// Tình trạng
        /// </summary>
        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        /// <summary>
        /// Đã xóa
        /// </summary>
        private string daXoa;
        /// <summary>
        /// Số người tối đa
        /// </summary>
        private int soNguoiToiDa;

        public int SoNguoiToiDa
        {
            get { return soNguoiToiDa; }
            set { soNguoiToiDa = value; }
        }

        public string DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }
    }
}
