using System;
using NUnit.Framework;

namespace Issue298.Test
{
    public class MathTest
    {
        [Test]
        public void TestAdd()
        {
            var sut = new Math();
            var res = sut.Add(2, 3);
            Assert.That(res,Is.EqualTo(5));
        }
    }
}
