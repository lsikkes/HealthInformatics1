namespace VisualizerUnitTest.Models.Furniture
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Models.Cars;
    using Visualizer.Models.Furniture;
    using Visualizer.Utilities;

    [TestFixture]
    public class CarModelTests
    {
        #region Fields

        private VRPosition position;
        private AmbulanceCarModel a1, a2;
        private CarModel c1, c2;
        private FiretruckCarModel f1, f2;
        private PoliceCarModel p1, p2;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(1, 1, 0);
            a1 = new AmbulanceCarModel(position, 11);
            a2 = new AmbulanceCarModel(position, 11);
            c1 = new CarModel(position, 11);
            c2 = new CarModel(position, 11);
            f1 = new FiretruckCarModel(position, 11);
            f2 = new FiretruckCarModel(position, 11);
            p1 = new PoliceCarModel(position, 11);
            p2 = new PoliceCarModel(position, 11);

        }

        [Test]
        public void ConstructorTestAmbulance()
        {
            Assert.NotNull(a1);
            Assert.NotNull(a2);
        }

        [Test]
        public void ConstructorTestNormal()
        {
            Assert.NotNull(c1);
            Assert.NotNull(c2);
        }

        [Test]
        public void ConstructorTestFiretruck()
        {
            Assert.NotNull(f1);
            Assert.NotNull(f2);
        }

        [Test]
        public void ConstructorTestPolice()
        {
            Assert.NotNull(p1);
            Assert.NotNull(p2);
        }

        [Test]
        public void NotEqual1()
        {
            Assert.AreNotEqual(a1.Image, p1.Image);
        }

        [Test]
        public void NotEqual2()
        {
            Assert.AreNotEqual(a1.Image, f1.Image);
        }

        [Test]
        public void NotEqual3()
        {
            Assert.AreNotEqual(a1.Image, c1.Image);
        }

        [Test]
        public void NotEqual4()
        {
            Assert.AreNotEqual(f1.Image, p1.Image);
        }

        [Test]
        public void NotEqual5()
        {
            Assert.AreNotEqual(f1.Image, c1.Image);
        }

        [Test]
        public void NotEqual6()
        {
            Assert.AreNotEqual(c1.Image, p1.Image);
        }

        [Test]
        public void Equal1()
        {
            Assert.AreEqual(c1.Image, c2.Image);
        }

        [Test]
        public void Equal2()
        {
            Assert.AreEqual(p1.Image, p2.Image);
        }

        [Test]
        public void Equal3()
        {
            Assert.AreEqual(f1.Image, f2.Image);
        }

        [Test]
        public void Equal4()
        {
            Assert.AreEqual(a1.Image, a2.Image);
        }


        #endregion Methods
    }
}