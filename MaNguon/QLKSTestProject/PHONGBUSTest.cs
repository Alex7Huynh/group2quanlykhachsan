using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for PHONGBUSTest and is intended
    ///to contain all PHONGBUSTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PHONGBUSTest
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
        ///A test for XoaPhong
        ///</summary>
        [TestMethod()]
        public void XoaPhongTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONGBUS.XoaPhong(maPhong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Xoa
        ///</summary>
        [TestMethod()]
        public void XoaTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONGBUS.Xoa(maPhong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateTinhTrangPhong
        ///</summary>
        [TestMethod()]
        public void UpdateTinhTrangPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHONGBUS.UpdateTinhTrangPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TimPhong
        ///</summary>
        [TestMethod()]
        public void TimPhongTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            string tenPhong = string.Empty; // TODO: Initialize to an appropriate value
            string loaiPhong = string.Empty; // TODO: Initialize to an appropriate value
            string tinhTrang = string.Empty; // TODO: Initialize to an appropriate value
            bool timChinhXac = false; // TODO: Initialize to an appropriate value
            List<PHONG> expected = null; // TODO: Initialize to an appropriate value
            List<PHONG> actual;
            actual = PHONGBUS.TimPhong(maPhong, tenPhong, loaiPhong, tinhTrang, timChinhXac);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ThemPhong
        ///</summary>
        [TestMethod()]
        public void ThemPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            PHONGBUS.ThemPhong(phong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LayPhongTheoTenPhong
        ///</summary>
        [TestMethod()]
        public void LayPhongTheoTenPhongTest()
        {
            string tenPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONG expected = null; // TODO: Initialize to an appropriate value
            PHONG actual;
            actual = PHONGBUS.LayPhongTheoTenPhong(tenPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayPhongTheoMa
        ///</summary>
        [TestMethod()]
        public void LayPhongTheoMaTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONG expected = null; // TODO: Initialize to an appropriate value
            PHONG actual;
            actual = PHONGBUS.LayPhongTheoMa(maPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for layDSThietBiThang
        ///</summary>
        [TestMethod()]
        public void layDSThietBiThangTest()
        {
            int thang = 0; // TODO: Initialize to an appropriate value
            List<int> expected = null; // TODO: Initialize to an appropriate value
            List<int> actual;
            actual = PHONGBUS.layDSThietBiThang(thang);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PHONGBUS Constructor
        ///</summary>
        [TestMethod()]
        public void PHONGBUSConstructorTest()
        {
            PHONGBUS target = new PHONGBUS();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CapNhatPhong
        ///</summary>
        [TestMethod()]
        public void CapNhatPhongTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            string tenPhong = string.Empty; // TODO: Initialize to an appropriate value
            string maLoaiPhong = string.Empty; // TODO: Initialize to an appropriate value
            string tinhTrang = string.Empty; // TODO: Initialize to an appropriate value
            string ghiChu = string.Empty; // TODO: Initialize to an appropriate value
            PHONGBUS.CapNhatPhong(maPhong, tenPhong, maLoaiPhong, tinhTrang, ghiChu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for KiemTraLoaiPhong
        ///</summary>
        [TestMethod()]
        public void KiemTraLoaiPhongTest()
        {
            string loaiPhong = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PHONGBUS.KiemTraLoaiPhong(loaiPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LapBaoCaoDoanhThu
        ///</summary>
        [TestMethod()]
        public void LapBaoCaoDoanhThuTest()
        {
            int thang = 0; // TODO: Initialize to an appropriate value
            int[] expected = null; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = PHONGBUS.LapBaoCaoDoanhThu(thang);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayDonGiaTheoPhong
        ///</summary>
        [TestMethod()]
        public void LayDonGiaTheoPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = PHONGBUS.LayDonGiaTheoPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayDSLoaiPhong
        ///</summary>
        [TestMethod()]
        public void LayDSLoaiPhongTest()
        {
            List<LOAIPHONG> expected = null; // TODO: Initialize to an appropriate value
            List<LOAIPHONG> actual;
            actual = PHONGBUS.LayDSLoaiPhong();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayDSPhong
        ///</summary>
        [TestMethod()]
        public void LayDSPhongTest()
        {
            List<PHONG> expected = null; // TODO: Initialize to an appropriate value
            List<PHONG> actual;
            actual = PHONGBUS.LayDSPhong();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LayDSPhongTheoLoaiPhong
        ///</summary>
        [TestMethod()]
        public void LayDSPhongTheoLoaiPhongTest()
        {
            LOAIPHONG loaiPhong = null; // TODO: Initialize to an appropriate value
            List<PHONG> expected = null; // TODO: Initialize to an appropriate value
            List<PHONG> actual;
            actual = PHONGBUS.LayDSPhongTheoLoaiPhong(loaiPhong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
