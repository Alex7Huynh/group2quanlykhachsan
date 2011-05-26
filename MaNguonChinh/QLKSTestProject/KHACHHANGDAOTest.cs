using DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for KHACHHANGDAOTest and is intended
    ///to contain all KHACHHANGDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KHACHHANGDAOTest
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
        ///A test for LayDSKhach
        ///</summary>
        [TestMethod()]
        public void LayDSKhachTest()
        {
            //List<KHACHHANG> expected = null; // TODO: Initialize to an appropriate value
            //List<KHACHHANG> actual;
            //actual = KHACHHANGDAO.LayDSKhach();
            //Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for KHACHHANGDAO Constructor
        ///</summary>
        [TestMethod()]
        public void KHACHHANGDAOConstructorTest()
        {
            KHACHHANGDAO target = new KHACHHANGDAO();
        }
    }
}
