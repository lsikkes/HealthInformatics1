// <copyright file="CarFactoryTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Visualizer;

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
        public void createCarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();
            Assert.IsNotNull(carFactory);
        }

        #endregion Methods
    }
}