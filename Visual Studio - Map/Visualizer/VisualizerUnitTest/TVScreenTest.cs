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

        private TVScreen tv;

        [SetUp]
        public void setUp()
        {
            tv = new TVScreen(0, 0, 0, 0, "TV Screen");
        }

        /// <summary>
        /// Creates the TV Screen test.
        /// </summary>
        [Test]
        public void CreateTVSCreenTest()
        {
            Assert.IsNotNull(tv);
        }

        [Test]
        public void SetTextTest()
        {
            string text = "hello world";
            tv.SetText(text);
            Assert.AreEqual(text, tv.Text);
        }

        [Test]
        public void SetTvOnTestTrue()
        {
            tv.SetTvOn(true);
            Assert.True(tv.IsOn);
        }

        [Test]
        public void SetTvOnTestFalse()
        {
            tv.SetTvOn(false);
            Assert.False(tv.IsOn);
        }

        [Test]
        public void SetShowTextTestTrue()
        {
            tv.SetShowText(true);
            Assert.True(tv.ShowText);
        }

        [Test]
        public void SetShowTextTestFalse()
        {
            tv.SetShowText(false);
            Assert.False(tv.ShowText);
        }

        [Test]
        public void SetMovieTest()
        {
            string movie = "Titanic";
            tv.SetMovie(movie);
            Assert.AreEqual(movie, tv.Movie);
        }

        #endregion Methods
    }
}