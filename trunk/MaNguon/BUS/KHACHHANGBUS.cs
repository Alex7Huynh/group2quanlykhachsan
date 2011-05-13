﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class KHACHHANGBUS
    {
        public static List<KHACHHANG> LayDSKhach()
        {
            return KHACHHANGDAO.LayDSKhach();
        }

        public static List<KHACHHANG> LayDSKhachTheoMaKH(string maKH)
        {
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                dsKH = KHACHHANGDAO.LayDSKhachTheoMaKH(maKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsKH;
        }

        public static List<KHACHHANG> LayDSKhachTheoHoTen(string HoTen)
        {
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                dsKH = KHACHHANGDAO.LayDSKhachTheoHoTen(HoTen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsKH;
        }

        public static List<KHACHHANG> LayDSKhachTheoSoGiayTo(string SoGiayTo)
        {
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                dsKH = KHACHHANGDAO.LayDSKhachTheoSoGiayTo(SoGiayTo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsKH;
        }

        public static List<KHACHHANG> LayDSKhachTheoDiaChi(string DiaChi)
        {
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                dsKH = KHACHHANGDAO.LayDSKhachTheoDiaChi(DiaChi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsKH;
        }

        public static List<KHACHHANG> LayDSKhachTheoLoaiKH(string LoaiKH)
        {
            List<KHACHHANG> dsKH = new List<KHACHHANG>();
            try
            {
                dsKH = KHACHHANGDAO.LayDSKhachTheoLoaiKH(LoaiKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsKH;
        }
        //0812033
        public static string TuDongLayMaKhachHang()
        {
            try
            {
                return KHACHHANGDAO.TuDongLayMaKhachHang();
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        public static void ThemKhachHang(KHACHHANG khachHang)
        {
            try
            {
                KHACHHANGDAO.ThemKhachHang(khachHang);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        //end 0812033
    }
}
