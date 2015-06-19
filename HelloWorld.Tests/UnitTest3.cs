using System.Collections.Generic;
using System.Threading;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest3
    {
        [Test, Category("OOM")]
        [Parallelizable]
        public void TestMethodOOM()
        {
            MakeOutOfMemory();
        }

        [Test, Category("OOMT")]
        [Parallelizable]
        public void TestMethodOOMInThread()
        {
            var thread = new Thread(MakeOutOfMemory) { IsBackground = false };
            thread.Start();
            thread.Join();
        }

        private static void MakeOutOfMemory()
        {
            var list = new List<byte[]>();
            while (true)
            {
                list.Add(new byte[0x40000000]);
                Thread.Sleep(1);
            }
        }
    }
}
