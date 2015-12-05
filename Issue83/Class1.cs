using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue83
{
    public class TestClass
    {

        [Test]
        public void ThisHasNoLongName()
        {
            Assert.IsTrue(true);
        }


        [TestCase("这个是中文内容, CSharp is the bast", 
            "这是中国语内容，CSharp is the best language.",
            "这<del class='diffdel'>个</del>是中<del class='diffmod'>文</del><ins class='diffmod'>国语</ins>内容<del class='diffmod'>, CSharp</del><ins class='diffmod'>，CSharp</ins> is the <del class='diffmod'>bast</del><ins class='diffmod'>best language.</ins>"
            )]
        public void ThisHasALongName(string s1, string s2, string s3)
        {
            Assert.That(s1.Length,Is.GreaterThan(0));
            Assert.That(s2.Length, Is.GreaterThan(0));
            Assert.That(s3.Length, Is.GreaterThan(0));
        }
    }
}
