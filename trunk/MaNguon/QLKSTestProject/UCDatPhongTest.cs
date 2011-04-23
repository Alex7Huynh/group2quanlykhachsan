using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for UCDatPhongTest and is intended
    ///to contain all UCDatPhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UCDatPhongTest
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
        ///A test for CurrentLoaiPhong
        ///</summary>
        [TestMethod()]
        public void CurrentLoaiPhongTest()
        {
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            UCDatPhong.CurrentLoaiPhong = expected;
            actual = UCDatPhong.CurrentLoaiPhong;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ArrPhong
        ///</summary>
        [TestMethod()]
        public void ArrPhongTest()
        {
            List<PHONG> expected = null; // TODO: Initialize to an appropriate value
            List<PHONG> actual;
            UCDatPhong.ArrPhong = expected;
            actual = UCDatPhong.ArrPhong;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ArrLoaiPhong
        ///</summary>
        [TestMethod()]
        public void ArrLoaiPhongTest()
        {
            List<LOAIPHONG> expected = null; // TODO: Initialize to an appropriate value
            List<LOAIPHONG> actual;
            UCDatPhong.ArrLoaiPhong = expected;
            actual = UCDatPhong.ArrLoaiPhong;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateDateTime
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateDateTimeTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateDateTime();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateDanhSachPhong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateDanhSachPhongTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateDanhSachPhong();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for txtLoaiPhong_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void txtLoaiPhong_TextChangedTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtLoaiPhong_TextChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sortDSPhong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void sortDSPhongTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            List<PHONG> dsPhong = null; // TODO: Initialize to an appropriate value
            target.sortDSPhong(dsPhong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for mclCalendar_DateChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void mclCalendar_DateChangedTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DateRangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.mclCalendar_DateChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadDanhSachPhong
        ///</summary>
        [TestMethod()]
        public void LoadDanhSachPhongTest()
        {
            UCDatPhong target = new UCDatPhong(); // TODO: Initialize to an appropriate value
            List<PHONG> dsPhong = null; // TODO: Initialize to an appropriate value
            target.LoadDanhSachPhong(dsPhong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadDanhSachLoaiPhong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void LoadDanhSachLoaiPhongTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.LoadDanhSachLoaiPhong();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for lblLoaiPhong_Paint
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void lblLoaiPhong_PaintTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            PaintEventArgs e = null; // TODO: Initialize to an appropriate value
            target.lblLoaiPhong_Paint(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetLastDayOfMonth
        ///</summary>
        [TestMethod()]
        public void GetLastDayOfMonthTest()
        {
            UCDatPhong target = new UCDatPhong(); // TODO: Initialize to an appropriate value
            DateTime dateTime = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.GetLastDayOfMonth(dateTime);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFirstDayOfMonth
        ///</summary>
        [TestMethod()]
        public void GetFirstDayOfMonthTest()
        {
            UCDatPhong target = new UCDatPhong(); // TODO: Initialize to an appropriate value
            DateTime dateTime = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.GetFirstDayOfMonth(dateTime);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnReservation_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnReservation_ClickTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnReservation_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnPreviousLoaiPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnPreviousLoaiPhong_ClickTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnPreviousLoaiPhong_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnNextLoaiPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnNextLoaiPhong_ClickTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnNextLoaiPhong_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCheckOut_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnCheckOut_ClickTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCheckOut_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCheckIn_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnCheckIn_ClickTest()
        {
            UCDatPhong_Accessor target = new UCDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCheckIn_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UCDatPhong Constructor
        ///</summary>
        [TestMethod()]
        public void UCDatPhongConstructorTest()
        {
            UCDatPhong target = new UCDatPhong();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
