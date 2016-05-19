// <copyright file="CarTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System.Threading;
    using Visualizer;
    using Visualizer.Cars;

    /// <summary>
    /// Class CarTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class CarTest
    {
        #region Methods

        /// <summary>
        /// Create the police car test.
        /// </summary>
        [Test]
        public void CreatePoliceCarTest()
        {
            Car car = new PoliceCar();
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the normal car test.
        /// </summary>
        [Test]
        public void CreateNormalCarTest()
        {
            Car car = new NormalCar();
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the ambulance car test.
        /// </summary>
        [Test]
        public void CreateAmbulanceCarTest()
        {
            Car car = new AmbulanceCar();
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the firefighter car test.
        /// </summary>
        [Test]
        public void CreateFirefighterCarTest()
        {
            Car car = new FirefighterCar();
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Gets the firefighter car resource test.
        /// </summary>
        [Test]
        public void GetFirefighterCarResourceTest()
        {
            Car car = new FirefighterCar();
            string actualString = car.GetCarImageResource();
            string shouldBeString = "image_police_car.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the firefighter car icon resource test.
        /// </summary>
        [Test]
        public void GetFirefighterCarIconResourceTest()
        {
            Car car = new FirefighterCar();
            string actualString = car.GetIconImageResource();
            string shouldBeString = "icon_police.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the ambulance car resource test.
        /// </summary>
        [Test]
        public void GetAmbulanceCarResourceTest()
        {
            Car car = new AmbulanceCar();
            string actualString = car.GetCarImageResource();
            string shouldBeString = "image_police_car.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the ambulance car icon resource test.
        /// </summary>
        [Test]
        public void GetAmbulanceCarIconResourceTest()
        {
            Car car = new AmbulanceCar();
            string actualString = car.GetIconImageResource();
            string shouldBeString = "icon_police.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the normal car resource test.
        /// </summary>
        [Test]
        public void GetNormalCarResourceTest()
        {
            Car car = new NormalCar();
            string actualString = car.GetCarImageResource();
            string shouldBeString = "image_police_car.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the normal car icon resource test.
        /// </summary>
        [Test]
        public void GetNormalCarIconResourceTest()
        {
            Car car = new NormalCar();
            string actualString = car.GetIconImageResource();
            string shouldBeString = "icon_police.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the police car resource test.
        /// </summary>
        [Test]
        public void GetPoliceCarResourceTest()
        {
            Car car = new PoliceCar();
            string actualString = car.GetCarImageResource();
            string shouldBeString = "image_police_car.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the police car icon resource test.
        /// </summary>
        [Test]
        public void GetPoliceCarIconResourceTest()
        {
            Car car = new PoliceCar();
            string actualString = car.GetIconImageResource();
            string shouldBeString = "icon_police.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        #endregion Methods
    }
}