using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue291
{
    public class OuterClass
    {
        [TestFixture]
        public class InnerClass
        {
            [Test]
            public void ShouldBeAbleToNavigateHere_WillItFail()
            {
                Assert.Fail();
            }
        }
    }
}
