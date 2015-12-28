using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue87
{
    [TestFixture]
    public class SimpleReproAttempt
    {
        [Test]
        [TestCase("I'm valid")]
        [TestCase("So am I!")]
        public async Task Foo(string resource)
        {
            Assert.IsNotNull(resource);

            await Task.Delay(new TimeSpan(0, 0, 1));
        }

        [Test]
        public async Task Foo()
        {
            Assert.IsNotNull(Guid.NewGuid().ToString("N"));

            await Task.Delay(new TimeSpan(0, 0, 1));
        }



        [Test]
        [TestCase("I'm valid")]
        [TestCase("So am I!")]
        public void Bar(string resource)
        {
            Assert.IsNotNull(resource);

        }

        [Test]
        public void Bar()
        {
            Assert.IsNotNull(Guid.NewGuid().ToString("N"));
        }
    }
}
