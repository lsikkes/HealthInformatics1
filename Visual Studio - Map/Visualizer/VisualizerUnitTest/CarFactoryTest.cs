using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizer;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class CarFactoryTest
    {
        #region Methods

        [Test]
        public void createCarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();
            Assert.IsNotNull(carFactory);
        }

        #endregion Methods
    }
}