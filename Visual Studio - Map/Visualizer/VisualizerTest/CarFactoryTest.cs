using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Visualizer;

namespace VisualizerTest
{
    [TestClass]
    public class CarFactoryTest
    {
        #region Methods

        [TestMethod]
        public void createCarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();
            Assert.IsNotNull(carFactory);
        }

        [TestMethod]
        public void createCarTest()
        {
            String type = "police";
            int x = 5;
            int y = 5;
            int rotation = 20;
            CarFactory carFactory = new CarFactory();
            Car car = carFactory.createCar(type, x, y, rotation);
            Assert.IsNotNull(car);
        }

        #endregion Methods
    }
}