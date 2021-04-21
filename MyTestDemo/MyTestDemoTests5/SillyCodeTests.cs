using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTestDemo;

namespace MyTestDemo.Tests
{
    [TestClass()]
    public class SillyCodeTests
    {
        SillyCode sc;
        [TestInitialize]
        public void Setup()
        {
            sc = new SillyCode
            {
                Value = 2
            };
        }

        [TestMethod()]
        public void GetNameTest()
        {
            var actual = sc.GetName(new string[] { "Kalle", "Pelle", "Johan" }, 1);
            sc.Value = 4;
            Assert.AreEqual("Pelle", actual);
        }

        [TestMethod()]
        public void GetSumTest()
        {
            var actual = sc.GetSum(new int[] { 1, 10, 20 }, 5);
            var expected = 26;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void TestPropertyValue()
        {
            var actual = sc.Value;
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void TearDown()
        {
            sc = null;
        }

    }
}