namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture]
    public class BuildingViewModelTest
    {
        #region Fields

        private VRPosition position1;
        private BuildingViewModel building1;
        private BuildingViewModel building2;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            building1 = new BuildingViewModel(position1, 1);
            building2 = new BuildingViewModel(position1, 2);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(building1);
        }

        [Test]
        public void HeightBuilding1Test()
        {
            int actualHeight = building1.Height;
            int expectedHeight = 100;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void WidthBuilding2Test()
        {
            int actualWidth = building1.Width;
            int expectedWidth = 100;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        #endregion Methods
    }
}