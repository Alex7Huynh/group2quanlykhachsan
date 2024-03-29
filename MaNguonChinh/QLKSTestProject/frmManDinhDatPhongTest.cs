﻿using QLKS;
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
            frmManHinhDatPhong target = new frmManHinhDatPhong(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            target.StartPoint = expected;
            actual = target.StartPoint;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseMove
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseMoveTest()
        {
            frmManHinhDatPhong_Accessor target = new frmManHinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseMove(sender, e);
            
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseDownTest()
        {
            frmManHinhDatPhong_Accessor target = new frmManHinhDatPhong_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseDown(sender, e);
            
        }

        /// <summary>
        ///A test for MoveForm
        ///</summary>
        [TestMethod()]
        public void MoveFormTest()
        {
            frmManHinhDatPhong target = new frmManHinhDatPhong(); // TODO: Initialize to an appropriate value
            Point distance = new Point(); // TODO: Initialize to an appropriate value
            target.MoveForm(distance);
            
        }
    }
}
