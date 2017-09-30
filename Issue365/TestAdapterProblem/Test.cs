using Mono.Cecil;
using NUnit.Framework;

namespace TestAdapterProblem
{
    [TestFixture]
    class Test
    {
        [Test]
        public void TestMethod()
        {
            var assemblyResolver = new DefaultAssemblyResolver();
        }
    }
}
