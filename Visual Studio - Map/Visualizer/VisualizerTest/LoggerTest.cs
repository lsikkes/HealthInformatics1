using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Visualizer;

namespace VisualizerTest
{
    [TestFixture]
    public class LoggerTest
    {
        #region Methods

        private Logger log;

        [SetUp]
        public void setUp()
        {
            log = Logger.GetInstance();
        }

        [Test]
        public void TestLoggerGetInstance()
        {
            Assert.NotNull(log);
        }

        [Test]
        public void TestLogAllGet()
        {
            Assert.True(log.getLogAll());
        }

        [Test]
        public void TestLogAllSet()
        {
            log.setLogAll(false);
            Assert.False(log.getLogAll());
        }

        [Test]
        public void TestLogBackupGet()
        {
            Assert.True(log.getLogBackup());
        }

        [Test]
        public void TestLogBackupSet()
        {
            log.setLogBackup(false);
            Assert.False(log.getLogBackup());
        }

        [Test]
        public void TestToConsoleGet()
        {
            Assert.False(log.getToConsole());
        }

        [Test]
        public void TestToConsoleSet()
        {
            log.setToConsole(true);
            Assert.True(log.getToConsole());
        }

        #endregion Methods
    }
}