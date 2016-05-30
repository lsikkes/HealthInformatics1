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
        public void LoggerEnumTestContent
            ()
        {
            Assert.NotNull(LoggerEnum.AllString.ToString());
            Assert.NotNull(LoggerEnum.ErrorString.ToString());
            Assert.NotNull(LoggerEnum.InfoString.ToString());
            Assert.NotNull(LoggerEnum.WarningString.ToString());
            Assert.NotNull(LoggerEnum.ErrorColor.ToString());
            Assert.NotNull(LoggerEnum.InfoColor.ToString());
            Assert.NotNull(LoggerEnum.WarningColor.ToString());
            Assert.NotNull(LoggerEnum.WarningColor.ToString());
        }

        #endregion Methods
    }
}