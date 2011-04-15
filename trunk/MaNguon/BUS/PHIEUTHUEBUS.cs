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
        ///////0812033
        public static string DatPhieuThue(PHIEUTHUE phieuThue, string strLoaiPhong)
        {
            return PHIEUTHUEDAO.DatPhieuThue(phieuThue, strLoaiPhong);
        }
        public static string ThemPhieuThue(PHIEUTHUE phieu)
        {
            return PHIEUTHUEDAO.ThemPhieuThue(phieu);
        }
        public static bool XoaPhieuThue(PHIEUTHUE phieuThue)
        {
            return PHIEUTHUEDAO.XoaPhieuThue(phieuThue);
        }
        ///////////////

        public static List<PHIEUTHUE> TimPhieu(string maPhieuThue, string tenPhong, string tenKhachHangDaiDien, DateTime ngayBatDauThue, int soNgayThue)
        {
            return PHIEUTHUEDAO.TimPhieu(maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
        }
    }
}
