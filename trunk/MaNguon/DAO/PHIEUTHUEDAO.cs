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
                chuoiLenh = "insert into PHIEUTHUE(MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien) values(@MaPhieuThue, @MaPhong, @NgayThue, @SoNgayThue, @TenKhachHangDaiDien)";
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
                thamSo = new OleDbParameter("@TenKhachHangDaiDien", OleDbType.LongVarChar);
                thamSo.Value = phieu.TenKhachHangDaiDien;
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
                string chuoiLenh = "select MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien from PHIEUTHUE where PHIEUTHUE.MaPhong=@MaPhong";
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
                    phieu.TenKhachHangDaiDien = Doc.GetString(4);
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
        #region 0812033- Bình
        ///////////
        //0812033
        public static string ThemPhieuThue(PHIEUTHUE phieu)
        {
            OleDbConnection link = null;
            string phongDuocDat = string.Empty;
            try
            {
                link = KetNoi();
                // tu dong lay ma phieu thue cho phieu thue can them vao
                phongDuocDat = TuDongLayMaPhieuThue(phieu.MaPhong, link);
                if (phongDuocDat == string.Empty)
                {
                    throw new Exception("Không lấy được mã phiếu thuê! Vui lòng thử lại");
                }
                phieu.MaPhieuThue = phongDuocDat;
                string chuoiLenh;

                chuoiLenh = "insert into PHIEUTHUE(MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien) values('"
                    + phieu.MaPhieuThue + "', '" + phieu.MaPhong + "', '" + phieu.NgayThue + "', '" + phieu.SoNgayThue
                    + "', '" + phieu.TenKhachHangDaiDien + "')";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                try
                {
                    lenh.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Thêm phiếu thất bại! Vui lòng kiểm tra lại thông tin và làm lại lần nữa.");
                }

            }
            catch (Exception ex)
            {
                phongDuocDat = string.Empty;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return phongDuocDat;
        }
        public static bool CapNhatPhieuThue(PHIEUTHUE phieuThue)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;

                chuoiLenh = "Update from PHIEUTHUE Set MaPhieuThue = '" + phieuThue.MaPhieuThue + "', '" + phieuThue.MaPhong + "' Where ";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                try
                {
                    lenh.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin và làm lại 1 lần nữa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return true;
        }
        public static bool XoaPhieuThue(PHIEUTHUE phieuThue)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;

                chuoiLenh = "Delete from PHIEUTHUE Where MaPhieuThue = '" + phieuThue.MaPhieuThue + "'";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);


                try
                {
                    lenh.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Xóa thất bại! Vui lòng kiểm tra lại thông tin và làm lại 1 lần nữa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return true;
        }
        public static List<PHIEUTHUE> LayDSPhieuThueCanToiUu(PHIEUTHUE phieuThue, string strLoaiPhong)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien from PHIEUTHUE Where MaPhong like @LoaiPhong";
                lenh = new OleDbCommand(chuoiLenh, link);
                thamSo = new OleDbParameter("@LoaiPhong", OleDbType.LongVarChar);
                thamSo.Value = strLoaiPhong + "%";
                lenh.Parameters.Add(thamSo);
                OleDbDataReader Doc;
                try
                {
                    Doc = lenh.ExecuteReader();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Không thể lấy danh sách phiếu thuê cần tối ưu! Xin vui lòng thử lại.");
                }

                while (Doc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    try
                    {
                        phieu.MaPhieuThue = Doc.GetString(0);
                        phieu.MaPhong = Doc.GetString(1);
                        phieu.NgayThue = Doc.GetDateTime(2);
                        phieu.SoNgayThue = int.Parse(Doc.GetValue(3).ToString());
                        phieu.TenKhachHangDaiDien = Doc.GetString(4);
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception("Có lỗi trong quá trình đọc dữ liệu! Vui lòng thử lại.");
                    }
                    DateTime ngayTraPhongTam = phieuThue.NgayThue.AddDays(phieuThue.SoNgayThue - 1);
                    DateTime ngayTraPhong = phieu.NgayThue.AddDays(phieu.SoNgayThue - 1);

                    if (ngayTraPhong >= phieuThue.NgayThue && ngayTraPhongTam >= phieu.NgayThue)
                    {
                        if (phieu.NgayThue <= phieuThue.NgayThue)
                        {
                            phieu.DangThue = true;
                        }
                        else
                            phieu.DangThue = false;
                        dsPhieu.Add(phieu);
                    }
                }
            }
            catch (Exception ex)
            {
                dsPhieu = new List<PHIEUTHUE>();
                throw new Exception(ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhieu;
        }
        private static string TuDongLayMaPhieuThue(string maPhong, OleDbConnection link)
        {
            string maPhieuThue = "";
            try
            {
                //link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "select MaPhieuThue From PHIEUTHUE Where MaPhong = " + "'" + maPhong + "'";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader Doc = lenh.ExecuteReader();
                List<int> danhSachMaPhieuThue = new List<int>();
                while (Doc.Read())
                {
                    string strMaPhieuThue = Doc.GetString(0);
                    int iMaPhieuThue = int.Parse(strMaPhieuThue.Substring(6));
                    danhSachMaPhieuThue.Add(iMaPhieuThue);

                }
                if (danhSachMaPhieuThue.Count == 0)
                {
                    maPhieuThue = "PT" + maPhong + 1.ToString("000");
                }
                else
                    maPhieuThue = "PT" + maPhong + (TimSoLonNhat(danhSachMaPhieuThue) + 1).ToString("000");
            }
            catch
            {
                return string.Empty;
            }
            return maPhieuThue;
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
        //// ket thuc ma nguon cua 0812033
        #endregion

        public static List<PHIEUTHUE> TimPhieu(string kieuTimKiem, string maPhieuThue, string tenPhong, string tenKhachHangDaiDien, DateTime ngayBatDauThue, int soNgayThue)
        {
            OleDbConnection ketNoi = null;
            List<PHIEUTHUE> dsPhieuThue = new List<PHIEUTHUE>();
            string chuoiLenh;
            string noiDieuKien = " " + kieuTimKiem + " ";
            try
            {
                ketNoi = KetNoi();
                //tao chuoi lenh truy van co so du lieu
                chuoiLenh = "select PHIEUTHUE.MaPhieuThue, PHIEUTHUE.MaPhong, PHIEUTHUE.NgayThue, PHIEUTHUE.SoNgayThue, PHIEUTHUE.TenKhachHangDaiDien from PHIEUTHUE, PHONG";
                string where = " WHERE ";

                string dieuKien = "";
                if ("".CompareTo(dieuKien) != 0)
                    dieuKien += noiDieuKien;
                dieuKien += "PHONG.MaPhong = PHIEUTHUE.MaPhong";

                if (maPhieuThue != "")
                {
                    if ("".CompareTo(dieuKien) != 0)
                        dieuKien += noiDieuKien;
                    dieuKien += "MaPhieuThue = @MaPhieuThue";
                }
                if (tenPhong != "")
                {
                    if ("".CompareTo(dieuKien) != 0)
                        dieuKien += noiDieuKien;
                    dieuKien += "PHONG.TenPhong like %@TenPhong%";
                }
                if (tenKhachHangDaiDien != "")
                {
                    if ("".CompareTo(dieuKien) != 0)
                        dieuKien += noiDieuKien;
                    dieuKien += "TenKhachHangDaiDien like @TenKhachHangDaiDien";
                }

                if (soNgayThue > 0)
                {
                    if ("".CompareTo(dieuKien) != 0)
                        dieuKien += noiDieuKien + "(";
                    dieuKien += "date(NgayBatDauThue) = @NgayBatDauThue";
                    if ("".CompareTo(dieuKien) != 0)
                        dieuKien += " or ";
                    dieuKien += "SoNgayThue = @SoNgayThue)";
                }

                chuoiLenh += where + dieuKien;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                if (maPhieuThue != "")
                {
                    OleDbParameter pMaPhieuThue = new OleDbParameter("@MaPhieuThue", OleDbType.LongVarChar);
                    pMaPhieuThue.Value = maPhieuThue;
                    lenh.Parameters.Add(pMaPhieuThue);
                }

                if (tenPhong != "")
                {
                    OleDbParameter pTenPhong = new OleDbParameter("@TenPhong", OleDbType.LongVarChar);
                    pTenPhong.Value = tenPhong;
                    lenh.Parameters.Add(pTenPhong);
                }

                if (tenKhachHangDaiDien != "")
                {
                    OleDbParameter pTenKhachHangDaiDien = new OleDbParameter("@TenKhachHangDaiDien", OleDbType.LongVarChar);
                    pTenKhachHangDaiDien.Value = tenKhachHangDaiDien;
                    lenh.Parameters.Add(pTenKhachHangDaiDien);
                }

                if (soNgayThue > 0)
                {
                    OleDbParameter pNgayBatDauThue = new OleDbParameter("@NgayBatDauThue", OleDbType.Date);
                    pNgayBatDauThue.Value = ngayBatDauThue;
                    lenh.Parameters.Add(pNgayBatDauThue);

                    OleDbParameter pSoNgayThue = new OleDbParameter("@SoNgayThue", OleDbType.Integer);
                    pSoNgayThue.Value = soNgayThue;
                    lenh.Parameters.Add(pSoNgayThue);
                }

                OleDbDataReader boDoc = lenh.ExecuteReader();

                while (boDoc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    if (!boDoc.IsDBNull(0))
                        phieu.MaPhieuThue = boDoc.GetString(0);
                    if (!boDoc.IsDBNull(1))
                        phieu.MaPhong = boDoc.GetString(1);
                    phieu.NgayThue = boDoc.GetDateTime(2);
                    phieu.SoNgayThue = int.Parse(boDoc.GetValue(3).ToString());
                    if (!boDoc.IsDBNull(4))
                        phieu.TenKhachHangDaiDien = boDoc.GetString(4);

                    dsPhieuThue.Add(phieu);
                }
            }
            catch (Exception ex)
            {
                //lam trong danh sach phong
                dsPhieuThue = new List<PHIEUTHUE>();
            }
            finally
            {
                //dong ket noi co so du lieu
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return dsPhieuThue;
        }

        //0812251...Nhom 13 them de test chuc nang checkin do chuc nang dat phong chua co. Nen test = tinh trang dang free
        public static List<PHIEUTHUE> LayDSPhieuThueTheoTinhTrangPhong(PHONG phong)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select pt.MaPhieuThue, p.MaPhong, pt.NgayThue, pt.SoNgayThue, pt.TenKhachHangDaiDien from PHIEUTHUE pt, PHONG p where pt.MaPhong = p.MaPhong and p.Tinhtrang = @TinhTrang ";
                lenh = new OleDbCommand(chuoiLenh, link);
                thamSo = new OleDbParameter("@TinhTrang", OleDbType.LongVarChar);
                thamSo.Value = phong.TinhTrang;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    phieu.MaPhieuThue = Doc.GetString(0);
                    phieu.MaPhong = Doc.GetString(1);
                    phieu.NgayThue = Doc.GetDateTime(2);
                    phieu.SoNgayThue = int.Parse(Doc.GetValue(3).ToString());
                    phieu.TenKhachHangDaiDien = Doc.GetString(4);
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

        public static int layTongSoNgayThue(PHONG phong)
        {
            int ketqua = 0;
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien from PHIEUTHUE where PHIEUTHUE.MaPhong=@MaPhong";
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
                    phieu.TenKhachHangDaiDien = Doc.GetString(4);
                    ketqua += phieu.SoNgayThue;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return ketqua;

        }
    }
}
