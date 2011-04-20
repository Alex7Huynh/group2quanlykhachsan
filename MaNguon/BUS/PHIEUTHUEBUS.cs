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
        /*
        public static string DatPhieuThue(PHIEUTHUE phieuThue, string strLoaiPhong)
                {
                    try
                    {
                        return PHIEUTHUEDAO.DatPhieuThue(phieuThue, strLoaiPhong);
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }*/

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
        private static int TimPhongTotNhat(PHIEUTHUE phieuThueMoi, int viTriLoaiPhong)
        {
            int viTriPhong = -1;
            int max = 365;
            int[][] soDoTinhTrangPhong = new int[0][];
            int viTriNgay = 0;
            List<PHIEUTHUE> danhSachPhieuThue = PHIEUTHUEDAO.LayDSPhieuThueCanToiUu(phieuThueMoi, phieuThueMoi.MaPhong);
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
                phongDuocDat = PHIEUTHUEDAO.ThemPhieuThue(phieuThue);
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
        private static void CapNhatPhieuThueDaToiUu(List<PHIEUTHUE> nguon, List<PHIEUTHUE> dich)
        {
            for (int i = 0; i < nguon.Count; i++)
            {
                PHIEUTHUEDAO.XoaPhieuThue(nguon[i]);
                PHIEUTHUEDAO.ThemPhieuThue(dich[i]);
            }
        }
        ///////////////
        #endregion

        #region 0812xxx - Phú
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
                                    _res.Add(new PHIEUTHUE
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
        #endregion

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
    }
}
