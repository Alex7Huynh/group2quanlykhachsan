using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using System.Collections.Generic;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for DinhTest and is intended
    ///to contain all DinhTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DinhTest
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
        ///A test for Index
        ///</summary>
        [TestMethod()]
        public void IndexTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Index = expected;
            actual = target.Index;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DsMau
        ///</summary>
        [TestMethod()]
        public void DsMauTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<int> expected = null; // TODO: Initialize to an appropriate value
            List<int> actual;
            target.DsMau = expected;
            actual = target.DsMau;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DsDinhKe
        ///</summary>
        [TestMethod()]
        public void DsDinhKeTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<List<Dinh>> expected = null; // TODO: Initialize to an appropriate value
            List<List<Dinh>> actual;
            target.DsDinhKe = expected;
            actual = target.DsDinhKe;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DsDinh
        ///</summary>
        [TestMethod()]
        public void DsDinhTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<Dinh> expected = null; // TODO: Initialize to an appropriate value
            List<Dinh> actual;
            target.DsDinh = expected;
            actual = target.DsDinh;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Color
        ///</summary>
        [TestMethod()]
        public void ColorTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Color = expected;
            actual = target.Color;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Bac
        ///</summary>
        [TestMethod()]
        public void BacTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Bac = expected;
            actual = target.Bac;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToMau
        ///</summary>
        [TestMethod()]
        public void ToMauTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<Dinh> dsDinh = null; // TODO: Initialize to an appropriate value
            target.ToMau(dsDinh);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TinhMau
        ///</summary>
        [TestMethod()]
        public void TinhMauTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> dsPhieu = null; // TODO: Initialize to an appropriate value
            List<int> expected = null; // TODO: Initialize to an appropriate value
            List<int> actual;
            actual = target.TinhMau(dsPhieu);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TinhBac
        ///</summary>
        [TestMethod()]
        public void TinhBacTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> dsPhieu = null; // TODO: Initialize to an appropriate value
            target.TinhBac(dsPhieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TaoDSDinhKe
        ///</summary>
        [TestMethod()]
        public void TaoDSDinhKeTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> dsPhieu = null; // TODO: Initialize to an appropriate value
            target.TaoDSDinhKe(dsPhieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TaoDSDinh
        ///</summary>
        [TestMethod()]
        public void TaoDSDinhTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            List<PHIEUTHUE> dsPhieu = null; // TODO: Initialize to an appropriate value
            target.TaoDSDinh(dsPhieu);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LaLienKe
        ///</summary>
        [TestMethod()]
        public void LaLienKeTest()
        {
            Dinh target = new Dinh(); // TODO: Initialize to an appropriate value
            PHIEUTHUE phieu1 = null; // TODO: Initialize to an appropriate value
            PHIEUTHUE phieu2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.LaLienKe(phieu1, phieu2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dinh Constructor
        ///</summary>
        [TestMethod()]
        public void DinhConstructorTest()
        {
            Dinh target = new Dinh();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
