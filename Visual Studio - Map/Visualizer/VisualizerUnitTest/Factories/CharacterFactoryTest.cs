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
    public class CharacterFactoryTest
    {
        #region Fields

        private CharacterFactory factory;
        private MainWindow main;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            factory = new CharacterFactory();
            main = new MainWindow();
        }

        [Test]
        public void CreateTest()
        {
            CharacterViewModel vm = factory.CreateCharacter(10, 10, main, 0, 1, 1);
            Assert.NotNull(vm);
        }

        #endregion Methods
    }
}