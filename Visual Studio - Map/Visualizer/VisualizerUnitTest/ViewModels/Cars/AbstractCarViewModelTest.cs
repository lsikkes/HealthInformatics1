namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture]
    public class AbstractCarViewModelTest
    {
        #region Fields

        private VRPosition position1;
        private AbstractCarViewModel car;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            car = new AmbulanceCarViewModel(position1, 1);
        }

        [Test]
        public void HeightTest()
        {
            Assert.AreEqual(car.Height, 150);
        }

        [Test]
        public void WidthTest()
        {
            Assert.AreEqual(car.Width, 75);
        }

        #endregion Methods
    }
}