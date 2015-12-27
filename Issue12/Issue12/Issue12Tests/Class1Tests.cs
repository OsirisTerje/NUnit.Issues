using NUnit.Framework;
using Issue12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue12.Tests
{
    [TestFixture()]
    public class Class1Tests
    {
        [Test]
        public void AddTest()
        {
            var sut = new Class1();
            var res = sut.Add(2, 3);
            Assert.That(res, Is.EqualTo(5));
        }

        [Test]
        public async void CheckAddAsync()
        {
            var sut = new Class1();
            var result = await sut.AddAsync(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public async Task CheckAddAsyncWithTaskReturn()
        {
            var sut = new Class1();
            var result = await sut.AddAsync(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public async Task CheckLambdas()
        {
            var sut = new Class1();
            Assert.That(async () => await sut.AddAsync(2, 3), Is.EqualTo(5));
            Assert.That(async () => await sut.AddAsync(42, 3), Is.EqualTo(45));
        }

    }
}