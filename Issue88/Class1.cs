using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue88
{
    [TestFixture]
    public class UnitTest1
    {
        class WTF
        {
            ~WTF() { throw new Exception(); }
        }

        WTF wtf;

        [TestFixtureSetUp]
        public void SU()
        {
            wtf = new WTF();
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(2, 2);
        }

        [TestFixtureTearDown]
        public void TD()
        {
            wtf = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
