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
            ImageMap.LoadImages();
            Assert.NotNull(ImageMap.GetImage(ImageEnum.PoliceCar.ToString()));
        }

        [Test]
        public void GetImageFailTest()
        {
            ImageMap.LoadImages();
            Assert.Throws<FileNotFoundException>(() => ImageMap.GetImage("invalidkey.png"));
        }

        #endregion Methods
    }
}