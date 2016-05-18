// <copyright file="TVScreenTest.cs" company="HI1">
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
    using Visualizer.Tv;

    /// <summary>
    /// Class TVScreenTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class TVScreenTest
    {
        #region Methods

        /// <summary>
        /// Creates the TV Screen test.
        /// </summary>
        [Test]
        public void CreateTVSCreenTest()
        {
            TVScreen tv = new TVScreen(0, 0, 0, 0, "TV Screen");
            Assert.IsNotNull(tv);
        }

        #endregion Methods
    }
}