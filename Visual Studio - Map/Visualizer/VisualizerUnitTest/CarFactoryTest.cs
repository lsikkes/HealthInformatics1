// <copyright file="CarFactoryTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using Visualizer.Cars;

    /// <summary>
    /// Class CarFactoryTest.
    /// </summary>
    [TestFixture]
    public class CarFactoryTest
    {
        #region Methods

        /// <summary>
        /// Creates the car factory test.
        /// </summary>
        [Test]
        public void CreateCarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();
            Assert.IsNotNull(carFactory);
        }

        #endregion Methods
    }
}