using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PHIEUTHUEBUS
    {
        static LOAIPHONG _loaiPhongCanToiUu;

        public static LOAIPHONG LoaiPhongCanToiUu
        {
            get { return _loaiPhongCanToiUu; }
            set { _loaiPhongCanToiUu = value; }
        }


        public static bool ThemPhieu(PHIEUTHUE phieu)
        {
            return PHIEUTHUEDAO.ThemPhieu(phieu);
        }
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(phong);
        }

        public static bool ToiUuPhieuThue(LOAIPHONG loaiPhong)
        {
            PHIEUTHUEBUS.LoaiPhongCanToiUu = loaiPhong;
            return TryToiUuPhieuThue(0);
        }

        private static bool TryToiUuPhieuThue(int phieuThue)
        {
            List<PHONG> dsPhong = PHONGBUS.LayDSPhongTheoLoaiPhong(LoaiPhongCanToiUu);
            for (int  i = 0; i < dsPhong.Count; i++)
            {
            }
            return false;
        }
    }
}
