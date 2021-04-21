using NUnit.Framework;
using MyTestDemo;

namespace MyTestDemo.Tests
{
    [TestFixture()]
    public class SillyCodeTests
    {
        [Test()]
        public void GetNameTest()
        {
            Assert.Fail();
        }

        public void GetNameTest1()
        {

        }
    }
}