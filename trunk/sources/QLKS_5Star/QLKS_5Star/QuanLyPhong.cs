using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS_5Star
{
    class QuanLyPhong
    {
        QuanLyDuLieu _quanLyDuLieu = new QuanLyDuLieu("..//..//QLKS.xml");
        public int TimPhongTotNhat(DateTime ngayDatPhong, int soNgayThue)
        {
            int viTriPhong = 0;
            int max = 365;
            int viTriNgay = ChuyenNgayThanhViTri(new DateTime(2010, 1, 3));
            // doc csdl
            int[][] soDoTinhTrangPhong = new int[0][];
            soDoTinhTrangPhong = _quanLyDuLieu.LaySoDoTinhTrangPhong(ngayDatPhong.Day, ngayDatPhong.Month, ngayDatPhong.Year);

            for (int i = 0; i < soDoTinhTrangPhong.Length; i++ )
            {
                if (soDoTinhTrangPhong[i][viTriNgay-1] == soNgayThue)
                {
                    viTriPhong = i;
                    // thoat vong lap
                    i = soDoTinhTrangPhong.Length;
                }
                else if (soDoTinhTrangPhong[i][viTriNgay - 1] < max && soNgayThue < soDoTinhTrangPhong[i][viTriNgay - 1])
                {
                    max = soDoTinhTrangPhong[i][soNgayThue - 1];
                    viTriPhong = i;
                }
            }
            // cap nhat so do tinh trang phong
            _quanLyDuLieu.CapNhatSoDoTinhTrangPhong(ref soDoTinhTrangPhong, viTriPhong, viTriNgay - 1, soNgayThue);

            // cap nhat co so du lieu
            _quanLyDuLieu.CapNhatCoSoDuLieu(soDoTinhTrangPhong, viTriPhong, ngayDatPhong.Year, viTriNgay - 1);
            
            return viTriPhong;
        }

        private int ChuyenNgayThanhViTri(DateTime ngayDatPhong)
        {
            int viTri = 0;
            for(int i = 1; i < ngayDatPhong.Month; i++)
            {
                viTri += DateTime.DaysInMonth(ngayDatPhong.Year, i);
            }
            viTri += ngayDatPhong.Day;
            return viTri;
        }
    }
}
