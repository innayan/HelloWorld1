using ClassLibrary1;

using NUnit.Framework;

namespace HelloWorld.Tests.Ref
{
    public class UnitTest2
    {
        private SomeClass _class;

        [SetUp]
        public void SetUp()
        {
            this._class = new SomeClass();
        }

        [Test, Category("SE")]
        public void TestMethodRefFailed()
        {
        }
    }
}
