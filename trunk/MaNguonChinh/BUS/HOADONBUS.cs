using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class HOADONBUS
    {
        /// <summary>
        /// Lay danh sach hoa don
        /// </summary>
        /// <returns>Tra ve danh sach hoa don</returns>
        public static List<HOADON> layDSHoaDon()
        {
            return HOADONDAO.LayDSHoaDon();
        }
        /// <summary>
        /// Lay ma hoa don
        /// </summary>
        /// <returns>Tra ve ma hoa don</returns>
        public static string LayMaHoaDon()
        {
            string maHoaDonMoi = "HD";
            int soHoaDon = DAO.HOADONDAO.DemSoLuongHoaDon();
            if (soHoaDon == -1)
                return null;
            maHoaDonMoi += (soHoaDon+ 1).ToString("000");
            return maHoaDonMoi;
        }
        /// <summary>
        /// THem hoa don moi
        /// </summary>
        /// <param name="hd"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool ThemHoaDonMoi(HOADON hd)
        {
            return DAO.HOADONDAO.ThemHoaDonMoi(hd);
        }
    }
}
