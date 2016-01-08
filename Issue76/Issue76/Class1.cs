using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue76
{
    [TestFixture()]
    class JMeter_DataUploader_IntegrationTests
    {
        bool _AnGlobalExceptionWasCaught;

        [SetUp()]
        public void SetupTest()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            _AnGlobalExceptionWasCaught = false;
        }
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            _AnGlobalExceptionWasCaught = true;
        }

        [Test()]
        //[Timeout (10000)]
        public void Test_ConsumerProducer_HighlyThreaded()
        {
            // ...

            // >> Build Consumer
            DataUploader dataUploader = new DataUploader();
            Thread consumer = new Thread(
                delegate ()
                {
                    //  (throws an Exception)
                    dataUploader.UploadData();
                });
            consumer.Start();
            // ...
            Thread.Sleep(1000);
            // Assertions
            Assert.IsTrue(_AnGlobalExceptionWasCaught);
        }

        [Test]
        public void CheckThisToo()
        {
            Assert.IsTrue(true);
        }

        public class DataUploader
        {
            public void UploadData()
            {
                throw new Exception("And there we crashed");
            }
        }
    }
}
