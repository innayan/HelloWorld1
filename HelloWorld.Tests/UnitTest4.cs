using System;
using System.Threading;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest4
    {
        private static readonly Random Rnd = new Random();

        [Test]
        [Parallelizable]
        public void TestMethodSuccess()
        {
        }

        [Test]
        [Parallelizable]
        public void TestMethodFail()
        {
            Assert.Fail("Is64BitProcess={0}, Thread={1}", Environment.Is64BitProcess, Thread.CurrentThread.GetHashCode());
        }


        [Test, Category("A")]
        [Parallelizable]
        public void TestMethodCatA()
        {
        }

        [Test, Category("B")]
        [Parallelizable]
        public void TestMethodCatB()
        {
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM01()
        {
            DoTest(1);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM02()
        {
            DoTest(2);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM03()
        {
            DoTest(3);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM04()
        {
            DoTest(4);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM05()
        {
            DoTest(5);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM06()
        {
            DoTest(6);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM07()
        {
            DoTest(7);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM08()
        {
            DoTest(8);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM09()
        {
            DoTest(9);
        }

        [Test, Category("M")]
        [Parallelizable]
        public void TestMethodCatM10()
        {
            DoTest(10);
        }

        private static void DoTest(int testId)
        {
            var testName = string.Format("Test {0}", testId);
            Console.WriteLine("Start test {0}", testName);
            Thread.Sleep(Rnd.Next(500));
            Console.WriteLine("Finish test {0}", testName);
        }
    }
}
