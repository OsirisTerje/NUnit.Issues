using NUnit.Framework;
using System;

namespace NUnitWarningTest
{
    [TestFixture]
    public class FixtureWithOnlyTests
    {
       
        [Test]
        public void FWOT_TestWithAssertFail()
        {
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWOT_TestWithException()
        {
            throw new Exception("exception 1");
        }

        [Test]
        public void FWOT_TestWithAssertWarnAndFail()
        {
            Assert.Warn("test warning");
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWOT_TestWithAssertWarnAndException()
        {
            Assert.Warn("test warning");
            throw new Exception("exception 1");
        }
    }
}