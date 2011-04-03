using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class PHIEUTHUEDAO : ABSDAO
    {
        public static bool ThemPhieu(PHIEUTHUE phieu)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "insert into PHIEUTHUE(MaPhieuThue, MaPhong, NgayThue, SoNgayThue) values(@MaPhieuThue, @MaPhong, @NgayThue, @SoNgayThue)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo = new OleDbParameter("@MP", OleDbType.LongVarChar);
                thamSo = new OleDbParameter("@MaPhieuThue", OleDbType.LongVarChar);
                thamSo.Value = phieu.MaPhieuThue;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phieu.MaPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@SoNgayThue", OleDbType.Integer);
                thamSo.Value = phieu.SoNgayThue;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@NgayThue", OleDbType.Date);
                thamSo.Value = phieu.NgayThue;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return true;
        }
        public static void ThemCTPT(CHITIETPHIEUTHUE chiTietPhieu)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "insert into CHITIETPHIEUTHUE(MaPhieuThue,MaKH, MaChiTietPhieuThue) values (@MaPhieuThue, @MaKH, @MaChiTietPhieuThue)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaPhieuThue", OleDbType.LongVarChar);
                thamSo.Value = chiTietPhieu.MaPhieuThue;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MKH", OleDbType.LongVarChar);
                thamSo.Value = chiTietPhieu.MaKH;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MaChiTietPhieuThue", OleDbType.LongVarChar);
                thamSo.Value = chiTietPhieu.MaChiTietPhieuThue;
                lenh.Parameters.Add(thamSo);
                lenh.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
        }
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select MaPhieuThue, MaPhong, NgayThue, SoNgayThue from PHIEUTHUE where PHIEUTHUE.MaPhong=@MaPhong";
                lenh = new OleDbCommand(chuoiLenh, link);
                thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    phieu.MaPhieuThue = Doc.GetString(0);
                    phieu.MaPhong = Doc.GetString(1);
                    phieu.NgayThue = Doc.GetDateTime(2);
                    phieu.SoNgayThue = int.Parse(Doc.GetValue(3).ToString());
                    dsPhieu.Add(phieu);
                }
            }
            catch (Exception ex)
            {
                dsPhieu = new List<PHIEUTHUE>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhieu;
        }
    }
}
