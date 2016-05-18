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
            Car car = new PoliceCar(0, 0, 0, 0, "police");
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the normal car test.
        /// </summary>
        [Test]
        public void CreateNormalCarTest()
        {
            Car car = new NormalCar(0, 0, 0, 0, "normal");
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the ambulance car test.
        /// </summary>
        [Test]
        public void CreateAmbulanceCarTest()
        {
            Car car = new AmbulanceCar(0, 0, 0, 0, "ambulance");
            Assert.IsNotNull(car);
        }

        /// <summary>
        /// Create the firefighter car test.
        /// </summary>
        [Test]
        public void CreateFirefighterCarTest()
        {
            Car car = new FirefighterCar(0, 0, 0, 0, "fireFighter");
            Assert.IsNotNull(car);
        }

        #endregion Methods
    }
}