using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;
using Visualizer.Tv;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class TvFactoryTest
    {
        #region Methods

        [Test]
        public void creatTvFactoryTest()
        {
            TVFactory tvFactory = new TVFactory();
            Assert.IsNotNull(tvFactory);
        }

        #endregion Methods
    }
}