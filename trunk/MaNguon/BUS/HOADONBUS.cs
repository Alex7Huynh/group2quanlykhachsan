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
        public static List<HOADON> layDSHoaDon()
        {
            return HOADONDAO.LayDSHoaDon();
        }

        public static string LayMaHoaDon()
        {
            string maHoaDonMoi = "HD";
            int soHoaDon = DAO.HOADONDAO.DemSoLuongHoaDon();
            if (soHoaDon == -1)
                return null;
            maHoaDonMoi += (soHoaDon+ 1).ToString("000");
            return maHoaDonMoi;
        }

        public static bool ThemHoaDonMoi(HOADON hd)
        {
            return DAO.HOADONDAO.ThemHoaDonMoi(hd);
        }
    }
}
