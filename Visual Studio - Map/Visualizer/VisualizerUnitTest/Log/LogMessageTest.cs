using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizer.Log;

namespace VisualizerUnitTest.Log
{
    using NUnit.Framework;

    class LogMessageTest
    {
        #region Fields

        private LogMessage lmi,lmd,lme,lmw,lm;

        #endregion

        #region Methods

        [SetUp]
        public void SetUp()
        {
            lmi = new LogMessageInfo("Info");
            lmd = new LogMessageDebug("Debug");
            lme = new LogMessageError("Error");
            lmw = new LogMessageWarning("Warning");
            lm = new LogMessage("Empty");
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(lmi);
            Assert.IsNotNull(lmd);
            Assert.IsNotNull(lme);
            Assert.IsNotNull(lmw);
            Assert.IsNotNull(lm);
        }

        [Test]
        public void InfoTextTest()
        {
            Assert.IsNotNull(lmi.Text);
            Assert.AreEqual("Info",lmi.Text);
        }

        [Test]
        public void InfoTimeTest()
        {
            Assert.IsNotNull(lmi.Time);
            lmi.Time = "00:00:00";
            Assert.AreEqual("00:00:00",lmi.Time);
        }

        [Test]
        public void InfoTypeTest()
        {
            Assert.IsNotNull(lmi.Type);
            Assert.AreEqual(LoggerEnum.InfoString.ToString(),lmi.Type);
            lmi.Type = "Test";
            Assert.AreEqual("Test", lmi.Type);
        }

        [Test]
        public void InfoColorTest()
        {
            Assert.IsNotNull(lmi.Color);
            Assert.AreEqual(LoggerEnum.InfoColor.ToString(), lmi.Color);
            lmi.Color = "Test";
            Assert.AreEqual("Test", lmi.Color);
        }

        #endregion

    }
}
