using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for HOADONBUSTest and is intended
    ///to contain all HOADONBUSTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HOADONBUSTest
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
        ///A test for HOADONBUS Constructor
        ///</summary>
        [TestMethod()]
        public void HOADONBUSConstructorTest()
        {
            HOADONBUS target = new HOADONBUS();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for layDSHoaDon
        ///</summary>
        [TestMethod()]
        public void layDSHoaDonTest()
        {
            List<HOADON> expected = null; // TODO: Initialize to an appropriate value
            List<HOADON> actual;
            actual = HOADONBUS.layDSHoaDon();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
