using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for frmManDinhDatPhongTest and is intended
    ///to contain all frmManDinhDatPhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmManDinhDatPhongTest
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
        ///A test for StartPoint
        ///</summary>
        [TestMethod()]
        public void StartPointTest()
        {
            frmManDinhDatPhong target = new frmManDinhDatPhong(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            target.StartPoint = expected;
            actual = target.StartPoint;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseMove
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseMoveTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseMove(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseDownTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseDown(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveForm
        ///</summary>
        [TestMethod()]
        public void MoveFormTest()
        {
            frmManDinhDatPhong target = new frmManDinhDatPhong(); // TODO: Initialize to an appropriate value
            Point distance = new Point(); // TODO: Initialize to an appropriate value
            target.MoveForm(distance);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for frmManDinhDatPhong_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void frmManDinhDatPhong_LoadTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.frmManDinhDatPhong_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for frmManDinhDatPhong_FormClosing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void frmManDinhDatPhong_FormClosingTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            FormClosingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.frmManDinhDatPhong_FormClosing(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BT_ThuNho_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BT_ThuNho_ClickTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BT_ThuNho_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BT_Thoat_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BT_Thoat_ClickTest()
        {
            frmManDinhDatPhong_Accessor target = new frmManDinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BT_Thoat_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for frmManDinhDatPhong Constructor
        ///</summary>
        [TestMethod()]
        public void frmManDinhDatPhongConstructorTest()
        {
            frmManDinhDatPhong target = new frmManDinhDatPhong();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
