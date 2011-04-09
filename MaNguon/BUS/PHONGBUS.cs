﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class PHONGBUS
    {
        public static List<PHONG> LayDSPhong()
        {
            return PHONGDAO.LayDSPhong();
        }
        public static PHONG LayPhongTheoTenPhong(string tenPhong)
        {
            return PHONGDAO.LayPhongTheoTenPhong(tenPhong);
        }
        public static List<LOAIPHONG> LayDSLoaiPhong()
        {
            return PHONGDAO.LayDSLoaiPhong();
        }
        public static void ThemPhong(PHONG phong)
        {
            PHONGDAO.ThemPhong(phong);
        }
        public static void XoaPhong(string maPhong)
        {
            PHONGDAO.XoaPhong(maPhong);
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

        public static List<PHONG> LayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            return PHONGDAO.LayDSPhongTheoLoaiPhong(loaiPhong);
        }
    }
}
