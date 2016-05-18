// <copyright file="SurroundingTest.cs" company="HI1">
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
    using Visualizer.Surroundings;

    /// <summary>
    /// Class SurroundingTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class SurroundingTest
    {
        #region Methods

        /// <summary>
        /// Creates the wall test.
        /// </summary>
        [Test]
        public void CreateWallTest()
        {
            Surrounding wall = new Wall(5, 5, 5, 5);
            Assert.IsNotNull(wall);
        }

        /// <summary>
        /// Creates the tree test.
        /// </summary>
        [Test]
        public void CreateTreeTest()
        {
            Surrounding tree = new Tree(5, 5, 5, 5);
            Assert.IsNotNull(tree);
        }

        #endregion Methods
    }
}