using NUnit.Framework;
using SillyLib;
using System.Threading.Tasks;

namespace SillyTests
{
	[TestFixture]
	public class SillyTest
	{

		[Test]
		public async Task WillItDie()
		{
			var sut = new Class1();

			sut.DoIt();
			await Task.Delay(20);

			Assert.Fail();
		}
	}
}
