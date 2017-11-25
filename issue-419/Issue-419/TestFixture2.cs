using NUnit.Framework;
using System;

namespace NUnitWarningTest
{
    [TestFixture]
    public class FixtureWithTearDownOnly
    {
        [TearDown]
        public void TearDown()
        {
            Assert.Warn("teardown warning");
        }

        [Test]
        public void FWTDO_TestWithAssertFail()
        {
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWTDO_TestWithException()
        {
            throw new Exception("exception 1");
        }

        [Test]
        public void FWTDO_TestWithAssertWarnAndFail()
        {
            Assert.Warn("test warning");
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWTDO_TestWithAssertWarnAndException()
        {
            Assert.Warn("test warning");
            throw new Exception("exception 1");
        }
    }
}