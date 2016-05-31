namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using System.Windows.Media;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;

    [TestFixture]
    internal class TreeModelTest
    {
        #region Fields

        private VRPosition position1;
        private TreeModel treeModel;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            treeModel = new TreeModel(position1, 0);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(treeModel);
        }

        [Test]
        public void GetTreeHeightTest()
        {
            int actualHeight = treeModel.Height;
            int expectedHeight = 100;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void GetTreeWidthTest()
        {
            int actualWidth = treeModel.Width;
            int expectedWidth = 100;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void SetTreeHeightTest()
        {
            treeModel.Height = 200;
            int actualHeight = treeModel.Height;
            int expectedHeight = 200;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void SetTreeWidthTest()
        {
            treeModel.Width = 200;
            int actualWidth = treeModel.Width;
            int expectedWidth = 200;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void GetTreeImageTest()
        {
            ImageSource actualImage = treeModel.SurroundingImage.ImageSource;
            ImageSource exptedImage = ImageMap.GetImage(ImageEnum.TreeIcon.ToString());
            Assert.AreEqual(exptedImage, actualImage);
        }

        #endregion Methods
    }
}