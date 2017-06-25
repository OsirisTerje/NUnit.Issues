using NUnit.Framework;

namespace Test_NUnit_timeout_message
{
    [TestFixture]
    public class TimeoutTests
    {
        [Test, Timeout(1000)]
        public void Timeout()
        {
            while (true)
            {
            }
        }
    }
}
