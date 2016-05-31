namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using System.Windows.Media;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;

    [TestFixture]
    public class BuildingModelTest
    {
        #region Fields

        private VRPosition position1;
        private BuildingModel buildingModel;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            buildingModel = new BuildingModel(position1, 0);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(buildingModel);
        }

        [Test]
        public void GetBuildingHeightTest()
        {
            int actualHeight = buildingModel.Height;
            int expectedHeight = 100;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void GetBuildingWidthTest()
        {
            int actualWidth = buildingModel.Width;
            int expectedWidth = 100;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void SetBuildingHeightTest()
        {
            buildingModel.Height = 200;
            int actualHeight = buildingModel.Height;
            int expectedHeight = 200;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void SetBuildingWidthTest()
        {
            buildingModel.Width = 200;
            int actualWidth = buildingModel.Width;
            int expectedWidth = 200;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void GetBuildingImageTest()
        {
            ImageSource actualImage = buildingModel.SurroundingImage.ImageSource;
            ImageSource exptedImage = ImageMap.GetImage(ImageEnum.WallImage.ToString());
            Assert.AreEqual(exptedImage, actualImage);
        }

        #endregion Methods
    }
}