using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class TvFactoryTest
    {
        #region Methods

        [Test]
        public void creatTvFactoryTest()
        {
            TvFactory tvFactory = new TvFactory();
            Assert.IsNotNull(tvFactory);
        }

        #endregion Methods
    }
}