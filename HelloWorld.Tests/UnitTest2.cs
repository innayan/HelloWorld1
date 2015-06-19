using System;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest2
    {
        [SetUp]
        public void SetUp()
        {
            throw new Exception("SetUp exception");
        }

        [Test, Category("SE")]
        [Parallelizable]
        public void TestMethodSetUpFailed()
        {
        }
    }
}
