using NUnit.Framework;
using System;

namespace NUnitWarningTest
{
    [TestFixture]
    public class FixtureWithSetupAndTeardown
    {
        [TearDown]
        public void TF1_TearDown()
        {
            Assert.Warn("teardown warning");
        }

        [SetUp]
        public void TF1_Setup()
        {
            Assert.Warn("setup warning");
        }

        [Test]
        public void FWSAT_TestWithAssertFail()
        {
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWSAT_TestWithException()
        {
            throw new Exception("exception 1");
        }

        [Test]
        public void FWSAT_TestWithAssertWarnAndFail()
        {
            Assert.Warn("test warning");
            Assert.Fail("failure 1");
        }

        [Test]
        public void FWSAT_TestWithAssertWarnAndException()
        {
            Assert.Warn("test warning");
            throw new Exception("exception 1");
        }
    }
}