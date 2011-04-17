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
                    throw new Exception("Khong lay duoc ma phieu thue!");
                }
                phieu.MaPhieuThue = phongDuocDat;
                string chuoiLenh;

                chuoiLenh = "insert into PHIEUTHUE(MaPhieuThue, MaPhong, NgayThue, SoNgayThue, TenKhachHangDaiDien) values('"
                    + phieu.MaPhieuThue + "', '" + phieu.MaPhong + "', '" + phieu.NgayThue + "', '" + phieu.SoNgayThue
                    + "', '" + phieu.TenKhachHangDaiDien + "')";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);


                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                phongDuocDat = string.Empty;
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

                chuoiLenh = "Update from PHIEUTHUE Set MaPhieuThue = '"+ phieuThue.MaPhieuThue + "', '" + phieuThue.MaPhong + "' Where ";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);


                lenh.ExecuteNonQuery();
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


                lenh.ExecuteNonQuery();
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

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHIEUTHUE phieu = new PHIEUTHUE();
                    phieu.MaPhieuThue = Doc.GetString(0);
                    phieu.MaPhong = Doc.GetString(1);
                    phieu.NgayThue = Doc.GetDateTime(2);
                    phieu.SoNgayThue = int.Parse(Doc.GetValue(3).ToString());
                    phieu.TenKhachHangDaiDien = Doc.GetString(4);
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
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhieu;
        }
        // lay phieu thue co ngay thue nho nhat
        private static DateTime LayNgayPhieuThueCuNhat(List<PHIEUTHUE> danhSachPhieuThue)
        {
            DateTime ngayCuNhat = danhSachPhieuThue[0].NgayThue;
            for (int i = 0; i < danhSachPhieuThue.Count; i++)
            {
                if (danhSachPhieuThue[i].NgayThue < ngayCuNhat)
                {
                    ngayCuNhat = danhSachPhieuThue[i].NgayThue;
                }
            }
            return ngayCuNhat;
        }
        private static DateTime LayNgayPhieuThueXaNhat(List<PHIEUTHUE> danhSachPhieuThue)
        {
            DateTime ngayXaNhat = danhSachPhieuThue[0].NgayThue;
            for (int i = 0; i < danhSachPhieuThue.Count; i++)
            {
                if (danhSachPhieuThue[i].NgayThue > ngayXaNhat)
                {
                    ngayXaNhat = danhSachPhieuThue[i].NgayThue;
                }
            }
            return ngayXaNhat;
        }
        private static PHIEUTHUE LayPhieuThueXaNhat(List<PHIEUTHUE> danhSachPhieuThue)
        {
            DateTime ngayXaNhat = danhSachPhieuThue[0].NgayThue;
            int index = 0;
            for (int i = 0; i < danhSachPhieuThue.Count; i++)
            {
                if (danhSachPhieuThue[i].NgayThue > ngayXaNhat)
                {
                    ngayXaNhat = danhSachPhieuThue[i].NgayThue;
                    index = i;
                }
            }
            return danhSachPhieuThue[index];
        }
        private static int TimPhongTotNhat(PHIEUTHUE phieuThueMoi, int viTriLoaiPhong)
        {
            int viTriPhong = -1;
            int max = 365;
            int[][] soDoTinhTrangPhong = new int[0][];
            int viTriNgay = 0;
            List<PHIEUTHUE> danhSachPhieuThue = LayDSPhieuThueCanToiUu(phieuThueMoi, phieuThueMoi.MaPhong);
            // neu cac phong deu trong thi mac dinh chon phong thu nhat
            if (danhSachPhieuThue.Count == 0)
            {
                return 0;
            }
            soDoTinhTrangPhong = ToiUuPhieuThue(phieuThueMoi, danhSachPhieuThue, ref viTriNgay);
            for (int i = viTriLoaiPhong; i < soDoTinhTrangPhong.Length; i++)
            {
                if (soDoTinhTrangPhong[i][viTriNgay] == phieuThueMoi.SoNgayThue)
                {
                    viTriPhong = i;
                    // thoat vong lap
                    i = soDoTinhTrangPhong.Length;
                }
                else if (soDoTinhTrangPhong[i][viTriNgay] < max && phieuThueMoi.SoNgayThue < soDoTinhTrangPhong[i][viTriNgay])
                {
                    max = soDoTinhTrangPhong[i][phieuThueMoi.SoNgayThue - 1];
                    viTriPhong = i;
                }
            }

            return viTriPhong;
        }
        public static string DatPhieuThue(PHIEUTHUE phieuThue, string strLoaiPhong)
        {
            string phongDuocDat = string.Empty;
            List<PHONG> danhSachLoaiPhong = PHONGDAO.LayDSPhong();
            int viTriPhongThue = 0;
            for (int i = 0; i < danhSachLoaiPhong.Count; i++)
            {
                if (danhSachLoaiPhong[i].MaPhong.Substring(0, 1).CompareTo(strLoaiPhong) == 0)
                {
                    viTriPhongThue = i;
                    i = danhSachLoaiPhong.Count;
                }
            }
            int phongTotNhat = TimPhongTotNhat(phieuThue, viTriPhongThue);
            if (phongTotNhat != -1)
            {
                string maPhong = strLoaiPhong + (phongTotNhat + 1).ToString("000");
                phieuThue.MaPhong = maPhong;
                phongDuocDat = ThemPhieuThue(phieuThue);
            }
            return phongDuocDat;
        }
        // dieu chinh thuoc tinh dangThue cua danh sach phieu thue

        private static int LaySoPhongTheoLoai(string strLoaiPhong)
        {
            LOAIPHONG loaiPhong = new LOAIPHONG();
            loaiPhong.MaLoaiPhong = strLoaiPhong;
            return PHONGDAO.LayDSPhongTheoLoaiPhong(loaiPhong).Count;
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
        private static void CapNhatPhieuThueDaToiUu(List<PHIEUTHUE> nguon, List<PHIEUTHUE> dich)
        {
            for (int i = 0; i < nguon.Count; i++ )
            {
                XoaPhieuThue(nguon[i]);
                ThemPhieuThue(dich[i]);
            }
        }
        //// ket thuc ma nguon cua 0812033

        //////////////
        //// 0812 - Phú
        public static int[][] ToiUuPhieuThue(PHIEUTHUE phieuThueMoi, List<PHIEUTHUE> danhSachPhieuThueCanToiUu, ref int viTriNgay)
        {
            int[][] _data = new int[0][];
            List<PHIEUTHUE> _res = new List<PHIEUTHUE>();
            _res = danhSachPhieuThueCanToiUu;

            int soPhong = LaySoPhongTheoLoai(phieuThueMoi.MaPhong);
            int max = 0;

            DateTime ngayPhieuThueCuNhat = LayNgayPhieuThueCuNhat(danhSachPhieuThueCanToiUu);
            PHIEUTHUE phieuThueXaNhat = LayPhieuThueXaNhat(danhSachPhieuThueCanToiUu);
            DateTime ngayPhieuThueMoiNhat = phieuThueXaNhat.NgayThue.AddDays(phieuThueXaNhat.SoNgayThue);

            int soNgayThue = ngayPhieuThueMoiNhat.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;

            viTriNgay = phieuThueMoi.NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;

            Init(ref _data, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
            Stack<List<PHIEUTHUE>> st = new Stack<List<PHIEUTHUE>>();
            if (Rate(_data, soNgayThue, soPhong) > max)
                st.Push(danhSachPhieuThueCanToiUu);
            while (st.Count != 0)
            {
                danhSachPhieuThueCanToiUu = st.Pop();

                Init(ref _data, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
                if (Rate(_data, soNgayThue, soPhong) == max)
                {
                    _res = new List<PHIEUTHUE>();
                    for (int ii = 0; ii < danhSachPhieuThueCanToiUu.Count; ++ii)
                    {
                        _res.Add(new PHIEUTHUE { DangThue = danhSachPhieuThueCanToiUu[ii].DangThue, MaPhong = danhSachPhieuThueCanToiUu[ii].MaPhong, NgayThue = danhSachPhieuThueCanToiUu[ii].NgayThue, SoNgayThue = danhSachPhieuThueCanToiUu[ii].SoNgayThue });
                    }
                }
                for (int i = 0; i < danhSachPhieuThueCanToiUu.Count; ++i)
                {
                    for (int j = 0; j < soPhong; ++j)
                    {
                        int maPhong = int.Parse(danhSachPhieuThueCanToiUu[i].MaPhong.Substring(1));
                        int ngayBatDau = danhSachPhieuThueCanToiUu[i].NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;

                        if (danhSachPhieuThueCanToiUu[i].SoNgayThue <= _data[j][/*_lsPt[i].NgayBatDau*/ngayBatDau] && !danhSachPhieuThueCanToiUu[i].DangThue)
                        {
                            string strMaPhong = danhSachPhieuThueCanToiUu[i].MaPhong[0].ToString();
                            danhSachPhieuThueCanToiUu[i].MaPhong = strMaPhong + (j + 1).ToString("000");
                            //_lsPt[i].MaPhong = j + 1;

                            Init(ref _data, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
                            if (Rate(_data, soNgayThue, soPhong) > max)
                            {
                                max = Rate(_data, soNgayThue, soPhong);
                                _res = new List<PHIEUTHUE>();
                                for (int ii = 0; ii < danhSachPhieuThueCanToiUu.Count; ++ii)
                                {
                                    _res.Add(new PHIEUTHUE { MaPhieuThue = danhSachPhieuThueCanToiUu[ii].MaPhieuThue,
                                                            DangThue = danhSachPhieuThueCanToiUu[ii].DangThue, 
                                                            MaPhong = danhSachPhieuThueCanToiUu[ii].MaPhong, 
                                                            NgayThue = danhSachPhieuThueCanToiUu[ii].NgayThue, 
                                                            SoNgayThue = danhSachPhieuThueCanToiUu[ii].SoNgayThue, 
                                                            TenKhachHangDaiDien = danhSachPhieuThueCanToiUu[ii].TenKhachHangDaiDien });

                                }
                                st.Push(danhSachPhieuThueCanToiUu);
                            }
                        }
                    }
                }

            }
            Init(ref _data, _res, soPhong, soNgayThue);
            CapNhatPhieuThueDaToiUu(danhSachPhieuThueCanToiUu, _res);
            return _data;
        }
        private static void Init(ref int[][] mangDuLieu, List<PHIEUTHUE> _lsPt, int soPhong, int soNgay)
        {
            mangDuLieu = new int[soPhong][];
            for (int i = 0; i < soPhong; ++i)
            {
                mangDuLieu[i] = new int[soNgay];
            }

            for (int i = 0; i < soNgay; ++i)
                for (int j = 0; j < soPhong; ++j)
                {
                    mangDuLieu[j][i] = 0;
                }
            DateTime ngayPhieuThueCuNhat = LayNgayPhieuThueCuNhat(_lsPt);
            for (int i = 0; i < _lsPt.Count; ++i)
            {
                for (int j = 0; j < _lsPt[i].SoNgayThue; ++j)
                {
                    int maPhong = int.Parse(_lsPt[i].MaPhong.Substring(1));
                    int ngayBatDau = _lsPt[i].NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;
                    mangDuLieu[maPhong - 1][ngayBatDau + j] = -(i + 1);
                }
            }

            int check = 1;
            for (int i = 0; i < soPhong; ++i)
            {
                for (int j = soNgay - 1; j >= 0; --j)
                {
                    if (mangDuLieu[i][j] == 0)
                        mangDuLieu[i][j] = check++;
                    else
                        check = 1;
                }
                check = 1;
            }
        }

        private static int Rate(int[][] mangDuLieu, int soNgay, int soPhong)
        {
            int count = 0;
            for (int i = 0; i < soNgay; ++i)
                for (int j = 0; j < soPhong; ++j)
                {
                    if (mangDuLieu[j][i] > 0)
                        count += mangDuLieu[j][i];
                }
            return count;
        }

        //// ket thuc ma nguon cua 0812604

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
    }
}
