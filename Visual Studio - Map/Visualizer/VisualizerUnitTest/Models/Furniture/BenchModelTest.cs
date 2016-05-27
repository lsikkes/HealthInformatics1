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
    public class BenchModelTest
    {
        #region Fields

        private VRPosition position;
        private BenchModel bench;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(1, 1, 0);
            bench = new BenchModel(position, 11, 0);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(bench);
        }

        [Test]
        public void AddSeatTest()
        {
            bench.AddSeat();
            Assert.AreEqual(1, bench.NumberOfSeats);
        }

        [Test]
        public void RemoveSeatFailTest()
        {
            bench.RemoveSeat();
            Assert.AreEqual(0, bench.NumberOfSeats);
        }

        [Test]
        public void RemoveSeatSucceedTest()
        {
            bench.AddSeat();
            bench.AddSeat();
            bench.RemoveSeat();
            Assert.AreEqual(1, bench.NumberOfSeats);
        }

        #endregion Methods
    }
}