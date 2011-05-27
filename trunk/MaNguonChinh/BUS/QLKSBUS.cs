using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class QLKSBUS
    {
        public static void KiemTraKetNoi()
        {
            try
            {
                if (ABSDAO.KetNoi() != null)
                {
                    return;
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}
