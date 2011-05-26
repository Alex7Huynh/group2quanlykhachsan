using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class KHACHHANGBUS
    {
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
        /// <summary>
        /// Lay danh sach khac hang theo ho ten
        /// </summary>
        /// <param name="HoTen"></param>
        /// <returns>Tra ve danh sach khach hang</returns>
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
        /// <summary>
        /// Lay danh sach khach hang theo so giay to
        /// </summary>
        /// <param name="SoGiayTo"></param>
        /// <returns>Tra ve danh sach khach hang</returns>
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
        /// <summary>
        /// Lay danh sach khach hang theo dia chi
        /// </summary>
        /// <param name="DiaChi"></param>
        /// <returns>Tra ve danh sach khach hang</returns>
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
        /// <summary>
        /// Lay danh sach khach hang theo loai khach hang
        /// </summary>
        /// <param name="LoaiKH"></param>
        /// <returns>Tra ve danh sach khach hang</returns>
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
        /// <summary>
        /// Tự động lấy mã cho khách hàng tiếp theo
        /// </summary>
        /// <returns>Trả về mã khách hàng</returns>
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
        /// <summary>
        /// Thêm một khách hàng mới vào csdl
        /// </summary>
        /// <param name="khachHang"> KHACHHANG</param>
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
        /// <summary>
        /// Tim khach hang theo so giay to chinh xac
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Tra ve khach hang neu tim thay</returns>
        public static KHACHHANG LayKhachTheoSoGiayToChinhXac(string p)
        {
            return DAO.KHACHHANGDAO.LayKhachTheoSoGiayToChinhXac(p);
        }
    }
}
