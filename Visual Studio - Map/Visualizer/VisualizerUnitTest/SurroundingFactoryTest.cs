using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;
using Visualizer.Surroundings;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class SurroundingFactoryTest
    {
        #region Methods

        [Test]
        public void createSurroundingFactoryTest()
        {
            SurroundingFactory surroundingFactory = new SurroundingFactory();
            Assert.IsNotNull(surroundingFactory);
        }

        #endregion Methods
    }
}