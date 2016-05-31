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
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;

    [TestFixture, Apartment(ApartmentState.STA)]
    public class CarFactoryTest
    {
        #region Fields

        private CarFactory factory;
        private MainWindow main;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            factory = new CarFactory();
            main = new MainWindow();
        }

        [Test]
        public void TypeTest1()
        {
            AbstractCarViewModel vm = factory.CreateCar(90, 50, 50, main, 0, (int) CarEnum.Normal);
            Assert.AreEqual(vm.GetType(), typeof(NormalCarViewModel));
        }

        [Test]
        public void TypeTest2()
        {
            AbstractCarViewModel vm = factory.CreateCar(90, 50, 50, main, 0, (int) CarEnum.Police);
            Assert.AreEqual(vm.GetType(), typeof(PoliceCarViewModel));
        }

        [Test]
        public void TypeTest3()
        {
            AbstractCarViewModel vm = factory.CreateCar(90, 50, 50, main, 0, (int) CarEnum.Ambulance);
            Assert.AreEqual(vm.GetType(), typeof(AmbulanceCarViewModel));
        }

        [Test]
        public void TypeTest4()
        {
            AbstractCarViewModel vm = factory.CreateCar(90, 50, 50, main, 0, (int) CarEnum.Firetruck);
            Assert.AreEqual(vm.GetType(), typeof(FiretruckCarViewModel));
        }

        [Test]
        public void TypeTest5()
        {
            AbstractCarViewModel vm = factory.CreateCar(90, 50, 50, main, 0, 6);
            Assert.Null(vm);
        }

        #endregion Methods
    }
}