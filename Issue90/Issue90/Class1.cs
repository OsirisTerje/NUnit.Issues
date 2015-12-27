using NUnit.Framework;

namespace Issue90
{
    public class Class1
    {
        readonly string[] myPasswords = { "Tim'sHouse" };
        [Test]
        [TestCaseSource("myPasswords")]
        public void EnterPassword(string password)
        {
            //here the input parameter for password is >>Tim\'sBar<<. 
            Assert.That("Tim\\'sHouse", Is.Not.EqualTo(password));
        }

        [Test]
        [TestCaseSource("myPasswords")]
        public void EnterPassword2(string password)
        {
            //here the input parameter for password is >>Tim\'sBar<<. 
            Assert.AreEqual(myPasswords[0], password, "Should work");//This should compare the input value to the input value, however this fails!
        }
    }
}
