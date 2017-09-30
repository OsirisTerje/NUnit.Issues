using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue_251
{
    using System;
    using NUnit.Framework;

   
        [TestFixture]
        public class UnitTestClass1
        {
            [Test]
            [Parallelizable(ParallelScope.All)]
            public void Class1TestMethod1()
            {
                Console.WriteLine(TestContext.Parameters["testParameter1"]);
            }
        }
    
}
