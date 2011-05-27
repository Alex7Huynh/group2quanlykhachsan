using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
    public class ABSDAO
    {
        public static string duongDanDuLieu = @"../../DataBase/QLKS.mdb";
        private static string chuoiKetNoi = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + duongDanDuLieu;

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
            try
            {
                OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
                ketNoi.Open();
                return ketNoi;
            }
            catch (System.Exception e)
            {
                throw new Exception("Không thể kết nối cơ sở dữ liệu");
            }
        }
    }
}
