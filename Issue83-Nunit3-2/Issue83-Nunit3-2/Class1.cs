using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue83_Nunit3_2
{
    public class TestIt
    {
        [Timeout(1000)]
        [Test]
        public void Run()
        {
            while (true)
            { }
            Assert.Pass();
        }
    }
}
