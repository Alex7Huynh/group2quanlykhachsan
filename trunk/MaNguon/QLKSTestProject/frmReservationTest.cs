using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for frmReservationTest and is intended
    ///to contain all frmReservationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmReservationTest
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
        ///A test for UpdateDuration
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void UpdateDurationTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.UpdateDuration();
            
        }

        /// <summary>
        ///A test for SetInputValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void SetInputValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.SetInputValue();
            
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            
        }

        /// <summary>
        ///A test for GetPhieuThue
        ///</summary>
        [TestMethod()]
        public void GetPhieuThueTest()
        {
            bool keoTha = false; // TODO: Initialize to an appropriate value
            string soPhong = "A111"; // TODO: Initialize to an appropriate value
            frmReservation target = new frmReservation(keoTha, soPhong); // TODO: Initialize to an appropriate value
            PHIEUTHUE expected = null; // TODO: Initialize to an appropriate value
            PHIEUTHUE actual;
            actual = target.GetPhieuThue();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for frmReservation_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void frmReservation_LoadTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.frmReservation_Load(sender, e);
            
        }

        /// <summary>
        ///A test for dtpEndDate_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtpEndDate_ValueChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtpEndDate_ValueChanged(sender, e);
            
        }

        /// <summary>
        ///A test for dtpBeginDate_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void dtpBeginDate_ValueChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.dtpBeginDate_ValueChanged(sender, e);
            
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            
        }

        /// <summary>
        ///A test for CheckInputValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void CheckInputValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.CheckInputValue();
            
        }

        /// <summary>
        ///A test for cboPhong_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void cboPhong_SelectedIndexChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.cboPhong_SelectedIndexChanged(sender, e);
            
        }

        /// <summary>
        ///A test for cboLoaiPhong_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void cboLoaiPhong_SelectedIndexChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            frmReservation_Accessor target = new frmReservation_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.cboLoaiPhong_SelectedIndexChanged(sender, e);
            
        }





        /// <summary>
        ///A test for frmReservation Constructor
        ///</summary>
        [TestMethod()]
        public void frmReservationConstructorTest()
        {
            bool keoTha = false; // TODO: Initialize to an appropriate value
            string soPhong = "A111"; // TODO: Initialize to an appropriate value
            frmReservation target = new frmReservation(keoTha, soPhong);
        }
    }
}
