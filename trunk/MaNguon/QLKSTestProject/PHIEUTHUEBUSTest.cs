using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for PHIEUTHUEBUSTest and is intended
    ///to contain all PHIEUTHUEBUSTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PHIEUTHUEBUSTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PHIEUTHUEBUS Constructor
        ///</summary>
        [TestMethod()]
        public void PHIEUTHUEBUSConstructorTest()
        {
            PHIEUTHUEBUS target = new PHIEUTHUEBUS();
        }

        /// <summary>
        ///A test for CapNhatPhieuThueDaToiUu
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void CapNhatPhieuThueDaToiUuTest()
        {
            List<PHIEUTHUE> nguon = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> dich = null; // TODO: Initialize to an appropriate value
            PHIEUTHUEBUS_Accessor.CapNhatPhieuThueDaToiUu(nguon, dich);
            
        }

        /// <summary>
        ///A test for DatPhieuThue
        ///</summary>
        [TestMethod()]
        public void DatPhieuThueTest()
        {
            PHIEUTHUE phieuThue = new PHIEUTHUE{MaPhieuThue = "", MaPhong = "C", NgayThue = new DateTime(2011, 4,23), SoNgayThue = 1, 
                TenKhachHangDaiDien = "Nguyen", DangThue = false}; // TODO: Initialize to an appropriate value
            string strLoaiPhong = "C"; // TODO: Initialize to an appropriate value
            string expected = "PTC001001"; // TODO: Initialize to an appropriate value
            string actual;
            actual = PHIEUTHUEBUS.DatPhieuThue(phieuThue, strLoaiPhong);
            Assert.AreEqual(expected, actual);
            
        }
        #region Phú - 0812388
        /// <summary>
        ///A test for Init
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void InitTest()
        {
            int soPhong = 4;
            int soNgay = 9;
            int[][] mangDuLieu = new int[4][];
            int[][] mangDuLieuExpected = new int[4][];
            mangDuLieuExpected[0] = new int[] { -1, -1, -1, -1, -1, 4, 3, 2, 1 };
            mangDuLieuExpected[1] = new int[] { 3, 2, 1, -4, -4, -4, -4, -4, -4 };
            mangDuLieuExpected[2] = new int[] { -5, -5, -5, -5, -5, -5, 3, 2, 1 };
            mangDuLieuExpected[3] = new int[] { 2, 1, -6, -6, 5, 4, 3, 2, 1 };

            List<PHIEUTHUE> dsPhieuThue = new List<PHIEUTHUE>();
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA001002", MaPhong = "A001", NgayThue = new DateTime(2011, 4, 20), Phong = null, SoNgayThue = 5, TenKhachHangDaiDien = "" });
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA002002", MaPhong = "A002", NgayThue = new DateTime(2011, 4, 23), Phong = null, SoNgayThue = 6, TenKhachHangDaiDien = "" });
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA002003", MaPhong = "A002", NgayThue = new DateTime(2011, 4, 23), Phong = null, SoNgayThue = 6, TenKhachHangDaiDien = "" });
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA002004", MaPhong = "A002", NgayThue = new DateTime(2011, 4, 23), Phong = null, SoNgayThue = 6, TenKhachHangDaiDien = "" });
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA003001", MaPhong = "A003", NgayThue = new DateTime(2011, 4, 20), Phong = null, SoNgayThue = 6, TenKhachHangDaiDien = "" });
            dsPhieuThue.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA004002", MaPhong = "A004", NgayThue = new DateTime(2011, 4, 22), Phong = null, SoNgayThue = 2, TenKhachHangDaiDien = "" });
            
            

            PHIEUTHUEBUS_Accessor.KhoiTao(ref mangDuLieu, dsPhieuThue, soPhong, soNgay);
            for (int i = 0; i < soPhong; ++i)
                for (int j = 0; j < soNgay; ++j)
                    Assert.AreEqual(mangDuLieu[i][j], mangDuLieuExpected[i][j]);
            //
        }
        #endregion
        /// <summary>
        ///A test for LayDSPhieuThueTheoPhong
        ///</summary>
        [TestMethod()]
        public void LayDSPhieuThueTheoPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> expected = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> actual;
            actual = PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(phong);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LayDSPhieuThueTheoTinhTrangPhong
        ///</summary>
        [TestMethod()]
        public void LayDSPhieuThueTheoTinhTrangPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> expected = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> actual;
            actual = PHIEUTHUEBUS.LayDSPhieuThueTheoTinhTrangPhong(phong);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LayNgayPhieuThueCuNhat
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void LayNgayPhieuThueCuNhatTest()
        {
            PHIEUTHUE phieu1 = new PHIEUTHUE{NgayThue = new DateTime(2011, 4, 1)};
            PHIEUTHUE phieu2 = new PHIEUTHUE{NgayThue = new DateTime(2011, 4, 2)};
            List<PHIEUTHUE> danhSachPhieuThue = new List<PHIEUTHUE>(); // TODO: Initialize to an appropriate value
            danhSachPhieuThue.Add(phieu1);
            danhSachPhieuThue.Add(phieu2);
            DateTime expected = phieu1.NgayThue; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = PHIEUTHUEBUS_Accessor.LayNgayPhieuThueCuNhat(danhSachPhieuThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LayNgayPhieuThueXaNhat
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void LayNgayPhieuThueXaNhatTest()
        {
            PHIEUTHUE phieu1 = new PHIEUTHUE { NgayThue = new DateTime(2011, 4, 1) };
            PHIEUTHUE phieu2 = new PHIEUTHUE { NgayThue = new DateTime(2011, 4, 2) };
            List<PHIEUTHUE> danhSachPhieuThue = new List<PHIEUTHUE>(); // TODO: Initialize to an appropriate value
            danhSachPhieuThue.Add(phieu1);
            danhSachPhieuThue.Add(phieu2);
            DateTime expected = phieu2.NgayThue; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = PHIEUTHUEBUS_Accessor.LayNgayPhieuThueXaNhat(danhSachPhieuThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LayPhieuThueXaNhat
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void LayPhieuThueXaNhatTest()
        {
            PHIEUTHUE phieu1 = new PHIEUTHUE { NgayThue = new DateTime(2011, 4, 1) };
            PHIEUTHUE phieu2 = new PHIEUTHUE { NgayThue = new DateTime(2011, 4, 2) };
            List<PHIEUTHUE> danhSachPhieuThue = new List<PHIEUTHUE>(); // TODO: Initialize to an appropriate value
            danhSachPhieuThue.Add(phieu1);
            danhSachPhieuThue.Add(phieu2);
            PHIEUTHUE expected = phieu2; // TODO: Initialize to an appropriate value
            PHIEUTHUE actual;
            actual = PHIEUTHUEBUS_Accessor.LayPhieuThueXaNhat(danhSachPhieuThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LaySoPhongTheoLoai
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void LaySoPhongTheoLoaiTest()
        {
            string strLoaiPhong = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEBUS_Accessor.LaySoPhongTheoLoai(strLoaiPhong);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for layTongSoNgayThue
        ///</summary>
        [TestMethod()]
        public void layTongSoNgayThueTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEBUS.layTongSoNgayThue(phong);
            Assert.AreEqual(expected, actual);
            
        }
        #region Phú - 0812388
        /// <summary>
        ///A test for Rate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void RateTest()
        {
            int[][] mangDuLieu = new int[4][];
            mangDuLieu[0] = new int[] { -1, -1, -1, -1, -1, 4, 3, 2, 1 };
            mangDuLieu[1] = new int[] { 3, 2, 1, -4, -4, -4, -4, -4, -4 };
            mangDuLieu[2] = new int[] { -5, -5, -5, -5, -5, -5, 3, 2, 1 };
            mangDuLieu[3] = new int[] { 2, 1, -6, -6, 5, 4, 3, 2, 1 };

            int soNgay = 9; 
            int soPhong = 4; 
            int expected = 40; 

            int actual;
            actual = PHIEUTHUEBUS_Accessor.DanhGia(mangDuLieu, soNgay, soPhong);
            Assert.AreEqual(expected, actual);            
        }
        #endregion
        /// <summary>
        ///A test for ThemPhieu
        ///</summary>
        [TestMethod()]
        public void ThemPhieuTest()
        {
            PHIEUTHUE phieu = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEBUS.ThemPhieu(phieu);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for ThemPhieuThue
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        public void ThemPhieuThueTest()
        {
            PHIEUTHUE phieu = new PHIEUTHUE
            {
                MaPhieuThue = "",
                MaPhong = "C002",
                NgayThue = new DateTime(2011, 4, 23),
                SoNgayThue = 1,
                TenKhachHangDaiDien = "Nguyen",
                DangThue = false
            }; // TODO: Initialize to an appropriate value
            string expected = "PTCOO2OO4"; // TODO: Initialize to an appropriate value
            string actual;
            actual = PHIEUTHUEBUS.ThemPhieuThue(phieu);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for TimPhieu
        ///</summary>
        [TestMethod()]
        public void TimPhieuTest()
        {
            string kieuTimKiem = string.Empty; // TODO: Initialize to an appropriate value
            string maPhieuThue = string.Empty; // TODO: Initialize to an appropriate value
            string tenPhong = string.Empty; // TODO: Initialize to an appropriate value
            string tenKhachHangDaiDien = string.Empty; // TODO: Initialize to an appropriate value
            DateTime ngayBatDauThue = new DateTime(); // TODO: Initialize to an appropriate value
            int soNgayThue = 0; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> expected = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> actual;
            actual = PHIEUTHUEBUS.TimPhieu(kieuTimKiem, maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for TimPhongTotNhat
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void TimPhongTotNhatTest()
        {
            PHIEUTHUE phieuThueMoi = null; // TODO: Initialize to an appropriate value
            int viTriLoaiPhong = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEBUS_Accessor.TimPhongTotNhat(phieuThueMoi, null, viTriLoaiPhong);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for TinhChiSoPhongTrong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void TinhChiSoPhongTrongTest()
        {
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEBUS_Accessor.TinhChiSoPhongTrong();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for ToiUuPhieuThue
        ///</summary>
        [TestMethod()]
        public void ToiUuPhieuThueTest1()
        {
            LOAIPHONG loaiPhong = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEBUS.ToiUuPhieuThue(loaiPhong);
            Assert.AreEqual(expected, actual);
            
        }
        #region Phú - 0812388
        /// <summary>
        ///A test for ToiUuPhieuThue
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        public void ToiUuPhieuThueTest()
        {
            PHIEUTHUE phieuThueMoi = new PHIEUTHUE { DangThue = false, MaPhieuThue = "", MaPhong = "A", NgayThue = new DateTime(2011,04,29), Phong = null, SoNgayThue = 1, TenKhachHangDaiDien = ""};
            List<PHIEUTHUE> danhSachPhieuThueCanToiUu = new List<PHIEUTHUE>();
            danhSachPhieuThueCanToiUu.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA004004", MaPhong = "A004", NgayThue = new DateTime(2011, 04, 25), Phong = null, SoNgayThue = 5, TenKhachHangDaiDien = "" });
            danhSachPhieuThueCanToiUu.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA003002", MaPhong = "A003", NgayThue = new DateTime(2011, 04, 26), Phong = null, SoNgayThue = 4, TenKhachHangDaiDien = "" });
            danhSachPhieuThueCanToiUu.Add(new PHIEUTHUE { DangThue = true, MaPhieuThue = "PTA001006", MaPhong = "A001", NgayThue = new DateTime(2011, 04, 29), Phong = null, SoNgayThue = 1, TenKhachHangDaiDien = "" });
            int viTriNgay = 0; 
            int viTriNgayExpected = 4;
            int[][] expected = new int[4][];
            expected[0] = new int[] { 4, 3, 2, 1, -3 };
            expected[1] = new int[] { 5, 4, 3, 2, 1 };
            expected[2] = new int[] { 1, -2, -2, -2, -2 };
            expected[3] = new int[] { -1, -1, -1, -1, -1 };

            int[][] actual;
            actual = PHIEUTHUEBUS.ToiUuPhieuThue(phieuThueMoi, phieuThueMoi.MaPhong, danhSachPhieuThueCanToiUu, ref viTriNgay);
            Assert.AreEqual(viTriNgayExpected, viTriNgay);
            for (int i = 0; i < expected.Length; ++i)
                for (int j = 0; j < expected[i].Length; ++j)
                    Assert.AreEqual(expected[i][j], actual[i][j]);

            //
        }
        #endregion
        /// <summary>
        ///A test for TryToiUuPhieuThue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void TryToiUuPhieuThueTest()
        {
            int phieuThue = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEBUS_Accessor.TryToiUuPhieuThue(phieuThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for XoaPhieuThue
        ///</summary>
        [TestMethod()]
        public void XoaPhieuThueTest()
        {
            PHIEUTHUE phieuThue = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEBUS.XoaPhieuThue(phieuThue);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for LoaiPhongCanToiUu
        ///</summary>
        [TestMethod()]
        public void LoaiPhongCanToiUuTest()
        {
            LOAIPHONG expected = null; // TODO: Initialize to an appropriate value
            LOAIPHONG actual;
            PHIEUTHUEBUS.LoaiPhongCanToiUu = expected;
            actual = PHIEUTHUEBUS.LoaiPhongCanToiUu;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
