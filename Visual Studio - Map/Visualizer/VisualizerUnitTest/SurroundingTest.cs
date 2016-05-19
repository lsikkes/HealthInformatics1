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
    using System.Windows.Shapes;
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
            Rectangle wallRectange = wall.GetRect();
            double actualWidth = wallRectange.Width;
            double actualHeight = wallRectange.Height;
            double actualX = wallRectange.Margin.Left;
            double actualY = wallRectange.Margin.Top;

            double expectedWidth = 5;
            double expectedHeight = 5;
            double expectedX = 5;
            double expectedY = 5;

            Assert.AreEqual(expectedHeight, actualHeight);
            Assert.AreEqual(expectedWidth, actualWidth);
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        /// <summary>
        /// Creates the tree test.
        /// </summary>
        [Test]
        public void CreateTreeTest()
        {
            Surrounding tree = new Tree(5, 5, 5, 5);
            Rectangle treeRectange = tree.GetRect();
            double actualWidth = treeRectange.Width;
            double actualHeight = treeRectange.Height;
            double actualX = treeRectange.Margin.Left;
            double actualY = treeRectange.Margin.Top;

            double expectedWidth = 5;
            double expectedHeight = 5;
            double expectedX = 5;
            double expectedY = 5;

            Assert.AreEqual(expectedHeight, actualHeight);
            Assert.AreEqual(expectedWidth, actualWidth);
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion Methods
    }
}