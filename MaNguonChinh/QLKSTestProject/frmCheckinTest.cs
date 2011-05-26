using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for frmCheckinTest and is intended
    ///to contain all frmCheckinTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmCheckinTest
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
        ///A test for KhoiTaoComboBox
        ///</summary>
        //[TestMethod()]
        //public void KhoiTaoComboBoxTest()
        //{
        //    frmCheckin target = new frmCheckin(); // TODO: Initialize to an appropriate value
        //    target.KhoiTaoComboBox();
        //    
        //}

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            frmCheckin_Accessor target = new frmCheckin_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            frmCheckin_Accessor target = new frmCheckin_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            
        }

        /// <summary>
        ///A test for comboBox1_SelectedIndexChanged
        ///</summary>
        //[TestMethod()]
        //[DeploymentItem("QLKS.exe")]
        //public void comboBox1_SelectedIndexChangedTest()
        //{
        //    frmCheckin_Accessor target = new frmCheckin_Accessor(); // TODO: Initialize to an appropriate value
        //    object sender = null; // TODO: Initialize to an appropriate value
        //    EventArgs e = null; // TODO: Initialize to an appropriate value
        //    target.comboBox1_SelectedIndexChanged(sender, e);
        //    
        //}

        /// <summary>
        ///A test for button1_Click
        ///</summary>
        //[TestMethod()]
        //[DeploymentItem("QLKS.exe")]
        //public void button1_ClickTest()
        //{
        //    frmCheckin_Accessor target = new frmCheckin_Accessor(); // TODO: Initialize to an appropriate value
        //    object sender = null; // TODO: Initialize to an appropriate value
        //    EventArgs e = null; // TODO: Initialize to an appropriate value
        //    target.button1_Click(sender, e);
        //    
        //}

        /// <summary>
        ///A test for frmCheckin Constructor
        ///</summary>
        [TestMethod()]
        public void frmCheckinConstructorTest()
        {
            frmCheckin target = new frmCheckin();
        }
    }
}
