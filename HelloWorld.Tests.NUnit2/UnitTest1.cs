using System;

namespace HelloWorld.Tests.NUnit2
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
        }

        [Test, Category("F")]
        public void TestMethod2()
        {
            Assert.Fail("Is64BitProcess={0}", Environment.Is64BitProcess);
        }
    }
}
