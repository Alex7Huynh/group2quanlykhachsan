using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class KHACHHANGBUS
    {
        public static List<KHACHHANG> LayDSKhach()
        {
            return KHACHHANGDAO.LayDSKhach();
        }
    }
}
