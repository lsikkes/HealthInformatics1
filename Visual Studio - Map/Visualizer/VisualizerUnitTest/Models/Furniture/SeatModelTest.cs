namespace VisualizerUnitTest.Models.Furniture
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Models.Furniture;
    using Visualizer.Utilities;

    [TestFixture]
    internal class SeatModelTest
    {
        #region Fields

        private VRPosition position;
        private SeatModel seat;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(500, 500, 0);
            seat = new SeatModel(position, 50);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(seat);
        }

        #endregion Methods
    }
}