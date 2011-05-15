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


        public static bool ThemPhieu(PHIEUTHUE phieu)
        {
            return PHIEUTHUEDAO.ThemPhieu(phieu);
        }
        public static List<PHIEUTHUE> LayDSPhieuThueTheoPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(phong);
        }


        #region Ma giả thuat toan toi uu 0812517
        public static bool ToiUuPhieuThue(LOAIPHONG loaiPhong)
        {
            //gán loại phòng cần tối ưu các phiếu thuê phòng
            PHIEUTHUEBUS.LoaiPhongCanToiUu = loaiPhong;

            //lấy danh sách các phòng thuộc loại phòng đó
            _dsPhong = PHONGBUS.LayDSPhongTheoLoaiPhong(LoaiPhongCanToiUu);

            //lấy danh sách các phiếu thuê phòng thuộc loại phòng đó
            for (int i = 0; i < _dsPhong.Count; i++)
            {
                _dsPhieuThue.AddRange(PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(_dsPhong[i]));
            }

            return TryToiUuPhieuThue(0);
        }

        private static bool TryToiUuPhieuThue(int phieuThue)
        {
            if (phieuThue >= _dsPhieuThue.Count)
            {
                //đã tối ưu hết phiếu thuê phòng
                return true;
            }
            else
            {
                //xét lần lượt các phòng
                for (int  i = 0; i < _dsPhong.Count; i++)
                {
                    //if (_dsPhieuThue[phieuThue] có thể chuyển tới _dsPhong[i])
                    //{
                        //Lưu lại phòng cũ của phiếu thuê;
                        string maSoPhongCu = _dsPhieuThue[phieuThue].MaPhong;
                        //Chuyển phiếu thuê sang phòng mới;
                        _dsPhieuThue[phieuThue].MaPhong = _dsPhong[i].MaPhong;
                        //Tính tổng chỉ số phòng trống;
                        int chiSoPhongTrong = TinhChiSoPhongTrong();
                        if (chiSoPhongTrong > _chiSoPhongTrongMax)
                        {
                            _chiSoPhongTrongMax = chiSoPhongTrong;
                        }
                        TryToiUuPhieuThue(phieuThue + 1);
                        //Trả lại phòng cũ cho phiếu thuê i.
                        _dsPhieuThue[phieuThue].MaPhong = maSoPhongCu;
                    //}
                }
            }
            return false;
        }

        private static int TinhChiSoPhongTrong()
        {
            //lấy ngày đầu tiên (làm chuẩn)
            //lấy ngày cuối cùng (làm chuẩn)
            //xét lần lượt các phòng
            for (int i = 0; i < _dsPhong.Count; i++)
            {
                //xét lần lượt các phiếu thuê phòng của phòng đó
                List<PHIEUTHUE> dsPhieuThuePhong = PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(_dsPhong[i]);
                for (int j = 0; j < dsPhieuThuePhong.Count; j++)
                {
                    //nếu là phiếu đầu tiên, xét nó với ngày đầu tiên => tính chỉ số
                    //nếu không là phiếu đầu tiên, không phải là phiếu cuối cùng, xét nó với phiếu tiếp theo => tính chỉ số
                    //nếu là phiếu cuối cùng, xét nó với ngày cuối cùng => tính chỉ số
                }
            }
            //tính tổng các chỉ số
            //trả về
            return 0;
        }
        #endregion

        #region 0812033 - Bình
        ///////0812033
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
        public static bool XoaPhieuThue(List<string> dsMaPhieuThue)
        {
            return PHIEUTHUEDAO.XoaPhieuThue(dsMaPhieuThue);
        }
        public static bool XoaTamPhieuThue(List<string> dsMaPhieuThue)
        {
            return PHIEUTHUEDAO.XoaTamPhieuThue(dsMaPhieuThue);
        }
        #endregion

        #region 0812388 - Phú
        //////////////
        //// 0812388 - Phú
        /// <summary>
        /// Hàm thực hiện tối ưu hóa các phiếu thuê phòng
        /// </summary>
        /// <param name="phieuThueMoi">Phiếu thuê mới muốn thêm vào</param>
        /// <param name="danhSachPhieuThueCanToiUu">Danh sách các phiếu thuê hiện có và muốn tối ưu trên các phiếu thuê này</param>
        /// <param name="viTriNgay">Ngay muốn tối ưu</param>
        /// <returns>Sơ đồ tình trạng phòng</returns>
        public static int[][] ToiUuPhieuThue(PHIEUTHUE phieuThueMoi, string maLoaiPhong, List<PHIEUTHUE> danhSachPhieuThueCanToiUu, ref int viTriNgay)
        {
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

            viTriNgay = phieuThueMoi.NgayThue.DayOfYear - ngayPhieuThueCuNhat.DayOfYear;

            Init(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
            Stack<List<PHIEUTHUE>> st = new Stack<List<PHIEUTHUE>>();
            if (Rate(soDoTinhTrangPhong, soNgayThue, soPhong) > max)
                st.Push(danhSachPhieuThueCanToiUu);
            while (st.Count != 0)
            {
                danhSachPhieuThueCanToiUu = st.Pop();

                Init(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
                if (Rate(soDoTinhTrangPhong, soNgayThue, soPhong) == max)
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

                        if (danhSachPhieuThueCanToiUu[i].SoNgayThue <= soDoTinhTrangPhong[j][/*_lsPt[i].NgayBatDau*/ngayBatDau] && !danhSachPhieuThueCanToiUu[i].DangThue)
                        {
                            string strMaPhong = danhSachPhieuThueCanToiUu[i].MaPhong[0].ToString();
                            danhSachPhieuThueCanToiUu[i].MaPhong = strMaPhong + (j + 1).ToString("000");
                            //_lsPt[i].MaPhong = j + 1;

                            Init(ref soDoTinhTrangPhong, danhSachPhieuThueCanToiUu, soPhong, soNgayThue);
                            if (Rate(soDoTinhTrangPhong, soNgayThue, soPhong) > max)
                            {
                                max = Rate(soDoTinhTrangPhong, soNgayThue, soPhong);
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
                                st.Push(danhSachPhieuThueCanToiUu);
                            }
                        }
                    }
                }

            }
            Init(ref soDoTinhTrangPhong, ketQua, soPhong, soNgayThue);
            //CapNhatPhieuThueDaToiUu(danhSachPhieuThueCanToiUu, ketQua);
            CapNhatPhieuThueDaToiUu(ketQua);
            return soDoTinhTrangPhong;
        }
        /// <summary>
        /// Khởi tạo sơ đồ tình trạng phòng 
        /// </summary>
        /// <param name="mangDuLieu">Sơ đồ tình trạng phòng (ref)</param>
        /// <param name="dsPhieuThue">Danh sách các phiếu thuê muốn lập sơ đồ tình trạng phòng</param>
        /// <param name="soPhong">Số lượng phòng tổng cộng</param>
        /// <param name="soNgay">Số ngày (tính từ ngày của phiếu thuê có ngày sớm nhất đến phiếu thuê kết thúc trễ nhất)</param>
        private static void Init(ref int[][] mangDuLieu, List<PHIEUTHUE> dsPhieuThue, int soPhong, int soNgay)
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
        ///Hết phần Code của 0812388
        #endregion 0812388 - Phú

        public static List<PHIEUTHUE> TimPhieu(string kieuTimKiem, string maPhieuThue, string tenPhong, string tenKhachHangDaiDien, DateTime ngayBatDauThue, int soNgayThue)
        {
            return PHIEUTHUEDAO.TimPhieu(kieuTimKiem, maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
        }

        //0812251 nhom 13 them test checkin
        public static List<PHIEUTHUE> LayDSPhieuThueTheoTinhTrangPhong(PHONG phong)
        {
            return PHIEUTHUEDAO.LayDSPhieuThueTheoTinhTrangPhong(phong);
        }

        public static int layTongSoNgayThue(PHONG phong)
        {
            return PHIEUTHUEDAO.layTongSoNgayThue(phong);
        }
        public static List<PHIEUTHUE> LayDSPhieuThueChuaCheckin()
        {
            return PHIEUTHUEDAO.LayDSPhieuThueChuaCheckin();
        }
        public static List<PHIEUTHUE> LayPhieuThueTheoMa(string _maphieuthue)
        {
            return PHIEUTHUEDAO.LayPhieuThueTheoMa(_maphieuthue);
        }
        public static bool UpdateCheckin(PHIEUTHUE pt, bool _Dangthue)
        {
            return PHIEUTHUEDAO.UpdateCheckin(pt, _Dangthue);
        }
        // 0812388
        public static List<PHIEUTHUE> LayDSPhieuThueTheoMaNhom(int p)
        {
            return DAO.PHIEUTHUEDAO.LayDSPhieuThueTheoMaNhom(p);
        }

        public static bool CheckinPhieuThue(string p)
        {
            return DAO.PHIEUTHUEDAO.CheckinPhieuThue(p);
        }
    }
}
