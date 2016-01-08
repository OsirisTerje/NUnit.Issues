using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IssueOnThrow
{
    public class CheckThrowing
    {
        readonly List<ModelConnectionChanges> modelConnections = new List<ModelConnectionChanges>();

        [Test]
        public void CheckThrowMessage()
        {
            Assert.That(
                () => modelConnections.Add(new ModelConnectionChanges("whatever")),
                Throws.ArgumentException.With.Message.Not.Empty);
        }

        
    }

    public class ModelConnectionChanges
    {
        public ModelConnectionChanges(string something)
        {
            throw new NotImplementedException();
        }
    }
}
