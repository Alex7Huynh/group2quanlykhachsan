using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    /// <summary>
    /// 0812033
    /// </summary>
    public class NhomBUS
    {
        /// <summary>
        /// Thêm nhóm mới
        /// </summary>
        /// <param name="nhom">đối tượng kieu NhomDTO</param>
        public static void ThemNhom(NhomDTO nhom)
        {
            try
            {
                NhomDAO.ThemNhom(nhom);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Tự động lấy mã cho nhóm sắp thêm vào csdl
        /// </summary>
        /// <returns> mã nhóm</returns>
        public static int TuDongLayMaNhom()
        {
            try
            {
                return NhomDAO.TuDongLayMaNhom();
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        /// <summary>
        /// Lay danh sach nhom theo ma khach
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve danh sach nhom</returns>
        public static List<NhomDTO> LayDSNhomTheoMaKhach(string p)
        {
            return DAO.NhomDAO.LayDSNhomTheoMaKhach(p);
        }
    }
}
