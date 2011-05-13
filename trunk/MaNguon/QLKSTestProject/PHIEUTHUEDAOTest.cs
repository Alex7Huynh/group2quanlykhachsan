using DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Data.OleDb;
using System.Collections.Generic;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for PHIEUTHUEDAOTest and is intended
    ///to contain all PHIEUTHUEDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PHIEUTHUEDAOTest
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
        ///A test for XoaPhieuThue
        ///</summary>
        [TestMethod()]
        public void XoaPhieuThueTest()
        {
            PHIEUTHUE phieuThue = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEDAO.XoaPhieuThue(phieuThue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TuDongLayMaPhieuThue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DAO.dll")]
        public void TuDongLayMaPhieuThueTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            OleDbConnection link = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = PHIEUTHUEDAO_Accessor.TuDongLayMaPhieuThue(maPhong, link);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TimSoLonNhat
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DAO.dll")]
        public void TimSoLonNhatTest()
        {
            List<int> danhSach = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHIEUTHUEDAO_Accessor.TimSoLonNhat(danhSach);
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
            actual = PHIEUTHUEDAO.TimPhieu(kieuTimKiem, maPhieuThue, tenPhong, tenKhachHangDaiDien, ngayBatDauThue, soNgayThue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ThemPhieuThue
        ///author:0812033
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
            actual = PHIEUTHUEDAO.ThemPhieuThue(phieu);
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
            actual = PHIEUTHUEDAO.ThemPhieu(phieu);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ThemCTPT
        ///</summary>
        [TestMethod()]
        public void ThemCTPTTest()
        {
            CHITIETPHIEUTHUE chiTietPhieu = null; // TODO: Initialize to an appropriate value
            PHIEUTHUEDAO.ThemCTPT(chiTietPhieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
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
            actual = PHIEUTHUEDAO.layTongSoNgayThue(phong);
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
            actual = PHIEUTHUEDAO.LayDSPhieuThueTheoTinhTrangPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            actual = PHIEUTHUEDAO.LayDSPhieuThueTheoPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayDSPhieuThueCanToiUu
        ///author:0812033
        ///</summary>
        [TestMethod()]
        public void LayDSPhieuThueCanToiUuTest()
        {
            PHIEUTHUE phieu = new PHIEUTHUE
            {
                MaPhieuThue = "",
                MaPhong = "C",
                NgayThue = new DateTime(2010, 8, 14),
                SoNgayThue = 1,
                TenKhachHangDaiDien = "Nguyen",
                DangThue = false
            }; // TODO: Initialize to an appropriate value
            string strLoaiPhong = "C"; // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> expected = new List<PHIEUTHUE>(); // TODO: Initialize to an appropriate value
            PHIEUTHUE phieuMongDoi = new PHIEUTHUE
            {
                MaPhieuThue = "PTCOO2003",
                MaPhong = "C002",
                NgayThue = new DateTime(2010, 8, 14),
                SoNgayThue = 2,
                TenKhachHangDaiDien = "Doremon",
                DangThue = false
            };
            expected.Add(phieuMongDoi);
            List<PHIEUTHUE> actual;
            actual = PHIEUTHUEDAO.LayDSPhieuThueCanToiUu(phieu, strLoaiPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for KiemTraPhieuThue
        ///author:0812033
        ///</summary>
        [TestMethod()]
        public void KiemTraPhieuThueTest()
        {
            OleDbConnection ketNoi = ABSDAO.KetNoi(); // TODO: Initialize to an appropriate value
            PHIEUTHUE phieu = new PHIEUTHUE 
            {
                MaPhieuThue = "PTCOO2003",
                MaPhong = "C003",
                NgayThue = new DateTime(2010, 8, 14),
                SoNgayThue = 2,
                TenKhachHangDaiDien = "Doremon",
                DangThue = false
            }; // TODO: Initialize to an appropriate value
            PHIEUTHUEDAO.KiemTraPhieuThue(ketNoi, phieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CapNhatPhieuThue
        ///author:0812033
        ///</summary>
        [TestMethod()]
        public void CapNhatPhieuThueTest()
        {
            /*PHIEUTHUE phieuThue = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHIEUTHUEDAO.CapNhatPhieuThue(phieuThue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");*/
        }

        /// <summary>
        ///A test for PHIEUTHUEDAO Constructor
        ///</summary>
        [TestMethod()]
        public void PHIEUTHUEDAOConstructorTest()
        {
            PHIEUTHUEDAO target = new PHIEUTHUEDAO();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
