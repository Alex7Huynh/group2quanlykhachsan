using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for frmBaoCaoDoanhThuTest and is intended
    ///to contain all frmBaoCaoDoanhThuTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmBaoCaoDoanhThuTest
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
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            frmBaoCaoDoanhThu_Accessor target = new frmBaoCaoDoanhThu_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            frmBaoCaoDoanhThu_Accessor target = new frmBaoCaoDoanhThu_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
        }

        /// <summary>
        ///A test for BaoCaoDoanhThu_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BaoCaoDoanhThu_LoadTest()
        {
            frmBaoCaoDoanhThu_Accessor target = new frmBaoCaoDoanhThu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BaoCaoDoanhThu_Load(sender, e);
            
        }

        /// <summary>
        ///A test for frmBaoCaoDoanhThu Constructor
        ///</summary>
        [TestMethod()]
        public void frmBaoCaoDoanhThuConstructorTest()
        {
            frmBaoCaoDoanhThu target = new frmBaoCaoDoanhThu();
        }
    }
}
