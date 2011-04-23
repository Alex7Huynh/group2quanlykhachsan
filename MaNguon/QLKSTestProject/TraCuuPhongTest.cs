using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for TraCuuPhongTest and is intended
    ///to contain all TraCuuPhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TraCuuPhongTest
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
        ///A test for TraCuuPhong_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void TraCuuPhong_LoadTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.TraCuuPhong_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LayDanhSachTenLoaiPhong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void LayDanhSachTenLoaiPhongTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.LayDanhSachTenLoaiPhong();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LayDanhSachMaLoaiPhong
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void LayDanhSachMaLoaiPhongTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.LayDanhSachMaLoaiPhong();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnTim_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnTim_ClickTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnTim_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnThoat_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnThoat_ClickTest()
        {
            TraCuuPhong_Accessor target = new TraCuuPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnThoat_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraCuuPhong Constructor
        ///</summary>
        [TestMethod()]
        public void TraCuuPhongConstructorTest()
        {
            TraCuuPhong target = new TraCuuPhong();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
