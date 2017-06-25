using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue336
{
    [Category("OnClass")]
    public class Outer
    {
        [Category("OnMethod")]
        [Test]
        public void TestIt()
        {
            Assert.Pass();
        }
    }


    [Category("OnClassAndMethod")]
    public class Outer2
    {
        [Category("OnClassAndMethod")]
        [Test]
        public void TestIt2()
        {
            Assert.Pass();
        }
    }
}
