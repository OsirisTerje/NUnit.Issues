using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue298FW.Test
{
    public class Class1
    {
        [Test]
        public void TestAdd()
        {
            var sut = new Issue298.Math();
            var res = sut.Add(2, 3);
            Assert.That(res, Is.EqualTo(5));
        }
    }
}
