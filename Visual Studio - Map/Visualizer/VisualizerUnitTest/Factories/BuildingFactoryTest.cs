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
    public class BuildingFactoryTest
    {
        #region Fields

        private BuildingFactory factory;
        private MainWindow main;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            factory = new BuildingFactory();
            main = new MainWindow();
        }

        [Test]
        public void CreateBuildingTest()
        {
            BuildingViewModel bvm = factory.CreateNewBuilding(10, 42, main, 2);
            Assert.NotNull(bvm);
        }

        #endregion Methods
    }
}