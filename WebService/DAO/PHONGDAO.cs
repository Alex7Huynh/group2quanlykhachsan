using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class PHONGDAO : ABSDAO
    {
        public static List<PHONG> LayDSPhong()
        {
            OleDbConnection link = null;
            List<PHONG> dsPhong = new List<PHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrang from PHONG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHONG phg = new PHONG();
                    phg.MaPhong = Doc.GetString(0);
                    phg.TenPhong = Doc.GetString(1);
                    phg.MaLoaiPhong = Doc.GetString(2);
                    phg.GhiChu = Doc.GetString(3);
                    phg.TinhTrang = Doc.GetString(4);

                    dsPhong.Add(phg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<PHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }
        public static List<LOAIPHONG> LayDSLoaiPhong()
        {
            OleDbConnection link = null;
            List<LOAIPHONG> dsPhong = new List<LOAIPHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaLoaiPhong, TenLoaiPhong, DonGia, SLKhachToiDa from LOAIPHONG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    LOAIPHONG lphg = new LOAIPHONG();
                    lphg.MaLoaiPhong = Doc.GetString(0);
                    lphg.TenLoaiPhong = Doc.GetString(1);
                    lphg.DonGia = Doc.GetInt32(2);
                    lphg.SLKhachToiDa = Doc.GetInt32(3);
                    dsPhong.Add(lphg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<LOAIPHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }
        public static void ThemPhong(PHONG phong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "insert into PHONG(MaPhong,TenPhong,MaLoaiPhong,TinhTrang,GhiChu) values(@MaPhong,@TenPhong,@MaLoaiPhong,@TinhTrang,@GhiChu)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TenPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.TenPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MaLoaiPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaLoaiPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TinhTrang", OleDbType.LongVarChar);
                thamSo.Value = phong.TinhTrang;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@GhiChu", OleDbType.LongVarChar);
                thamSo.Value = phong.GhiChu;
                lenh.Parameters.Add(thamSo);
                lenh.ExecuteNonQuery();
                OleDbDataAdapter Adapter = new OleDbDataAdapter();
                Adapter.InsertCommand = lenh;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
        }
        public static void XoaPhong(string MaPhong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                //xét nếu không có người ở hay đặt phòng thì mới xóa <===
                string chuoiLenh = "delete from PHONG where (MaPhong=@MaPhong)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = MaPhong;
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

        public static List<PHONG> LayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            OleDbConnection link = null;
            List<PHONG> dsPhong = new List<PHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrang from PHONG where PHONG.MaLoaiPhong = @MaLoaiPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaLoaiPhong", OleDbType.LongVarChar);
                thamSo.Value = loaiPhong.MaLoaiPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHONG phg = new PHONG();
                    phg.MaPhong = Doc.GetString(0);
                    phg.TenPhong = Doc.GetString(1);
                    phg.MaLoaiPhong = Doc.GetString(2);
                    phg.GhiChu = Doc.GetString(3);
                    phg.TinhTrang = Doc.GetString(4);

                    dsPhong.Add(phg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<PHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }
    }
}