using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;

namespace VisualizerUnitTest
{
    using Visualizer.Log
    ;

    [TestFixture]
    public class LoggerEnumTest
    {
        #region Methods

        /// <summary>
        /// Gets the image test.
        /// </summary>
        [Test]
        public void LoggerEnumTestContentAll
            ()
        {
            Assert.NotNull(LoggerEnum.AllString.ToString());
        }

        [Test]
        public void LoggerEnumTestContentDebug
            ()
        {
            Assert.NotNull(LoggerEnum.DebugString.ToString());
            Assert.NotNull(LoggerEnum.DebugColor.ToString());
        }

        [Test]
        public void LoggerEnumTestContentError
            ()
        {
            Assert.NotNull(LoggerEnum.ErrorString.ToString());
            Assert.NotNull(LoggerEnum.ErrorColor.ToString());
        }

        [Test]
        public void LoggerEnumTestContentInfo
            ()
        {
            Assert.NotNull(LoggerEnum.InfoString.ToString());
            Assert.NotNull(LoggerEnum.InfoColor.ToString());
        }

        [Test]
        public void LoggerEnumTestContentWarning
            ()
        {
            Assert.NotNull(LoggerEnum.WarningString.ToString());
            Assert.NotNull(LoggerEnum.WarningColor.ToString());
        }

        #endregion Methods
    }
}