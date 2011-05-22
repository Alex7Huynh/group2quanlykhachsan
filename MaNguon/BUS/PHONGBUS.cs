using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class PHONGBUS
    {
        /// <summary>
        /// Lay danh sach phong
        /// </summary>
        /// <returns>Tra ve danh sach phong</returns>
        public static List<PHONG> LayDSPhong()
        {
            return PHONGDAO.LayDSPhong();
        }
        /// <summary>
        /// Tim phong theo ten phong
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <returns>Tra ve phong neu tim thay</returns>
        public static PHONG LayPhongTheoTenPhong(string tenPhong)
        {
            return PHONGDAO.LayPhongTheoTenPhong(tenPhong);
        }
        /// <summary>
        /// Lay danh sach loai phong
        /// </summary>
        /// <returns>Tra ve danh sach loai phong</returns>
        public static List<LOAIPHONG> LayDSLoaiPhong()
        {
            return PHONGDAO.LayDSLoaiPhong();
        }
        /// <summary>
        /// Them phong
        /// </summary>
        /// <param name="phong"></param>
        public static void ThemPhong(PHONG phong)
        {
            PHONGDAO.ThemPhong(phong);
        }
        /// <summary>
        /// Xoa phong (xoa vinh vien)
        /// </summary>
        /// <param name="maPhong"></param>
        public static void XoaPhong(string maPhong)
        {
            PHONGDAO.XoaPhong(maPhong);
        }
        /// <summary>
        /// Xoa phong (xoa tam thoi)
        /// </summary>
        /// <param name="maPhong"></param>
        public static void Xoa(string maPhong)
        {
            PHONGDAO.Xoa(maPhong);
        }
        /// <summary>
        /// Tim phong theo ma phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve phong neu tim thay</returns>
        public static PHONG LayPhongTheoMa(string maPhong)
        {
            return PHONGDAO.LayPhongTheoMa(maPhong);
        }
        /// <summary>
        /// Cap nhat thong tin phong
        /// </summary>
        /// <param name="phong"></param>
        public static void CapNhatPhong(PHONG phong)
        {
            PHONGDAO.CapNhatPhong(phong);
        }
        /// <summary>
        /// Lay danh sach phong theo loai phong
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns>Tra ve danh sach phong</returns>
        public static List<PHONG> LayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            return PHONGDAO.LayDSPhongTheoLoaiPhong(loaiPhong);
        }
        /// <summary>
        /// Tim phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tenPhong"></param>
        /// <param name="loaiPhong"></param>
        /// <param name="tinhTrang"></param>
        /// <param name="timChinhXac"></param>
        /// <returns>Tra ve danh sach phong tim thay</returns>
        public static List<PHONG> TimPhong(string maPhong, string tenPhong, string loaiPhong, string tinhTrang, bool timChinhXac)
        {
            return PHONGDAO.TimPhong(maPhong, tenPhong, loaiPhong, tinhTrang, timChinhXac);
        }
        /// <summary>
        /// Ham lap bao cao doanh thu theo thang
        /// </summary>
        /// <param name="thang">thang muon lap bao cao</param>
        /// <returns>Tra ve mang cac doanh thu</returns>
        public static int[] LapBaoCaoDoanhThu(int thang)
        {
            List<HOADON> dsHD = new List<HOADON>();
            dsHD = HOADONBUS.layDSHoaDon();
            List<PHONG> dsphg = new List<PHONG>();
            dsphg = LayDSPhong();
            List<PHIEUTHUE> dsPT = new List<PHIEUTHUE>();

            int[] arrDoanhThu = new int[dsphg.Count];
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].NgayThanhToan.Month == thang)
                {
                    for (int j = 0; j < dsphg.Count; ++j)
                    {
                        dsPT = PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(dsphg[j]);
                        for (int k = 0; k < dsPT.Count; ++k)
                            if (dsPT[k].MaPhieuThue == dsHD[i].MaPhieuThue)
                                arrDoanhThu[j] += dsHD[i].Thanhtien;
                    }
                }
            }
            return arrDoanhThu;
        }
        /// <summary>
        /// Kiem tra ma phong hop le
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool KiemTraMaPhongHopLe(string maPhong)
        {
            if ((maPhong.Length > 5) || (maPhong[0] < 'A') || (maPhong[0] > 'Z'))
            {
                return false;
            }
            try
            {
                int index = int.Parse(maPhong.Substring(1));
                return true;
            }
            catch
            {
                return false;
            }

        }
        /// <summary>
        /// Kiem tra phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool KiemTraPhong(PHONG phong)
        {
            string loaiPhong = phong.MaLoaiPhong.Trim();
            if ((!KiemTraMaPhong(phong.MaPhong)) || (phong.TenPhong.Length > 255) || (phong.TinhTrang.Length > 255)
                || (phong.GhiChu.Length > 255) || (!KiemTraLoaiPhong(loaiPhong)))
                return false;
            return true;
        }
        /// <summary>
        /// Cap nhat tinh trang phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool UpdateTinhTrangPhong(PHONG phong)
        {
            return PHONGDAO.UpdateTinhTrangPhong(phong);
        }
        /// <summary>
        /// Lay don gia theo phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve don gia</returns>
        public static int LayDonGiaTheoPhong(PHONG phong)
        {
            return PHONGDAO.LayDonGiaTheoPhong(phong);
        }
        /// <summary>
        /// Kiem tra loai phong
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool KiemTraLoaiPhong(string loaiPhong)
        {
            if (loaiPhong.Length > 50) return false;
            List<LOAIPHONG> dsloai = PHONGBUS.LayDSLoaiPhong();
            for (int index = dsloai.Count; index > 0; --index)
                if ((string.Compare(loaiPhong, dsloai[index - 1].MaLoaiPhong, false) == 0))
                    return true;
            return false;
        }
        /// <summary>
        /// Kiem tra ma phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool KiemTraMaPhong(string maPhong)
        {
            if (maPhong.Length > 255) return false;
            List<PHONG> dsphg = LayDSPhong();
            for (int index = dsphg.Count; 0 < index; --index)
                if ((string.Compare(maPhong, dsphg[index - 1].MaPhong, false) == 0))
                    return true;
            return false;
        }
        /// <summary>
        /// Lay don gia theo ma
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve don gia</returns>
        public static int LayDonGiaTheoMa(string p)
        {
            return DAO.PHONGDAO.LayDonGiaTheoMaPhong(p);
        }

        //public static List<PHONG> TimPhong( string maphong, string loaiphong, string tenphong, string tinhtrang)
        //{
        //    List<PHONG> temp = new List<PHONG>();
        //    List<PHONG> dsPhong = PHONGBUS.LayDSPhong();
        //    for (int i = 0; i < dsPhong.Count; ++i)
        //    {
        //        if (KiemTraMaPhong(dsPhong[i], maphong) || maphong.Equals(""))
        //            if (KiemTraLoaiPhong(dsPhong[i], loaiphong) || loaiphong.Equals(""))
        //                if (KiemTraTenPhong(dsPhong[i], tenphong) || tenphong.Equals(""))
        //                    if (KiemTraTinhTrang(dsPhong[i], tinhtrang) || tinhtrang.Equals(""))
        //                        temp.Add(dsPhong[i]);

        //    }
        //    return temp;
        //}

        //private static bool KiemTraMaPhong(PHONG phong, string maphong)
        //{
        //    if (phong.MaPhong.Equals(maphong))
        //        return true;
        //    return false;
        //}
        //private static bool KiemTraLoaiPhong(PHONG phong, string loaiphong)
        //{
        //    if (phong.LoaiPhong.TenLoaiPhong.Equals(loaiphong))
        //        return true;
        //    return false;
        //}
        //private static bool KiemTraTenPhong(PHONG phong, string tenphong)
        //{
        //    if (phong.TenPhong.Equals(tenphong))
        //        return true;
        //    return false;
        //}
        //private static bool KiemTraTinhTrang(PHONG phong, string tinhtrang)
        //{
        //    if (phong.TinhTrang.Equals(tinhtrang))
        //        return true;
        //    return false;
        //}


        //public static int[] LapBaoCaoDoanhThu(int thang)
        //{
        //    List<HOADON> dsHD = new List<HOADON>();
        //    dsHD = HOADONBUS.layDSHoaDon();
        //    List<PHONG> dsphg = new List<PHONG>();
        //    dsphg = LayDSPhong();
        //    int[] arrDoanhThu = new int[dsphg.Count];
        //    for (int i = 0; i < dsHD.Count; i++)
        //    {
        //        if (dsHD[i].NgayTT.Month != thang)
        //        {
        //            dsHD.RemoveAt(i);
        //            i--;
        //        }
        //    }
        //    for (int i = 0; i < dsHD.Count; i++)
        //    {
        //        List<CHITIETHOADON> dsCT = new List<CHITIETHOADON>();
        //        dsCT = dsHD[i].DsCTHD;
        //        for (int j = 0; j < dsCT.Count; j++)
        //        {
        //            int tienphong = dsCT[j].TongCong;

        //            for (int k = 0; k < dsphg.Count(); k++)
        //                if (string.Compare(dsCT[j].Phieuthue.Phong.MaPhong, dsphg[k].MaPhong, true) == 0)
        //                {
        //                    arrDoanhThu[k] += tienphong;
        //                    break;
        //                }
        //        }
        //    }
        //    return arrDoanhThu;
        //}


        //public static int[] LapBaoCaoMatDo(int thang)
        //{
        //    List<HOADON> dsHD = new List<HOADON>();
        //    dsHD = HOADONBUS.layDSHoaDon();
        //    List<PHONG> dsphg = new List<PHONG>();
        //    dsphg = LayDSPhong();
        //    int[] arrNgayThue = new int[dsphg.Count];
        //    for (int i = 0; i < dsHD.Count; i++)
        //    {
        //        if (dsHD[i].NgayTT.Month != thang)
        //        {
        //            dsHD.RemoveAt(i);
        //            i--;
        //        }
        //    }
        //    for (int i = 0; i < dsHD.Count; i++)
        //    {
        //        List<CHITIETHOADON> dsCT = new List<CHITIETHOADON>();
        //        dsCT = dsHD[i].DsCTHD;
        //        for (int j = 0; j < dsCT.Count; j++)
        //        {
        //            int ngaythue = dsCT[j].SoNgayThue;

        //            for (int k = 0; k < dsphg.Count(); k++)
        //                if (string.Compare(dsCT[j].Phieuthue.Phong.MaPhong, dsphg[k].MaPhong, true) == 0)
        //                {
        //                    arrNgayThue[k] += ngaythue;
        //                    break;
        //                }
        //        }
        //    }
        //    return arrNgayThue;
        //}
    }
}
