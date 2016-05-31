namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture]
    public class PoliceCarViewModelTest
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
            car = new PoliceCarViewModel(position1, 1);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(car);
        }

        #endregion Methods
    }
}