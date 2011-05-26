using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class HOADONDAO :ABSDAO
    {
        /// <summary>
        /// Lay danh sach hoa don
        /// </summary>
        /// <returns>Tra ve danh sach hoa don</returns>
        public static List<HOADON> LayDSHoaDon()
        {
            OleDbConnection link = null;
            List<HOADON> dsHoaDon = new List<HOADON>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "select MaHoaDon, TenKhachHangThanhToan, NgayThanhToan, ThanhTien, MaPhieuThue from HOADON";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    HOADON hd = new HOADON();
                    hd.MaHoaDon =Doc.GetString(0);
                    hd.TenKhachHangThanhToan =Doc.GetString(1);
                    hd.NgayThanhToan =Doc.GetDateTime(2);
                    hd.Thanhtien =Doc.GetInt32(3);
                    hd.MaPhieuThue = Doc.GetString(4);
                    dsHoaDon.Add(hd);
                }
            }
            catch (Exception ex)
            {
                dsHoaDon = new List<HOADON>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsHoaDon;
        }
        /// <summary>
        /// Dem so luong hoa don
        /// </summary>
        /// <returns>Tra ve so luong hoa don</returns>
        public static int DemSoLuongHoaDon()
        {
            OleDbConnection link = null;
            int maHoaDon = -1;
            try
            {
                link = KetNoi();
                string chuoiLenh = "select count(*) from HOADON";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                Doc.Read();
                maHoaDon = Doc.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc dữ liệu" + ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return maHoaDon;
        }
        /// <summary>
        /// Them hoa don moi
        /// </summary>
        /// <param name="hd"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool ThemHoaDonMoi(HOADON hd)
        {
            OleDbConnection link = null;
            
            try
            {
                link = KetNoi();
                string chuoiLenh = "INSERT INTO HOADON VALUES(@MaHoaDon,@TenKhachHangThanhToan,@NgayThanhToan,@ThanhTien,@MaPhieuThue)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaHoaDon", hd.MaHoaDon);
                lenh.Parameters.AddWithValue("@TenKhachHangThanhToan", hd.TenKhachHangThanhToan);

//                 OleDbParameter param = new OleDbParameter("@NgayThanhToan", hd.NgayThanhToan);
//                 param.DbType = System.Data.DbType.Date;
//                 lenh.Parameters.Add(param);
                lenh.Parameters.AddWithValue("@NgayThanhToan", hd.NgayThanhToan.Date);

                lenh.Parameters.AddWithValue("@ThanhTien", hd.Thanhtien);
                lenh.Parameters.AddWithValue("@MaPhieuThue", hd.MaPhieuThue);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc dữ liệu" + ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return true;
        }
    }
}
