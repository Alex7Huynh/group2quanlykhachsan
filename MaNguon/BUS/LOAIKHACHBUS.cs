using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class LOAIKHACHBUS
    {
        /// <summary>
        /// Lay danh sach loai khach
        /// </summary>
        /// <returns>Tra ve danh sach loai khach</returns>
        public static List<LOAIKHACH> layDSLoaiKhach()
        {
            List<LOAIKHACH> dsLoaiKH = new List<LOAIKHACH>();
            try
            {
                dsLoaiKH = LOAIKHACHDAO.LayDSLoaiKhach();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsLoaiKH;
        }
    }
}
