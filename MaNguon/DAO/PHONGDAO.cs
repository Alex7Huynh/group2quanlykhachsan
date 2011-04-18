using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class PHONGDAO : ABSDAO
    {
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
                    phg.DaXoa = Doc.GetString(5);
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
        public static void CapNhatPhong(string maPhong,string tenPhong,string maLoaiPhong,string tinhTrang,string ghiChu)
        {
            OleDbConnection link = null;
            try
            {
                link = KetNoi();

                string chuoiLenh = "update PHONG set TenPhong=@TP,MaLoaiPhong=@MLP,GhiChu=@GC,Tinhtrang=@TT where MaPhong=@MP";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);
                OleDbParameter thamSo = new OleDbParameter("@TP", OleDbType.LongVarChar);
                thamSo.Value = tenPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@MLP", OleDbType.LongVarChar);
                thamSo.Value = maLoaiPhong;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@GC", OleDbType.LongVarChar);
                thamSo.Value = ghiChu;
                lenh.Parameters.Add(thamSo);
                thamSo = new OleDbParameter("@TT", OleDbType.LongVarChar);
                thamSo.Value = tinhTrang;
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
                    Phong.DaXoa = Doc.GetString(5);
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
                    Phong.DaXoa = Doc.GetString(5);
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
        public static List<PHONG> LayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            OleDbConnection link = null;
            List<PHONG> dsPhong = new List<PHONG>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrang, DaXoa from PHONG where PHONG.MaLoaiPhong = @MaLoaiPhong";
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
                    phg.DaXoa = Doc.GetString(5);
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
        ////////////
        // 0812033
        /// <summary>
        /// Tim tat ca cac phong thoa thong tin la cac tham so truyen vao
        /// </summary>
        /// <param name="maPhong"> ma phong muon tim </param>
        /// <param name="tenPhong"> ten phong mun tim </param>
        /// <param name="loaiPhong"> ma loai phong muon tim </param>
        /// <param name="tinhTrang"> tinh trang cua phong muon tim </param>
        /// <returns> danh sach cac phong thoa thong tin </returns>
        public static List<PHONG> TimPhong(string maPhong, string tenPhong, string loaiPhong, string tinhTrang)
        {
            List<PHONG> danhSachPhong = new List<PHONG>();
            OleDbConnection ketNoi = null;
            try
            {
                string chuoiKetNoi = "SELECT * FROM PHONG WHERE MaPhong like @MAPHONG OR TenPhong like @TENPHONG OR MaLoaiPhong like @MaLoaiPhong OR TinhTrang like @TINHTRANG";

                ketNoi = KetNoi();

                OleDbCommand lenh = new OleDbCommand(chuoiKetNoi, ketNoi);
                OleDbParameter thamSo = lenh.Parameters.Add("@MAPHONG", OleDbType.VarWChar);
                if (maPhong != " ")
                {
                    thamSo.Value = maPhong + '%';
                }
                else
                    thamSo.Value = maPhong;
                thamSo = lenh.Parameters.Add("@TENPHONG", OleDbType.VarWChar);
                if (tenPhong != " ")
                {
                    thamSo.Value = tenPhong + '%';
                }
                else
                    thamSo.Value = tenPhong;
                thamSo = lenh.Parameters.Add("@MaLoaiPhong", OleDbType.VarWChar);
                if (loaiPhong != " ")
                {
                    thamSo.Value = loaiPhong + '%';
                }
                else
                    thamSo.Value = loaiPhong;
                thamSo = lenh.Parameters.Add("@TINHTRANG", OleDbType.VarWChar);
                if (tinhTrang != " ")
                {
                    thamSo.Value = '%' + tinhTrang + '%';
                }
                else
                    thamSo.Value = tinhTrang;

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    PHONG phong = new PHONG();
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
                    danhSachPhong.Add(phong);
                }
            }
            catch
            {
                danhSachPhong = new List<PHONG>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return danhSachPhong;
        }
        ///////////

        ///0812388
        public static List<int> layDSThietBiThang(int thang)
        {
            OleDbConnection link = null;
            List<int> arr = new List<int>();
            try
            {
                link = KetNoi();
                string chuoiLenh = "Select Tien from THONGKETHIETBI Where  Thang =@thang  order by MaPhong ";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, link);

                OleDbParameter thamso = new OleDbParameter("@thang", OleDbType.Integer);
                thamso.Value = thang;
                lenh.Parameters.Add(thamso);

                OleDbDataReader Doc = lenh.ExecuteReader();

                while (Doc.Read())
                {
                    int i = Doc.GetInt32(0);
                    arr.Add(i);
                }
            }
            finally
            {
                if (link != null && link.State == System.Data.ConnectionState.Open)
                    link.Close();
            }
            return arr;
        }

        // 0812251 nhom 13 them test chuc nang checkin
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
    }
}