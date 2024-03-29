﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class PHONGDAO : ABSDAO
    {
        /// <summary>
        /// Lay danh sach phong
        /// </summary>
        /// <returns>Tra ve danh sach phong</returns>
        public static List<PHONG> LayDSPhong()
        {
            OleDbConnection link = null;
            List<PHONG> dsPhong = new List<PHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from PHONG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHONG phg = new PHONG();
                    phg.MaPhong = Doc.GetString(0);
                    phg.TenPhong = Doc.GetString(1);
                    phg.MaLoaiPhong = Doc.GetString(2);
                    phg.GhiChu = Doc.GetString(3);
                    phg.TinhTrang = Doc.GetString(4);
                    phg.SoNguoiToiDa = Doc.GetInt32(5);
                    phg.DaXoa = Doc.GetString(6);
                    dsPhong.Add(phg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<PHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }
        /// <summary>
        /// Lay danh sach loai phong
        /// </summary>
        /// <returns>Tra ve danh sach loai phong</returns>
        public static List<LOAIPHONG> LayDSLoaiPhong()
        {
            OleDbConnection link = null;
            List<LOAIPHONG> dsPhong = new List<LOAIPHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaLoaiPhong, TenLoaiPhong, DonGia, SLKhachToiDa from LOAIPHONG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    LOAIPHONG lphg = new LOAIPHONG();
                    lphg.MaLoaiPhong = Doc.GetString(0);
                    lphg.TenLoaiPhong = Doc.GetString(1);
                    lphg.DonGia = Doc.GetInt32(2);
                    lphg.SLKhachToiDa = Doc.GetInt32(3);
                    dsPhong.Add(lphg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<LOAIPHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }
        /// <summary>
        /// Them phong
        /// </summary>
        /// <param name="phong"></param>
        public static void ThemPhong(PHONG phong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "insert into PHONG(MaPhong,TenPhong,MaLoaiPhong,TinhTrang,GhiChu,DaXoa) values(@MaPhong,@TenPhong,@MaLoaiPhong,@TinhTrang,@GhiChu,@DaXoa)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TenPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.TenPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MaLoaiPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaLoaiPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TinhTrang", OleDbType.LongVarChar);
                thamSo.Value = phong.TinhTrang;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@GhiChu", OleDbType.LongVarChar);
                thamSo.Value = phong.GhiChu;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@DaXoa", OleDbType.LongVarChar);
                thamSo.Value = 0;
                lenh.Parameters.Add(thamSo);
                lenh.ExecuteNonQuery();
                OleDbDataAdapter Adapter = new OleDbDataAdapter();
                Adapter.InsertCommand = lenh;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
        }
        /// <summary>
        /// Xoa phong (xoa vinh vien)
        /// </summary>
        /// <param name="MaPhong"></param>
        public static void XoaPhong(string MaPhong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                //xét nếu không có người ở hay đặt phòng thì mới xóa <===
                string chuoiLenh = "delete from PHONG where (MaPhong=@MaPhong)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = MaPhong;
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
        /// <summary>
        /// Xoa phong (xoa tam thoi)
        /// </summary>
        /// <param name="maPhong"></param>
        public static void Xoa(string maPhong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();

                string chuoiLenh = "update PHONG set DaXoa=@xoa where MaPhong=@MP";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@xoa", OleDbType.LongVarChar);
                thamSo.Value = "1";
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MP", OleDbType.LongVarChar);
                thamSo.Value = maPhong;
                lenh.Parameters.Add(thamSo);
                lenh.ExecuteNonQuery();
                OleDbDataAdapter Adapter = new OleDbDataAdapter();
                Adapter.UpdateCommand = lenh;
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
        /// <summary>
        /// Cap nhat thong tin phong
        /// </summary>
        /// <param name="phong"></param>
        public static void CapNhatPhong(PHONG phong)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();

                string chuoiLenh = "update PHONG set TenPhong=@TP,MaLoaiPhong=@MLP,GhiChu=@GC,Tinhtrang=@TT where MaPhong=@MP";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@TP", OleDbType.LongVarChar);
                thamSo.Value = phong.TenPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MLP", OleDbType.LongVarChar);
                thamSo.Value = phong.MaLoaiPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@GC", OleDbType.LongVarChar);
                thamSo.Value = phong.GhiChu;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TT", OleDbType.LongVarChar);
                thamSo.Value = phong.TinhTrang;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MP", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);
                lenh.ExecuteNonQuery();
                OleDbDataAdapter Adapter = new OleDbDataAdapter();
                Adapter.UpdateCommand = lenh;
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
        /// <summary>
        /// Lay phong theo ten phong
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <returns>Tra ve phong neu tim thay</returns>
        public static PHONG LayPhongTheoTenPhong(string tenPhong)
        {
            OleDbConnection link = null;
            PHONG Phong = new PHONG();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from PHONG where TenPhong = @TenPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@TenPhong", OleDbType.LongVarChar);
                thamSo.Value = tenPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                Doc.Read();
                {
                    Phong.MaPhong = Doc.GetString(0);
                    Phong.TenPhong = Doc.GetString(1);
                    Phong.MaLoaiPhong = Doc.GetString(2);
                    if (!Doc.IsDBNull(3))
                    {
                        Phong.GhiChu = Doc.GetString(3);
                    }
                    else
                    {
                        Phong.GhiChu = "";
                    }
                    if (!Doc.IsDBNull(3))
                    {
                        Phong.TinhTrang = Doc.GetString(4);
                    }
                    else
                    {
                        Phong.TinhTrang = "";
                    }
                    Phong.SoNguoiToiDa = Doc.GetInt32(5);
                    Phong.DaXoa = Doc.GetString(6);
                }
            }
            catch (Exception ex)
            {
               Phong = new PHONG();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return Phong;
        }
        /// <summary>
        /// Lay phong theo ma phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve phong neu tim thay</returns>
        public static PHONG LayPhongTheoMa(string maPhong)
        {
            OleDbConnection link = null;
            PHONG Phong = new PHONG();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from PHONG where MaPhong = @MaPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@TenPhong", OleDbType.LongVarChar);
                thamSo.Value = maPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                Doc.Read();
                {
                    Phong.MaPhong = Doc.GetString(0);
                    Phong.TenPhong = Doc.GetString(1);
                    Phong.MaLoaiPhong = Doc.GetString(2);
                    if (!Doc.IsDBNull(3))
                    {
                        Phong.GhiChu = Doc.GetString(3);
                    }
                    else
                    {
                        Phong.GhiChu = "";
                    }
                    if (!Doc.IsDBNull(3))
                    {
                        Phong.TinhTrang = Doc.GetString(4);
                    }
                    else
                    {
                        Phong.TinhTrang = "";
                    }
                    Phong.SoNguoiToiDa = Doc.GetInt32(5);
                    Phong.DaXoa = Doc.GetString(6);
                }
            }
            catch (Exception ex)
            {
               Phong = new PHONG();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return Phong;
        }
        /// <summary>
        /// Lay danh sach phong theo loai phong
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns>Tra ve danh sach phong</returns>
        public static List<PHONG> LayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            OleDbConnection link = null;
            List<PHONG> dsPhong = new List<PHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select * from PHONG where PHONG.MaLoaiPhong = @MaLoaiPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaLoaiPhong", OleDbType.LongVarChar);
                thamSo.Value = loaiPhong.MaLoaiPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    PHONG phg = new PHONG();
                    phg.MaPhong = Doc.GetString(0);
                    phg.TenPhong = Doc.GetString(1);
                    phg.MaLoaiPhong = Doc.GetString(2);
                    if (!Doc.IsDBNull(3))
                    {
                        phg.GhiChu = Doc.GetString(3);
                    }
                    else
                    {
                        phg.GhiChu = "";
                    }
                    if (!Doc.IsDBNull(3))
                    {
                        phg.TinhTrang = Doc.GetString(4);
                    }
                    else
                    {
                        phg.TinhTrang = "";
                    }
                    phg.SoNguoiToiDa = Doc.GetInt32(5);
                    phg.DaXoa = Doc.GetString(6);
                    dsPhong.Add(phg);
                }
            }
            catch (Exception ex)
            {
                dsPhong = new List<PHONG>();
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return dsPhong;
        }        
        /// <summary>
        /// Tim tat ca cac phong thoa thong tin la cac tham so truyen vao
        /// </summary>
        /// <param name="maPhong"> ma phong muon tim </param>
        /// <param name="tenPhong"> ten phong mun tim </param>
        /// <param name="loaiPhong"> ma loai phong muon tim </param>
        /// <param name="tinhTrang"> tinh trang cua phong muon tim </param>
        /// <returns> danh sach cac phong thoa thong tin </returns>
        public static List<PHONG> TimPhong(string maPhong, string tenPhong, string loaiPhong, string tinhTrang, bool timChinhXac)
        {
            List<PHONG> danhSachPhong = new List<PHONG>();
            OleDbConnection ketNoi = null;
            try
            {
                string chuoiKetNoi = "SELECT * FROM PHONG WHERE MaLoaiPhong like '" + loaiPhong + "' ";
                if (timChinhXac)
                {
                    //chuoiKetNoi = "SELECT * FROM PHONG WHERE MaLoaiPhong like '" + loaiPhong + "' ";//MaPhong like @MAPHONG AND TenPhong like @TENPHONG AND MaLoaiPhong like @MaLoaiPhong AND TinhTrang like @TINHTRANG";
                    if (maPhong != " ")
                    {
                        chuoiKetNoi += "AND MaPhong like '" + maPhong + "%' ";
                    }
                    if (tenPhong != " ")
                    {
                        chuoiKetNoi += "AND TenPhong like '" + tenPhong + "%' ";
                    }
                    if (tinhTrang != " ")
                    {
                        chuoiKetNoi += "AND TinhTrang like '" + tinhTrang + "%' ";
                    }
                }
                else
                {
                    //chuoiKetNoi = "SELECT * FROM PHONG WHERE MaPhong like @MAPHONG OR TenPhong like @TENPHONG OR MaLoaiPhong like @MaLoaiPhong OR TinhTrang like @TINHTRANG";
                    if (maPhong != " ")
                    {
                        maPhong += '%';
                    }
                    if (tenPhong != " ")
                    {
                        tenPhong += '%';
                    }
                    if (tinhTrang != " ")
                    {
                        tinhTrang = '%' + tinhTrang + '%';
                    }
                    chuoiKetNoi += "OR MaPhong like '" + maPhong + "' " + "OR TenPhong like '" + tenPhong + "' " + "OR TinhTrang like '" + tinhTrang + "' ";
                }

                ketNoi = KetNoi();

                OleDbCommand lenh = new OleDbCommand(chuoiKetNoi, ketNoi);

                OleDbDataReader boDoc;
                try
                {
                    boDoc = lenh.ExecuteReader();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Tìm phòng thất bại! Vui lòng kiểm tra lại thông tin và làm lại lần nữa.");
                }
                while (boDoc.Read())
                {
                    PHONG phong = new PHONG();
                    try
                    {
                        if (!boDoc.IsDBNull(0))
                            phong.MaPhong = boDoc.GetString(0);
                        if (!boDoc.IsDBNull(1))
                            phong.TenPhong = boDoc.GetString(1);
                        if (!boDoc.IsDBNull(2))
                            phong.MaLoaiPhong = boDoc.GetString(2);
                        if (!boDoc.IsDBNull(3))
                            phong.GhiChu = boDoc.GetString(3);
                        if (!boDoc.IsDBNull(4))
                            phong.TinhTrang = boDoc.GetString(4);
                        phong.SoNguoiToiDa = boDoc.GetInt32(5);
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception("Có lỗi trong khi đọc dữ liệu! Vùi lòng kiểm tra lại thông tin và làm lại lần nữa");
                    }
                    danhSachPhong.Add(phong);
                }
            }
            catch (Exception e)
            {
                danhSachPhong = new List<PHONG>();
                throw new Exception(e.Message);
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return danhSachPhong;
        }
        /// <summary>
        /// Lay so nguoi toi da trong mot phong dua vao ma phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve so nguoi toi da</returns>
        public static int LaySoNguoiToiDa(string maPhong)
        {
            OleDbConnection link = null;
            int soNguoi = 0;
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select SoNguoiToiDa from PHONG where MaPhong = '" + maPhong + "'";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    soNguoi = Doc.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                soNguoi = 0;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return soNguoi;
        }      
        /// <summary>
        /// Cap nhat tinh trang phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve ket qua thanh cong hay that bai</returns>
        public static bool UpdateTinhTrangPhong(PHONG phong)
        {
            bool ketQua = true;
            OleDbConnection link = null;
            try
            {
                link = KetNoi();
                string chuoiLenh = "UPDATE PHONG SET PHONG.tinhTrang = @tinhTrang WHERE MaPhong = @MaPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@tinhTrang", OleDbType.LongVarChar);
                thamSo.Value = phong.TinhTrang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ketQua = false;
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return ketQua;
        }
        /// <summary>
        /// Lay don gia theo phong
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>Tra ve don gia cua phong</returns>
        public static int LayDonGiaTheoPhong(PHONG phong)
        {
            int DonGia = 0;
            OleDbConnection link = null;

            try
            {
                link = KetNoi();
                string chuoiLenh = "Select lp.MaLoaiPhong,lp.TenLoaiPhong,lp.DonGia,lp.SLKhachToiDa from PHONG p, LOAIPHONG lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.MaPhong = @MaPhong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@MaPhong", OleDbType.LongVarChar);
                thamSo.Value = phong.MaPhong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    LOAIPHONG phg = new LOAIPHONG();
                    phg.MaLoaiPhong = Doc.GetString(0);
                    phg.TenLoaiPhong = Doc.GetString(1);
                    phg.DonGia = int.Parse(Doc.GetValue(2).ToString());
                    phg.SLKhachToiDa = int.Parse(Doc.GetValue(3).ToString()); ;

                    DonGia = phg.DonGia;

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return DonGia;
        }
        /// <summary>
        /// Lay don gia theo ma phong
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns>Tra ve don gia cua phong</returns>
        public static int LayDonGiaTheoMaPhong(string maPhong)
        {
            int DonGia = 0;
            OleDbConnection link = null;

            try
            {
                link = KetNoi();
                string chuoiLenh = "Select lp.MaLoaiPhong,lp.TenLoaiPhong,lp.DonGia,lp.SLKhachToiDa from PHONG p, LOAIPHONG lp where p.MaPhong = @MaPhong";
                
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);                
                lenh.Parameters.AddWithValue("@MaPhong",maPhong);

                OleDbDataReader Doc = lenh.ExecuteReader();
                while (Doc.Read())
                {
                    LOAIPHONG phg = new LOAIPHONG();
                    phg.MaLoaiPhong = Doc.GetString(0);
                    phg.TenLoaiPhong = Doc.GetString(1);
                    phg.DonGia = int.Parse(Doc.GetValue(2).ToString());
                    phg.SLKhachToiDa = int.Parse(Doc.GetValue(3).ToString()); ;

                    DonGia = phg.DonGia;

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return DonGia;
        }
    }
}