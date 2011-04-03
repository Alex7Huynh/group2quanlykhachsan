using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class HOADONDAO :ABSDAO
    {
        public static List<HOADON> layDSHoaDon()
        {
            OleDbConnection link = null;
            List<HOADON> dsHoaDon = new List<HOADON>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select MaHoaDon, TenKhachHang, NgayThanhToan, ThanhTien, MaPhieuThue from HOADON";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    HOADON hd = new HOADON();
                    hd.MaHoaDon =Doc.GetString(0);
                    hd.TenKhachHang =Doc.GetString(1);
                    hd.NgayThanhToan =Doc.GetDateTime(2);
                    hd.Thanhtien =Doc.GetInt32(3);
                    hd.MaPhieuThue = Doc.GetString(4);
                    dsHoaDon.Add(hd);
                }
            }
            catch (Exception ex)
            {
                dsHoaDon = new List<HOADON>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsHoaDon;
        }
    }
}
