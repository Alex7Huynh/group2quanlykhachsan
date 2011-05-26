using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
    public class ABSDAO
    {
        private static string chuoiKetNoi = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=QLKS.mdb";

        public static string ChuoiKetNoi
        {
            get { return ABSDAO.chuoiKetNoi; }
            set { ABSDAO.chuoiKetNoi = value; }
        }
        /// <summary>
        /// Ket noi den co so du lieu
        /// </summary>
        /// <returns>Tra ve OleDbConnection</returns>
        public static OleDbConnection KetNoi()
        {
            OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
