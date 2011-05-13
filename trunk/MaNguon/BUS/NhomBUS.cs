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
    }
}
