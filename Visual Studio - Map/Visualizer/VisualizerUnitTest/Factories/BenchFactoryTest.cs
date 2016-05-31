namespace VisualizerUnitTest.Factories
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Visualizer;
    using Visualizer.Factories;
    using Visualizer.Utilities;
    using Visualizer.ViewModels;

    [TestFixture, Apartment(ApartmentState.STA)]
    public class BenchFactoryTest
    {
        #region Fields

        private BenchFactory factory;
        private MainWindow main;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            factory = new BenchFactory();
            main = new MainWindow();
        }

        [Test]
        public void CreateBuildingTest()
        {
            BenchViewModel tvm = factory.CreateNewBench(10, 42, main, 3, 2);
            Assert.NotNull(tvm);
        }

        #endregion Methods
    }
}