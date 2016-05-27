namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture]
    public class BenchViewModelTest
    {
        #region Fields

        private VRPosition position1;
        private BenchViewModel bench1;
        private BenchViewModel bench2;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            bench1 = new BenchViewModel(position1, 1, 2);
            bench2 = new BenchViewModel(position1, 2, 3);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(bench1);
        }

        [Test]
        public void WidthOfRectangleBench1Test()
        {
            int actualWidth = bench1.BenchRectangleWidth;
            int amountSeats = bench1.AmountSeats;
            int expectedWidth = 100 * amountSeats;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void WidthOfRectangleBench2Test()
        {
            int actualWidth = bench2.BenchRectangleWidth;
            int amountSeats = bench2.AmountSeats;
            int expectedWidth = 100 * amountSeats;
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        #endregion Methods
    }
}