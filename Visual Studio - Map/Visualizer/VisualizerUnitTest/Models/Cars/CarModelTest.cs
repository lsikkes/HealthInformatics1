namespace VisualizerUnitTest.Models.Cars
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Models.Cars;
    using Visualizer.Utilities;

    [TestFixture]
    public class CarModelTest
    {
        #region Fields

        private VRPosition position;
        private CarModel car;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(123, 321, 0);
            car = new CarModel(position, 42);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(car);
        }

        #endregion Methods
    }
}