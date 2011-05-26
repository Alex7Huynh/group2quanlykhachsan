using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for SuaPhongTest and is intended
    ///to contain all SuaPhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SuaPhongTest
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
        ///A test for SuaPhong_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void SuaPhong_LoadTest()
        {
            SuaPhong_Accessor target = new SuaPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.SuaPhong_Load(sender, e);
            
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            SuaPhong_Accessor target = new SuaPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            SuaPhong_Accessor target = new SuaPhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            
        }

        /// <summary>
        ///A test for cmbMP_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void cmbMP_SelectedIndexChangedTest()
        {
            SuaPhong_Accessor target = new SuaPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.cmbMP_SelectedIndexChanged(sender, e);
            
        }



        /// <summary>
        ///A test for SuaPhong Constructor
        ///</summary>
        [TestMethod()]
        public void SuaPhongConstructorTest()
        {
            SuaPhong target = new SuaPhong();
            
        }
    }
}
