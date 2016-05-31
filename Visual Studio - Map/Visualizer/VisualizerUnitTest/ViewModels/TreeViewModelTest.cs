namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture]
    public class TreeViewModelTest
    {
        #region Fields

        private VRPosition position1;
        private TreeViewModel tree1;
        private TreeViewModel tree2;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            tree1 = new TreeViewModel(position1, 1);
            tree2 = new TreeViewModel(position1, 2);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(tree1);
        }

        [Test]
        public void HeightTree1Test()
        {
            int actualHeight = tree1.Height;
            int expectedHeight = 100;
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [Test]
        public void WidthTree2Test()
        {
            int actualWidth = tree2.Width;
            int expectedWidth = 100;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        #endregion Methods
    }
}