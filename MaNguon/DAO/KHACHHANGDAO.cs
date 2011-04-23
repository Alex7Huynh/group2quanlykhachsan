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
                throw ex;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsKH;
        }

        /// <summary>
        /// Lấy danh sách khách hàng theo mã KH
        /// </summary>
        /// <author>Nhóm 13</author>
        /// <param name="maKH">Mã KH kiểu string</param>
        /// <returns>Danh sach khach hang</returns>
        public static List<KHACHHANG> LayDSKhachTheoMaKH(string maKH)
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG where MaKH like" + "'%" + maKH + "'"
                    + "OR MaKH like" + "'" + maKH + "%'"
                    + "OR MaKH like" + "'%" + maKH + "%'";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo = new OleDbParameter("@maKH", OleDbType.VarChar);
                thamSo.Value = maKH;

                lenh.Parameters.Add(thamSo);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public static List<KHACHHANG> LayDSKhachTheoHoTen(string HoTen)
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG where HoTen like" + "'%" + HoTen + "'"
                    + "OR HoTen like" + "'" + HoTen + "%'"
                    + "OR HoTen like" + "'%" + HoTen + "%'";
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

        public static List<KHACHHANG> LayDSKhachTheoSoGiayTo(string SoGiayTo)
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG where SoGiayTo like" + "'%" + SoGiayTo + "'"
                    + "OR SoGiayTo like" + "'" + SoGiayTo + "%'"
                    + "OR SoGiayTo like" + "'%" + SoGiayTo + "%'";
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

        public static List<KHACHHANG> LayDSKhachTheoDiaChi(string DiaChi)
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG where DiaChi like" + "'%" + DiaChi + "'"
                    + "OR DiaChi like" + "'" + DiaChi + "%'"
                    + "OR DiaChi like" + "'%" + DiaChi + "%'";
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

        public static List<KHACHHANG> LayDSKhachTheoLoaiKH(string LoaiKH)
        {
            OleDbConnection link = null;
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaKH, HoTen, KH.MaLoaiKH, DiaChi, SoGiayTo from KHACHHANG KH, LOAIKHACH LK where KH.MaLoaiKH = LK.MaLoaiKH AND TenLoaiKH like" + "'" + LoaiKH + "'";
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
