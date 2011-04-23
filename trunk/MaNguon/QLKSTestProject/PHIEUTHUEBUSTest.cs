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
            Assert.Inconclusive("TODO: Implement code to verify target");
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
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Init
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void InitTest()
        {
            int[][] mangDuLieu = null; // TODO: Initialize to an appropriate value
            int[][] mangDuLieuExpected = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> _lsPt = null; // TODO: Initialize to an appropriate value
            int soPhong = 0; // TODO: Initialize to an appropriate value
            int soNgay = 0; // TODO: Initialize to an appropriate value
            PHIEUTHUEBUS_Accessor.Init(ref mangDuLieu, _lsPt, soPhong, soNgay);
            Assert.AreEqual(mangDuLieuExpected, mangDuLieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BUS.dll")]
        public void RateTest()
        {
            int[][] mangDuLieu = null; // TODO: Initialize to an appropriate value
            int soNgay = 0; // TODO: Initialize to an appropriate value
            int soPhong = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEBUS_Accessor.Rate(mangDuLieu, soNgay, soPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            actual = PHIEUTHUEBUS_Accessor.TimPhongTotNhat(phieuThueMoi, viTriLoaiPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToiUuPhieuThue
        ///author: 0812033
        ///</summary>
        [TestMethod()]
        public void ToiUuPhieuThueTest()
        {
            PHIEUTHUE phieuThueMoi = null; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> danhSachPhieuThueCanToiUu = null; // TODO: Initialize to an appropriate value
            int viTriNgay = 0; // TODO: Initialize to an appropriate value
            int viTriNgayExpected = 0; // TODO: Initialize to an appropriate value
            int[][] expected = null; // TODO: Initialize to an appropriate value
            int[][] actual;
            actual = PHIEUTHUEBUS.ToiUuPhieuThue(phieuThueMoi, danhSachPhieuThueCanToiUu, ref viTriNgay);
            Assert.AreEqual(viTriNgayExpected, viTriNgay);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
