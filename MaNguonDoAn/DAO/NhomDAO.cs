using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class NhomDAO : ABSDAO
    {
        /// <summary>
        /// Tu dong lay ma nhom (can OleDbConnection)
        /// </summary>
        /// <param name="link"></param>
        /// <returns>Tra ve ma nhom</returns>
        private static int TuDongLayMaNhom(OleDbConnection link)
        {
            //int maNhom = 0;
            try
            {
                //link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "select MAX(MaNhom) From Nhom";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                return (int)lenh.ExecuteScalar() + 1;                
            }
            catch
            {
                throw new Exception("Không lấy được mã nhóm");
            }
        }
        /// <summary>
        /// Tu dong lay ma nhom
        /// </summary>
        /// <returns>Tra ve ma nhom</returns>
        public static int TuDongLayMaNhom()
        {
            //int maNhom = 0;
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "select MAX(MaNhom) From Nhom";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader read = lenh.ExecuteReader();
                int ma = 0;
                while (read.Read())
                {
                    ma = read.GetInt32(0);
                }
                return ma + 1;
            }
            catch
            {
                throw new Exception("Không lấy được mã nhóm");
            }
        }
        /// <summary>
        /// Them nhom
        /// </summary>
        /// <param name="nhom"></param>
        /// <returns>Tra ve ma nhom</returns>
        public static int ThemNhom(NhomDTO nhom)
        {
            OleDbConnection link = null;
            int ma = 0;
            try
            {
                link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "insert into Nhom values (" + nhom.MaNhom.ToString() + ", '" + nhom.MaKhacHang + "', 0)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                try
                {
                    lenh.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Thêm nhóm thất bại! Vui lòng kiểm tra lại thông tin và làm lại lần nữa.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return ma;
        }        
        /// <summary>
        /// Lay danh sach nhom theo khach hang
        /// </summary>
        /// <param name="maKH">ma khach hang tuong ung</param>
        /// <returns>Tra ve danh sach cac nhom ma khach hang nay lam chu</returns>
        public static List<NhomDTO> LayDSNhomTheoMaKhach(string maKH)
        {
            List<NhomDTO> ret = null;

            OleDbConnection link = null;
            try
            {
                ret = new List<NhomDTO>();
                link = KetNoi();
                string chuoiLenh;
                chuoiLenh = "select * from Nhom where MaKhachHangDaiDien = @MaKhachHangDaiDien";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                lenh.Parameters.AddWithValue("@MaKhachHangDaiDien", maKH);
                OleDbDataReader reader = lenh.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(new NhomDTO
                    {
                        MaKhacHang = reader.GetString(1),
                        MaNhom = reader.GetInt32(0)
                    });
                }
                reader.Close();
                link.Close();
                return ret;
            }
            catch
            {
                if (link != null && link.State == System.Data.ConnectionState.Connecting)
                    link.Close();
                return null;
                
            }
            finally
            {
               
            }
        }
        
    }
}
