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
        public static bool ThemPhieu(PHIEUTHUE phieu)
        {
            return PHIEUTHUEDAO.ThemPhieu(phieu);
        }
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(phong);
        }

        public static bool ptbToiUuPhieuThue()
        {
            throw new NotImplementedException();
        }
    }
}
