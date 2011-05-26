using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PHIEUTHUEBUS
    {
        static LOAIPHONG _loaiPhongCanToiUu;
        public static LOAIPHONG LoaiPhongCanToiUu
        {
            get { return _loaiPhongCanToiUu; }
            set { _loaiPhongCanToiUu = value; }
        }

        static List<PHONG> _dsPhong = new List<PHONG>();
        static List<PHIEUTHUE> _dsPhieuThue = new List<PHIEUTHUE>();
        static int _chiSoPhongTrongMax = 0;

        /// <summary>
        /// Lay danh sach phieu thue theo phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(phong);
        }

        #region 0812033 - Bình        
        /// <summary>
        /// Them phieu thue
        /// </summary>
        /// <param name="phieu"></param>
        /// <returns>Tra ve ma phieu thue</returns>
        public static string ThemPhieuThue(PHIEUTHUE phieu)
        {
            try
            {
                return PHIEUTHUEDAO.ThemPhieuThue(phieu);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Xoa phieu thue
        /// </summary>
        /// <param name="phieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaPhieuThue(PHIEUTHUE phieuThue)
        {
            try
            {
                return PHIEUTHUEDAO.XoaPhieuThue(phieuThue);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Lay ngay phieu thue cu nhat
        /// </summary>
        /// <param name="danhSachPhieuThue"></param>
        /// <returns>Tra ve ngay phieu thue cu nhat</returns>
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
        /// <summary>
        /// Lay ngay phieu thue xa nhat
        /// </summary>
        /// <param name="danhSachPhieuThue"></param>
        /// <returns>Tra ve ngay phieu thue xa nhat</returns>
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
        /// <summary>
        /// Lay phieu thue xa nhat
        /// </summary>
        /// <param name="danhSachPhieuThue"></param>
        /// <returns>Tra ve phieu thue xa nhat</returns>
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
        /// <summary>
        /// Tim phong tot nhat
        /// </summary>
        /// <param name="phieuThueMoi"></param>
        /// <param name="maPhong"></param>
        /// <param name="viTriLoaiPhong"></param>
        /// <returns>Tra ve vi tri phong</returns>
        private static int TimPhongTotNhat(PHIEUTHUE phieuThueMoi, string maPhong, int viTriLoaiPhong)
        {
            int viTriPhong = -1;
            int max = 365;
            int[][] soDoTinhTrangPhong = new int[0][];
            int viTriNgay = 0;
            try
            {
                List<PHIEUTHUE> danhSachPhieuThue = PHIEUTHUEDAO.LayDSPhieuThueCanToiUu(phieuThueMoi, maPhong);
                // neu cac phong deu trong thi mac dinh chon phong thu nhat
                if (danhSachPhieuThue.Count == 0)
                {
                    return 0;
                }
                soDoTinhTrangPhong = ToiUuPhieuThue(phieuThueMoi, maPhong, danhSachPhieuThue, ref viTriNgay);
                if (soDoTinhTrangPhong.Length > 0)
                {
                    for (int i = 0; i < soDoTinhTrangPhong.Length; i++)
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
                }
                return viTriPhong;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Dat phieu thue
        /// </summary>
        /// <param name="phieuThue"></param>
        /// <param name="strLoaiPhong"></param>
        /// <returns>Tra ve ma phong duoc dat</returns>
        public static string DatPhieuThue(PHIEUTHUE phieuThue, string strLoaiPhong)
        {
            string phongDuocDat = string.Empty;
            try
            {
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
                int phongTotNhat = TimPhongTotNhat(phieuThue, strLoaiPhong, viTriPhongThue);
                if (phongTotNhat != -1)
                {
                    string maPhong = strLoaiPhong + (phongTotNhat + 1).ToString("000");
                    phieuThue.MaPhong = maPhong;
                    phongDuocDat = PHIEUTHUEDAO.ThemPhieuThue(phieuThue);
                }
                return phongDuocDat;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Kiem tra dat phieu thue
        /// </summary>
        /// <param name="phieuThue"></param>
        /// <param name="strLoaiPhong"></param>
        /// <param name="dsMaPhieuThueDuocDat"></param>
        /// <returns>Tra ve ma phong</returns>
        public static string KiemTraDatPhieuThue(PHIEUTHUE phieuThue, string strLoaiPhong, ref List<string> dsMaPhieuThueDuocDat)
        {
            string phongDuocDat = string.Empty;
            try
            {
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
                int phongTotNhat = TimPhongTotNhat(phieuThue, strLoaiPhong, viTriPhongThue);
                if (phongTotNhat != -1)
                {
                    string maPhong = strLoaiPhong + (phongTotNhat + 1).ToString("000");
                    phieuThue.MaPhong = maPhong;
                    phongDuocDat = maPhong;
                    string maPhieuThue = PHIEUTHUEDAO.ThemPhieuThue(phieuThue);
                    dsMaPhieuThueDuocDat.Add(maPhieuThue);
                }
                return phongDuocDat;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        // dieu chinh thuoc tinh dangThue cua danh sach phieu thue
        /// <summary>
        /// Lay so phong theo loai
        /// </summary>
        /// <param name="strLoaiPhong"></param>
        /// <returns>Tra ve so phong</returns>
        private static int LaySoPhongTheoLoai(string strLoaiPhong)
        {
            LOAIPHONG loaiPhong = new LOAIPHONG();
            loaiPhong.MaLoaiPhong = strLoaiPhong;
            try
            {
                return PHONGDAO.LayDSPhongTheoLoaiPhong(loaiPhong).Count;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Cap nhat phieu thue da toi uu (can 2 danh sach phieu thue)
        /// </summary>
        /// <param name="nguon"></param>
        /// <param name="dich"></param>
        private static void CapNhatPhieuThueDaToiUu(List<PHIEUTHUE> nguon, List<PHIEUTHUE> dich)
        {
            for (int i = 0; i < nguon.Count; i++)
            {
                try
                {
                    PHIEUTHUEDAO.XoaPhieuThue(nguon[i]);
                    PHIEUTHUEDAO.ThemPhieuThue(dich[i]);
                }
                catch (System.Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }
        /// <summary>
        /// Cap nhat phieu the da toi uu 
        /// </summary>
        /// <param name="dich"></param>
        private static void CapNhatPhieuThueDaToiUu(List<PHIEUTHUE> dich)
        {
                try
                {
                    PHIEUTHUEDAO.CapNhatPhieuThue(dich);
                }
                catch (System.Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
        /// <summary>
        /// Kiem tra
        /// </summary>
        /// <param name="phieu"></param>
        /// <param name="soNguoi"></param>
        /// <param name="dsMaPhieuThueDuocDat"></param>
        /// <returns>Tra ve mang chuoi</returns>
        public static List<string> KiemTra(PHIEUTHUE phieu, ref int soNguoi, ref List<string> dsMaPhieuThueDuocDat)
        {
            List<string> dsPhongDuocDat = new List<string>();
            string phongDuocDat = " ";
            string maPhong = phieu.MaPhong;
            try
            {
                while (phongDuocDat != string.Empty)
                {
                    phongDuocDat = KiemTraDatPhieuThue(phieu, maPhong, ref dsMaPhieuThueDuocDat);
                    if (phongDuocDat != string.Empty)
                    {
                        int soNguoiToiDaCuaPhong = PHONGDAO.LaySoNguoiToiDa(phongDuocDat);
                        soNguoi -= soNguoiToiDaCuaPhong;
                        dsPhongDuocDat.Add(phongDuocDat);
                        if (soNguoi <= 0)
                        {
                            break;
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            return dsPhongDuocDat;
        }
        /// <summary>
        /// Tra phong
        /// </summary>
        /// <param name="danhSachCapNhat"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool TraPhong(List<PHIEUTHUE> danhSachCapNhat)
        {
            return PHIEUTHUEDAO.TraPhong(danhSachCapNhat);
        }
        /// <summary>
        /// Xoa phieu thue
        /// </summary>
        /// <param name="dsMaPhieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaPhieuThue(List<string> dsMaPhieuThue)
        {
            return PHIEUTHUEDAO.XoaPhieuThue(dsMaPhieuThue);
        }
        /// <summary>
        /// Xoa tam phieu thue
        /// </summary>
        /// <param name="dsMaPhieuThue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool XoaTamPhieuThue(List<string> dsMaPhieuThue)
        {
            return PHIEUTHUEDAO.XoaTamPhieuThue(dsMaPhieuThue);
        }
        /// <summary>
        /// Tinh tien
        /// </summary>
        /// <param name="dsPhieu"></param>
        /// <returns>Tra ve dinh dang tien</returns>
        public static string TinhTien(List<PHIEUTHUE> dsPhieu)
        {
            try
            {
                List<int> dsDonGia = PHIEUTHUEDAO.LayDonGia(dsPhieu);
                //string thanhTien = "";
                long soTien = 0;
                int index = 0;
                for (; index < dsDonGia.Count; ++index)
                {
                    soTien += (dsPhieu[index].SoNgayThue * dsDonGia[index]);
                }
                return DinhDangTien(soTien);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Dinh dang tien
        /// </summary>
        /// <param name="soTien"></param>
        /// <returns>Tra ve so tien bang chuoi</returns>
        private static string DinhDangTien(long soTien)
        {
            string giaTien = soTien.ToString();
            string temp = "000 VNĐ";
            string t = "";
            for (int c = giaTien.Length - 1; c >= 0; c -= 3)
            {
                if (c - 3 >= 0)
                {
                    t = giaTien.Substring(c - 2, c + 1);

                }
                else
                {
                    t = giaTien.Substring(0, c + 1);
                }
                temp = t.Insert(t.Length - 1, ".") + temp;
            }
            return temp;
        }
        #endregion

        #region 0812388 - Phú        
        /// <summary>
        /// Hàm thực hiện tối ưu hóa các phiếu thuê phòng
        /// </summary>
        /// <param name="phieuThueMoi">Phiếu thuê mới muốn thêm vào</param>
        /// <param name="danhSachPhieuThueCanToiUu">Danh sách các phiếu thuê hiện có và muốn tối ưu trên các phiếu thuê này</param>
        /// <param name="viTriNgay">Ngay muốn tối ưu</param>
        /// <returns>Sơ đồ tình trạng phòng</returns>
        public static int[][] ToiUuPhieuThue(PHIEUTHUE phieuThueMoi, string maLoaiPhong, List<PHIEUTHUE> danhSachPhieuThueCanToiUu, ref int viTriNgay)
        {
            try
            {
                // khoi tao ma tran de danh gia
                int[][] soDoTinhTrangPhong = new int[0][];
                List<PHIEUTHUE> ketQua = new List<PHIEUTHUE>();
                ketQua = danhSachPhieuThueCanToiUu;

                int soPhong = LaySoPhongTheoLoai(maLoaiPhong);
                int max = 0;

                DateTime ngayPhieuThueCuNhat = LayNgayPhieuThueCuNhat(danhSachPhieuThueCanToiUu);
                PHIEUTHUE phieuThueXaNhat = LayPhieuThueXaNhat(danhSachPhieuThueCanToiUu);
                DateTime ngayPhieuThueMoiNhat = phieuThueXaNhat.NgayThue.AddDays(phieuThueXaNhat.SoNgayThue);

                int soNgayThue = ngayPhieuThueMoiNhat.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;
                if (soNgayThue < phieuThueMoi.SoNgayThue)
                {
                    soNgayThue = phieuThueMoi.SoNgayThue;
                }
                if (ngayPhieuThueCuNhat < phieuThueMoi.NgayThue)
                    viTriNgay = phieuThueMoi.NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;
                else
                    viTriNgay = 0;
                // khoi tao tinh trang ban dau
                KhoiTao(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);

                Stack<List<PHIEUTHUE>> nganXep = new Stack<List<PHIEUTHUE>>();
                // dua vao ngan xep
                if (DanhGia(soDoTinhTrangPhong, soNgayThue, soPhong) > max)
                    nganXep.Push(danhSachPhieuThueCanToiUu);
                // chay thuat toan
                while (nganXep.Count != 0)
                {
                    danhSachPhieuThueCanToiUu = nganXep.Pop();

                    KhoiTao(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);

                    if (DanhGia(soDoTinhTrangPhong, soNgayThue, soPhong) == max) // khi da tim duoc loi giai
                    {
                        ketQua = new List<PHIEUTHUE>();
                        for (int ii = 0; ii < danhSachPhieuThueCanToiUu.Count; ++ii)
                        {
                            ketQua.Add(new PHIEUTHUE { DangThue = danhSachPhieuThueCanToiUu[ii].DangThue, MaPhong = danhSachPhieuThueCanToiUu[ii].MaPhong, NgayThue = danhSachPhieuThueCanToiUu[ii].NgayThue, SoNgayThue = danhSachPhieuThueCanToiUu[ii].SoNgayThue });
                        }
                    }

                    for (int i = 0; i < danhSachPhieuThueCanToiUu.Count; ++i)
                    {
                        for (int j = 0; j < soPhong; ++j)
                        {
                            int maPhong = int.Parse(danhSachPhieuThueCanToiUu[i].MaPhong.Substring(1));
                            int ngayBatDau = danhSachPhieuThueCanToiUu[i].NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;

                            if (danhSachPhieuThueCanToiUu[i].SoNgayThue <= soDoTinhTrangPhong[j][ngayBatDau] && !danhSachPhieuThueCanToiUu[i].DangThue)
                            {
                                string strMaPhong = danhSachPhieuThueCanToiUu[i].MaPhong[0].ToString();
                                danhSachPhieuThueCanToiUu[i].MaPhong = strMaPhong + (j + 1).ToString("000");
                               
                                KhoiTao(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);

                                if (DanhGia(soDoTinhTrangPhong, soNgayThue, soPhong) > max)
                                {
                                    max = DanhGia(soDoTinhTrangPhong, soNgayThue, soPhong);
                                    ketQua = new List<PHIEUTHUE>();
                                    for (int ii = 0; ii < danhSachPhieuThueCanToiUu.Count; ++ii)
                                    {
                                        ketQua.Add(new PHIEUTHUE
                                        {
                                            MaPhieuThue = danhSachPhieuThueCanToiUu[ii].MaPhieuThue,
                                            DangThue = danhSachPhieuThueCanToiUu[ii].DangThue,
                                            MaPhong = danhSachPhieuThueCanToiUu[ii].MaPhong,
                                            NgayThue = danhSachPhieuThueCanToiUu[ii].NgayThue,
                                            SoNgayThue = danhSachPhieuThueCanToiUu[ii].SoNgayThue,
                                            TenKhachHangDaiDien = danhSachPhieuThueCanToiUu[ii].TenKhachHangDaiDien
                                        });
                                    }
                                    nganXep.Push(danhSachPhieuThueCanToiUu);
                                }
                            }
                        }
                    }

                }

                KhoiTao(ref soDoTinhTrangPhong, ketQua, soPhong, soNgayThue);
                CapNhatPhieuThueDaToiUu(ketQua);

                return soDoTinhTrangPhong;
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        /// <summary>
        /// Khởi tạo sơ đồ tình trạng phòng 
        /// </summary>
        /// <param name="mangDuLieu">Sơ đồ tình trạng phòng (ref)</param>
        /// <param name="dsPhieuThue">Danh sách các phiếu thuê muốn lập sơ đồ tình trạng phòng</param>
        /// <param name="soPhong">Số lượng phòng tổng cộng</param>
        /// <param name="soNgay">Số ngày (tính từ ngày của phiếu thuê có ngày sớm nhất đến phiếu thuê kết thúc trễ nhất)</param>
        private static void KhoiTao(ref int[][] mangDuLieu, List<PHIEUTHUE> dsPhieuThue, int soPhong, int soNgay)
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
            DateTime ngayPhieuThueCuNhat = LayNgayPhieuThueCuNhat(dsPhieuThue);
            for (int i = 0; i < dsPhieuThue.Count; ++i)
            {
                for (int j = 0; j < dsPhieuThue[i].SoNgayThue; ++j)
                {
                    int maPhong = int.Parse(dsPhieuThue[i].MaPhong.Substring(1));
                    int ngayBatDau = dsPhieuThue[i].NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;
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
        /// <summary>
        /// Hàm lượng giá cho một sơ đồ tình trạng phòng
        /// </summary>
        /// <param name="mangDuLieu">Sơ đồ tình trạng phòng</param>
        /// <param name="soNgay">Số ngày</param>
        /// <param name="soPhong">Số phòng</param>
        /// <returns>Trị số lượng giá cho sơ đồ tình trạng phòng tương ứng</returns>
        private static int DanhGia(int[][] mangDuLieu, int soNgay, int soPhong)
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
        #endregion 0812388 - Phú
        /// <summary>
        /// Tim phieu thue
        /// </summary>
        /// <param name="kieuTimKiem"></param>
        /// <param name="maPhieuThue"></param>
        /// <param name="tenPhong"></param>
        /// <param name="tenKhachHangDaiDien"></param>
        /// <param name="ngayBatDauThue"></param>
        /// <param name="soNgayThue"></param>
        /// <returns>Tra ve phieu thue neu tim thay</returns>
        public static List<PHIEUTHUE> TimPhieu(string kieuTimKiem, string maPhieuThue, string tenPhong, string tenKhachHangDaiDien, DateTime ngayBatDauThue, int soNgayThue)
        {
            return PHIEUTHUEDAO.TimPhieu(kieuTimKiem, maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
        }
        /// <summary>
        /// Lay danh sach phieu thue theo tinh trang phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>        
        public static List<PHIEUTHUE> LayDSPhieuThueTheoTinhTrangPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoTinhTrangPhong(phong);
        }
        /// <summary>
        /// Lay tong so ngay thue
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve so ngay thue</returns>
        public static int LayTongSoNgayThue(PHONG phong)
        {
            return PHIEUTHUEDAO.LayTongSoNgayThue(phong);
        }
        /// <summary>
        /// Lay danh sach phieu thue chua checkin
        /// </summary>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueChuaCheckin()
        {
            return PHIEUTHUEDAO.LayDSPhieuThueChuaCheckin();
        }
        /// <summary>
        /// Lay phieu thue theo ma
        /// </summary>
        /// <param name="_maphieuthue"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayPhieuThueTheoMa(string _maphieuthue)
        {
            return PHIEUTHUEDAO.LayPhieuThueTheoMa(_maphieuthue);
        }
        /// <summary>
        /// Cap nhat checkin
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="_Dangthue"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool UpdateCheckin(PHIEUTHUE pt, bool _Dangthue)
        {
            return PHIEUTHUEDAO.UpdateCheckin(pt, _Dangthue);
        }
        /// <summary>
        /// Lay danh sach phieu thue theo ma nhom
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve danh sach phieu thue</returns>
        public static List<PHIEUTHUE> LayDSPhieuThueTheoMaNhom(int p)
        {
            return DAO.PHIEUTHUEDAO.LayDSPhieuThueChuaThanhToanTheoMaNhom(p);
        }
        /// <summary>
        /// Check in phieu thue
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool CheckinPhieuThue(string p)
        {
            return DAO.PHIEUTHUEDAO.CheckinPhieuThue(p);
        }
        /// <summary>
        /// Checkout phieu thue
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool CheckOutPhieuThue(string p)
        {
            return DAO.PHIEUTHUEDAO.CheckoutPhieuThue(p);
        }
        /// <summary>
        /// Lay danh sach phieu thue chua checkin theo ma nhom
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static List<PHIEUTHUE> LayDSPhieuThueChuaCheckinTheoMaNhom(int p)
        {
            return DAO.PHIEUTHUEDAO.LayDSPhieuThueChuaCheckinTheoMaNhom(p);
        }
    }
}
