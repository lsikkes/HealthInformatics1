using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class ImageEnumTest
    {
        #region Methods

        [Test]
        public void GetImageTest()
        {
            ImageMap.loadImages();
            Assert.NotNull(ImageMap.getImage(ImageEnum.PoliceCar.ToString()));
        }

        #endregion Methods
    }
}