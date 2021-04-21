#pragma warning disable RCS1118 // Mark local variable as const.
#pragma warning disable IDE0008 // Use explicit type
#pragma warning disable CC0030 // Make Local Variable Constant.
namespace MyTestDemo.Tests
{
    using NUnit.Framework;
    using MyTestDemo;

    [TestFixture()]
    public class SillyCodeTests
    {
        private SillyCode sc;
        [SetUp]
        public void Setup()
        {
            sc = new SillyCode
            {
                Value = 2
            };
        }


        [Test]
        public void StringLengthWithText()
        {
            Assert.AreEqual(6, sc.GetLength("Marcus"));
        }

        [Test]
        public void StringLengthWithNULL()
        {
            Assert.AreEqual(0, sc.GetLength(null));
        }

        [Test]
        public void GetNameTest()
        {
            var actual = sc.GetName(new string[] { "Kalle", "Pelle", "Johan" }, 1);
            sc.Value = 4;
            Assert.AreEqual("Pelle", actual);
            Assert.IsTrue(actual == "Pelle");
        }

        [Test]
        public void GetSumTest()
        {
            var actual = sc.GetSum(new int[] { 1, 10, 20 }, 5);
            var expected = 26;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPropertyValue()
        {
            var actual = sc.Value;
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            sc = null;
        }

    }
}
#pragma warning restore IDE0008 // Use explicit type
#pragma warning restore RCS1118 // Mark local variable as const.
#pragma warning restore CC0030 // Make Local Variable Constant.
