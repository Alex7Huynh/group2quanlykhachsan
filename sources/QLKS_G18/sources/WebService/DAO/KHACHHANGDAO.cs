using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class KHACHHANGDAO : ABSDAO
    {
        public static List<KHACHHANG> LayDSKhach()
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);


                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.MaKH = Doc.GetString(0);
                    kh.HoTen = Doc.GetString(1);
                    kh.MaLoaiKH = Doc.GetString(2);
                    kh.DiaChi = Doc.GetString(3);
                    kh.SoGiayTo = Doc.GetString(4);
                    dsKH.Add(kh);
                }
            }
            catch (Exception ex)
            {
                dsKH = new List<KHACHHANG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsKH;
        }
    }
}
