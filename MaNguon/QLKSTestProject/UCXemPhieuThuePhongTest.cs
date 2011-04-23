using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using System.Windows.Forms;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for UCXemPhieuThuePhongTest and is intended
    ///to contain all UCXemPhieuThuePhongTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UCXemPhieuThuePhongTest
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
        ///A test for Ngaythue
        ///</summary>
        [TestMethod()]
        public void NgaythueTest()
        {
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            UCXemPhieuThuePhong.Ngaythue = expected;
            actual = UCXemPhieuThuePhong.Ngaythue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Kethuc
        ///</summary>
        [TestMethod()]
        public void KethucTest()
        {
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            UCXemPhieuThuePhong.Kethuc = expected;
            actual = UCXemPhieuThuePhong.Kethuc;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for flag
        ///</summary>
        [TestMethod()]
        public void flagTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.flag = expected;
            actual = target.flag;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateRowsAndColumns
        ///</summary>
        [TestMethod()]
        public void UpdateRowsAndColumnsTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            target.UpdateRowsAndColumns();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateRowsTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateRows();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateMau
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateMauTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateMau();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateColumns
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateColumnsTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateColumns();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemovePhong
        ///</summary>
        [TestMethod()]
        public void RemovePhongTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            PHONG phong = null; // TODO: Initialize to an appropriate value
            target.RemovePhong(phong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemoveAll
        ///</summary>
        [TestMethod()]
        public void RemoveAllTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            target.RemoveAll();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for kiemtraPhongThueHopLe
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void kiemtraPhongThueHopLeTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            int _rowdown = 0; // TODO: Initialize to an appropriate value
            int _rowup = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.kiemtraPhongThueHopLe(_rowdown, _rowup);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for kiemTraPhieuThue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void kiemTraPhieuThueTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            PHONG phong = null; // TODO: Initialize to an appropriate value
            DateTime dtbatdau = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime dtketthuc = new DateTime(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.kiemTraPhieuThue(phong, dtbatdau, dtketthuc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for kiemtraNgayThueHopLe
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void kiemtraNgayThueHopLeTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            DateTime _ngaythue = new DateTime(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.kiemtraNgayThueHopLe(_ngaythue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dtgTheHienPhieuThuePhong_Paint
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtgTheHienPhieuThuePhong_PaintTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            PaintEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtgTheHienPhieuThuePhong_Paint(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dtgTheHienPhieuThuePhong_CellPainting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtgTheHienPhieuThuePhong_CellPaintingTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellPaintingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtgTheHienPhieuThuePhong_CellPainting(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dtgTheHienPhieuThuePhong_CellMouseUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtgTheHienPhieuThuePhong_CellMouseUpTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellMouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtgTheHienPhieuThuePhong_CellMouseUp(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dtgTheHienPhieuThuePhong_CellMouseDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtgTheHienPhieuThuePhong_CellMouseDownTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellMouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtgTheHienPhieuThuePhong_CellMouseDown(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dtgTheHienPhieuThuePhong_CellFormatting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtgTheHienPhieuThuePhong_CellFormattingTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellFormattingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtgTheHienPhieuThuePhong_CellFormatting(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            UCXemPhieuThuePhong_Accessor target = new UCXemPhieuThuePhong_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddPhong
        ///</summary>
        [TestMethod()]
        public void AddPhongTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            PHONG phong = null; // TODO: Initialize to an appropriate value
            target.AddPhong(phong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddDateRange
        ///</summary>
        [TestMethod()]
        public void AddDateRangeTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong(); // TODO: Initialize to an appropriate value
            DateTime BeginDate = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime EndDate = new DateTime(); // TODO: Initialize to an appropriate value
            target.AddDateRange(BeginDate, EndDate);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UCXemPhieuThuePhong Constructor
        ///</summary>
        [TestMethod()]
        public void UCXemPhieuThuePhongConstructorTest()
        {
            UCXemPhieuThuePhong target = new UCXemPhieuThuePhong();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
