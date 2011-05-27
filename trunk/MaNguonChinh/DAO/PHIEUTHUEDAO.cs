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
        /// <summary>
        /// Lay danh sach phue thue theo phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve danh sach cac phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select * from PHIEUTHUE where PHIEUTHUE.MaPhong=@MaPhong and PHIEUTHUE.DaXoa = 0";
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
        /// <summary>
        /// Them phieu thue
        /// </summary>
        /// <param name="phieu"></param>
        /// <returns>Tra ve ma phong duoc dat</returns>
        public static string ThemPhieuThue(PHIEUTHUE phieu)
        {
            OleDbConnection link = null;
            string phongDuocDat = string.Empty;
            try
            {
                link = KetNoi();
                // kiem tra phieu thue 
                KiemTraPhieuThue(link, phieu);
                // tu dong lay ma phieu thue cho phieu thue can them vao
                phongDuocDat = TuDongLayMaPhieuThue(phieu.MaPhong, link);
                if (phongDuocDat == string.Empty)
                {
                    throw new Exception("Không lấy được mã phiếu thuê! Vui lòng thử lại");
                }
                phieu.MaPhieuThue = phongDuocDat;
                string chuoiLenh;

                chuoiLenh = "insert into PHIEUTHUE values('"
                    + phieu.MaPhieuThue + "', '" + phieu.MaPhong + "', '" + phieu.NgayThue + "'," + phieu.SoNgayThue
                    + ", '" + phieu.TenKhachHangDaiDien + "', 0," + phieu.MaNhom + ",0,0)";
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
        /// <summary>
        /// Kiem tra phong con trong hay khong
        /// </summary>
        /// <param name="phieu"></param>
        public static void KiemTraPhieuThue(OleDbConnection ketNoi, PHIEUTHUE phieu)
        {
            string chuoiLenh = "select MaPhieuThue From PHIEUTHUE Where MaPhong like " + "'" + phieu.MaPhong + "' and NgayThue like '" + phieu.NgayThue.ToShortDateString() + "'";
            OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
            OleDbDataReader Doc;
            string maPhieuThue = "";
            try
            {
                Doc = lenh.ExecuteReader();
            }
            catch (System.Exception e)
            {
                throw new Exception("Không thể lấy mã phiếu thuê để kiểm tra! Xin vui lòng thử lại.");
            }

            if (Doc.HasRows)
                throw new Exception("Phòng không còn trống! Vui lòng đặt phòng khác.");
        }
        /// <summary>
        /// Cap nhat phieu thue
        /// </summary>
        /// <param name="danhSachCapNhat"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool CapNhatPhieuThue(List<PHIEUTHUE> danhSachCapNhat)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                for (int i = 0; i < danhSachCapNhat.Count; i++)
                {
                    chuoiLenh = "Update PHIEUTHUE Set MaPhong = '" + danhSachCapNhat[i].MaPhong + "' Where MaPhieuThue = '" + danhSachCapNhat[i].MaPhieuThue + "'";
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
        /// <summary>
        /// Tra phong
        /// </summary>
        /// <param name="danhSachCapNhat"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool TraPhong(List<PHIEUTHUE> danhSachCapNhat)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                for (int i = 0; i < danhSachCapNhat.Count; i++)
                {
                    chuoiLenh = "Update PHIEUTHUE Set DangThue = 1, DaXoa = 1 Where MaPhieuThue = '" + danhSachCapNhat[i].MaPhieuThue + "'";
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
        /// <summary>
        /// Xoa phieu thue
        /// </summary>
        /// <param name="phieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaPhieuThue(PHIEUTHUE phieuThue)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;

                chuoiLenh = "Update PHIEUTHUE Set DaXoa = 1 Where MaPhieuThue = '" + phieuThue.MaPhieuThue + "'";
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
        /// <summary>
        /// Xoa tam phieu thue
        /// </summary>
        /// <param name="dsMaPhieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaTamPhieuThue(List<string> dsMaPhieuThue)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                for (int i = 0; i < dsMaPhieuThue.Count; i++)
                {
                    chuoiLenh = "Update PHIEUTHUE Set DaXoa = 1 Where MaPhieuThue = '" + dsMaPhieuThue[i] + "'";
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
        /// <summary>
        /// Xoa tat ca phieu thue trong danh sach phieu thue
        /// </summary>
        /// <param name="dsMaPhieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaPhieuThue(List<string> dsMaPhieuThue)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                for (int i = 0; i < dsMaPhieuThue.Count; i++)
                {
                    chuoiLenh = "Delete from PHIEUTHUE Where MaPhieuThue = '" + dsMaPhieuThue[i] + "'";
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
        /// <summary>
        /// Lay danh sach phieu thue can toi uu
        /// </summary>
        /// <param name="phieuThue"></param>
        /// <param name="strLoaiPhong"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueCanToiUu(PHIEUTHUE phieuThue, string strLoaiPhong)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select * from PHIEUTHUE Where MaPhong like @LoaiPhong and DaXoa = 0 and DangThue = true";
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
                    if (phieu.NgayThue.Month == 5)
                    {
                        int a = 0;
                    }
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
        /// <summary>
        /// Tu dong lay ma phieu thue (can OleDbConnection)
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="link"></param>
        /// <returns>Tra ve ma phieu thue</returns>
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
        /// <summary>
        /// Tu dong lay ma phieu thue
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve ma phieu thue</returns>
        public static string TuDongLayMaPhieuThue(string maPhong)
        {
            string maPhieuThue = "";
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
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
        /// <summary>
        /// Tim so lon nhat
        /// </summary>
        /// <param name="danhSach"></param>
        /// <returns>Tra ve so lon nhat</returns>
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
        /// <summary>
        /// Lay don gia trong danh sach phieu thue
        /// </summary>
        /// <param name="dsPhieu"></param>
        /// <returns>Tra ve danh sach don gia</returns>
        public static List<int> LayDonGia(List<PHIEUTHUE> dsPhieu)
        {
            OleDbConnection link = null;
            List<int> ds = new List<int>();
            try
            {
                link = KetNoi();
                string chuoiLenh;
                string maLoaiPhong = "";
                for (int index = 0; index < dsPhieu.Count; ++index)
                {
                    maLoaiPhong = dsPhieu[index].MaPhong.Substring(0, 1);
                    chuoiLenh = "select DonGia From LOAIPHONG Where MaLoaiPhong = " + "'" + maLoaiPhong + "'";
                    OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                    OleDbDataReader Doc = lenh.ExecuteReader();
                    while (Doc.Read())
                    {
                        int donGia = Doc.GetInt32(0);
                        ds.Add(donGia);

                    }
                }
                return ds;
            }
            catch
            {
                throw new Exception("Không lấy đơn giá được");
            }
        }
        /// <summary>
        /// Tim phieu thue
        /// </summary>
        /// <param name="kieuTimKiem"></param>
        /// <param name="maPhieuThue"></param>
        /// <param name="tenPhong"></param>
        /// <param name="tenKhachHangDaiDien"></param>
        /// <param name="ngayBatDauThue"></param>
        /// <param name="soNgayThue"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
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
        /// <summary>
        /// Lay danh sach phieu thue theo tinh trang phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
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
        /// <summary>
        /// Lay tong so ngay thue phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve tong so ngay thue phong</returns>
        public static int LayTongSoNgayThue(PHONG phong)
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
        /// <summary>
        /// Lay danh sach phieu thue chua checkin
        /// </summary>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueChuaCheckin()
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select pt.MaPhieuThue,pt.MaPhong, pt.NgayThue, pt.SoNgayThue, pt.TenKhachHangDaiDien from PHIEUTHUE pt  where pt.dangthue=" + false.ToString();
                lenh = new OleDbCommand(chuoiLenh, link);
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
                throw new Exception(ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhieu;
        }
        /// <summary>
        /// Lay danh sach phieu thue theo ma phieu thue
        /// </summary>
        /// <param name="_maphieuthue"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayPhieuThueTheoMa(string _maphieuthue)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select pt.MaPhieuThue,pt.MaPhong, pt.NgayThue, pt.SoNgayThue, pt.TenKhachHangDaiDien, pt.DangThue, pt.DaThanhToan from PHIEUTHUE pt  where pt.MaPhieuThue like '" + _maphieuthue + "'";
                lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    phieu.MaPhieuThue = Doc.GetString(0);
                    phieu.MaPhong = Doc.GetString(1);
                    phieu.NgayThue = Doc.GetDateTime(2);
                    phieu.SoNgayThue = int.Parse(Doc.GetValue(3).ToString());
                    phieu.TenKhachHangDaiDien = Doc.GetString(4);
                    phieu.DangThue = Doc.GetBoolean(5);
                    phieu.DaThanhToan = Doc.GetBoolean(6);
                    dsPhieu.Add(phieu);
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
        /// <summary>
        /// Cap nhat checkin
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="_Dangthue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool UpdateCheckin(PHIEUTHUE pt, bool _Dangthue)
        {
            bool kq = false;
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();
            OleDbParameter thamSo = new OleDbParameter();
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "update  PHIEUTHUE set dangthue= " + _Dangthue + " where Maphieuthue like'" + pt.MaPhieuThue + "'";
                lenh = new OleDbCommand(chuoiLenh, link);
                lenh.ExecuteNonQuery();
                kq = true;
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
            return kq;



        }
        /// <summary>
        /// Lay danh sach phieu thue chua thanh toan theo ma nhom
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueChuaThanhToanTheoMaNhom(int p)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();

            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select * from PHIEUTHUE where MaNhom=@MaNhom and DaThanhToan=@DaThanhToan";
                lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaNhom", p);
                lenh.Parameters.AddWithValue("@DaThanhToan", false);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    dsPhieu.Add(new PHIEUTHUE
                    {
                        MaPhieuThue = boDoc.GetString(0),
                        MaPhong = boDoc.GetString(1),
                        NgayThue = boDoc.GetDateTime(2),
                        SoNgayThue = int.Parse(boDoc.GetValue(3).ToString()),
                        TenKhachHangDaiDien = boDoc.GetString(4),
                        DangThue = boDoc.GetBoolean(5),
                        MaNhom = boDoc.GetInt32(6),
                    });
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
        /// <summary>
        /// Checkin phieu thue
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool CheckinPhieuThue(string p)
        {
            OleDbConnection link = null;
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "UPDATE PHIEUTHUE SET DangThue = true where MaPhieuThue=@MaPhieuThue";
                lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaPhieuThue", p);
                lenh.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }

        }
        /// <summary>
        /// Checkout phieu thue
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool CheckoutPhieuThue(string p)
        {
            OleDbConnection link = null;
            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "UPDATE PHIEUTHUE SET DangThue = false, DaXoa = true, DaThanhToan = true where MaPhieuThue=@MaPhieuThue";
                lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaPhieuThue", p);
                lenh.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }

        }
        /// <summary>
        /// Lay danh sach phieu thue chua checkin theo ma nhom
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueChuaCheckinTheoMaNhom(int p)
        {
            OleDbConnection link = null;
            List<PHIEUTHUE> dsPhieu = new List<PHIEUTHUE>();

            OleDbCommand lenh = new OleDbCommand();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select * from PHIEUTHUE where MaNhom=@MaNhom and DangThue=@DangThue";
                lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaNhom", p);
                lenh.Parameters.AddWithValue("@DangThue", false);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    dsPhieu.Add(new PHIEUTHUE
                    {
                        MaPhieuThue = boDoc.GetString(0),
                        MaPhong = boDoc.GetString(1),
                        NgayThue = boDoc.GetDateTime(2),
                        SoNgayThue = int.Parse(boDoc.GetValue(3).ToString()),
                        TenKhachHangDaiDien = boDoc.GetString(4),
                        DangThue = boDoc.GetBoolean(5),
                        MaNhom = boDoc.GetInt32(6),
                    });
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
