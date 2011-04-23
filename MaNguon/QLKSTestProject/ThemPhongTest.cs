using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for ThemPhongTest and is intended
    ///to contain all ThemPhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ThemPhongTest
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
        ///A test for ThemPhongVaoDanhSach
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void ThemPhongVaoDanhSachTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            int temp = 0; // TODO: Initialize to an appropriate value
            PHONG phg = null; // TODO: Initialize to an appropriate value
            target.ThemPhongVaoDanhSach(temp, phg);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ThemPhong_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void ThemPhong_LoadTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ThemPhong_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
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
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnXoa_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnXoa_ClickTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnXoa_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }       

        /// <summary>
        ///A test for btnThem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnThem_ClickTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnThem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnOK_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void btnOK_ClickTest()
        {
            ThemPhong_Accessor target = new ThemPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnOK_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ThemPhong Constructor
        ///</summary>
        [TestMethod()]
        public void ThemPhongConstructorTest()
        {
            ThemPhong target = new ThemPhong();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
