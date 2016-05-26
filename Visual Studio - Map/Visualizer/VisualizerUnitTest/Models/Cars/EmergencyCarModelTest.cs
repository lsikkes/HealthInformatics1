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
    public class EmergencyCarModelTest
    {
        #region Fields

        private VRPosition position;
        private EmergencyCarModel emergencyCar;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(23, 42, 100);
            emergencyCar = new EmergencyCarModel(position, 10);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(emergencyCar);
            Assert.False(emergencyCar.SirenOn);
        }

        #endregion Methods
    }
}