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
    [TestFixture]
    public class LoggerTest
    {
        #region Methods

        [Test]
        public void GetInstanceTest()
        {
            Logger log = Logger.GetInstance();
            Assert.NotNull(log);
        }

        /// <summary>
        /// Gets the path to the Visualizer map. The logger adds the logger map itself.
        /// </summary>
        /// <returns> string with the path to the Visualizer map </returns>
        private string getPath()
        {
            string path = Path.GetDirectoryName(
              System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string newPath = "";
            string[] paths = path.Split('\\');
            for (int i = 1; i < paths.Length - 4; i++)
            {
                newPath = newPath + "\\" + paths[i];
            }
            newPath = newPath.Substring(1);
            return newPath;
        }

        #endregion Methods
    }
}