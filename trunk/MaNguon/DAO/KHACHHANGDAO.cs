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
        #region 0812388
        /// <summary>
        /// Lay chinh xac khach hang theo so giay to tuy than
        /// </summary>
        /// <param name="SoGiayTo">so giay to tuy than</param>
        /// <returns>khach hang tuong ung</returns>
        public static KHACHHANG LayKhachTheoSoGiayToChinhXac(string SoGiayTo)
        {
            OleDbConnection link = null;
            KHACHHANG kh = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from KHACHHANG where SoGiayTo = '" + SoGiayTo + "'";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    kh = new KHACHHANG();
                    kh.MaKH = Doc.GetString(0);
                    kh.HoTen = Doc.GetString(1);
                    kh.MaLoaiKH = Doc.GetString(2);
                    kh.DiaChi = Doc.GetString(3);
                    kh.SoGiayTo = Doc.GetString(4);
                    
                }
            }
            catch (Exception ex)
            {
                kh = null;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return kh;
        }
        #endregion

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
        //0812033
        public static string TuDongLayMaKhachHang()
        {
            string maKhachHang = "";
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "select MaKH From KHACHHANG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader Doc = lenh.ExecuteReader();
                List<int> danhSachMaKhachHang = new List<int>();
                while (Doc.Read())
                {
                    string strMaKhachHang = Doc.GetString(0);
                    int iMaKhachHang = int.Parse(strMaKhachHang.Substring(2));
                    danhSachMaKhachHang.Add(iMaKhachHang);

                }
                if (danhSachMaKhachHang.Count == 0)
                {
                    maKhachHang = "KH" + 1.ToString("000");
                }
                else
                    maKhachHang = "KH" + (TimSoLonNhat(danhSachMaKhachHang) + 1).ToString("000");
            }
            catch
            {
                throw new Exception("Không lấy được mã khách hàng");
            }
            return maKhachHang;
        }
        private static int TimSoLonNhat(List<int> danhSach)
        {
            int lonNhat = danhSach[0];
            for (int i = 1; i < danhSach.Count; i++)
            {
                if (danhSach[i] > lonNhat)
                {
                    lonNhat = danhSach[i];
                }
            }
            return lonNhat;
        }
        public static void ThemKhachHang(KHACHHANG khachHang)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "insert into KhachHang values(@MaKhachHang,@TenKhachHang,@MaLoaiKhachHang,@DiaChi,@SoGiayTo)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo = new OleDbParameter("@MaKhachHang", OleDbType.LongVarChar);
                thamSo.Value = khachHang.MaKH;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TenKhachHang", OleDbType.LongVarChar);
                thamSo.Value = khachHang.HoTen;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MaLoaiKhachHang", OleDbType.LongVarChar);
                thamSo.Value = khachHang.MaLoaiKH;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@DiaChi", OleDbType.LongVarChar);
                thamSo.Value = khachHang.DiaChi;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@SoGiayTo", OleDbType.LongVarChar);
                thamSo.Value = khachHang.SoGiayTo;
                lenh.Parameters.Add(thamSo);
                /*thamSo = new OleDbParameter("@DaXoa", OleDbType.LongVarChar);
                thamSo.Value = 0;
                lenh.Parameters.Add(thamSo);*/
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Không thêm khách hàng được");
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
        }
        //end 0812033
    }
}
