using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class LOAIKHACHDAO : ABSDAO
    {
        public static List<LOAIKHACH> LayDSLoaiKhach()
        {
            OleDbConnection link = null;
            List<LOAIKHACH> dsLoaiKH = new List<LOAIKHACH>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from LOAIKHACH";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    LOAIKHACH LK = new LOAIKHACH();
                    LK.MaLoaiKH = Doc.GetString(0);
                    LK.TenLoaiKH = Doc.GetString(1);
                    LK.HeSo = Doc.GetInt16(2);
                    dsLoaiKH.Add(LK);
                }
            }
            catch (Exception ex)
            {
                dsLoaiKH = new List<LOAIKHACH>();
                throw ex;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsLoaiKH;
        }
    }
}
