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
            return HOADONDAO.layDSHoaDon();
        }
    }
}
