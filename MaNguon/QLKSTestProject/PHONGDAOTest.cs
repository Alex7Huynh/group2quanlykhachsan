using DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for PHONGDAOTest and is intended
    ///to contain all PHONGDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PHONGDAOTest
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
            string MaPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONGDAO.XoaPhong(MaPhong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Xoa
        ///</summary>
        [TestMethod()]
        public void XoaTest()
        {
            string maPhong = string.Empty; // TODO: Initialize to an appropriate value
            PHONGDAO.Xoa(maPhong);
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
            actual = PHONGDAO.UpdateTinhTrangPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TimPhong
        ///author:0812033
        ///</summary>
        [TestMethod()]
        public void TimPhongTest()
        {
            string maPhong = "C002"; // TODO: Initialize to an appropriate value
            string tenPhong = "C017-Bussiness"; // TODO: Initialize to an appropriate value
            string loaiPhong = "C"; // TODO: Initialize to an appropriate value
            string tinhTrang = " "; // TODO: Initialize to an appropriate value
            bool timChinhXac = true; // TODO: Initialize to an appropriate value
            List<PHONG> expected = new List<PHONG>();
            expected.Add(new PHONG
            {
                MaPhong = maPhong,
                TenPhong = tenPhong,
                MaLoaiPhong = maPhong,
                TinhTrang = "on dinh"
            }); // TODO: Initialize to an appropriate value
            List<PHONG> actual;
            actual = PHONGDAO.TimPhong(maPhong, tenPhong, loaiPhong, tinhTrang, timChinhXac);
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
            PHONGDAO.ThemPhong(phong);
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
            actual = PHONGDAO.LayPhongTheoTenPhong(tenPhong);
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
            actual = PHONGDAO.LayPhongTheoMa(maPhong);
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
            actual = PHONGDAO.LayDSPhongTheoLoaiPhong(loaiPhong);
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
            actual = PHONGDAO.LayDSPhong();
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
            actual = PHONGDAO.LayDSLoaiPhong();
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
            actual = PHONGDAO.LayDonGiaTheoPhong(phong);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CapNhatPhong
        ///</summary>
        [TestMethod()]
        public void CapNhatPhongTest()
        {
            PHONG phong = null; // TODO: Initialize to an appropriate value
           
            PHONGDAO.CapNhatPhong(phong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PHONGDAO Constructor
        ///</summary>
        [TestMethod()]
        public void PHONGDAOConstructorTest()
        {
            PHONGDAO target = new PHONGDAO();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
