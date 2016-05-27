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
    using Visualizer.Utilities;

    [TestFixture]
    public class ImageEnumTest
    {
        #region Methods

        /// <summary>
        /// Gets the image test.
        /// </summary>
        [Test]
        public void GetImageTest()
        {
            ImageMap.LoadImages();
            Assert.NotNull(ImageMap.GetImage(ImageEnum.PoliceCar.ToString()));
        }

        /// <summary>
        /// Gets the image fail test.
        /// </summary>
        [Test]
        public void GetImageFailTest()
        {
            ImageMap.LoadImages();
            Assert.Throws<FileNotFoundException>(() => ImageMap.GetImage("invalidkey.png"));
        }

        /// <summary>
        /// Gets the character test.
        /// </summary>
        [Test]
        public void GetCharacterTest()
        {
            Assert.NotNull(ImageEnum.GetCharacter(0));
        }

        /// <summary>
        /// Gets the character emotion test.
        /// </summary>
        [Test]
        public void GetCharacterEmojiTest()
        {
            Assert.NotNull(ImageEnum.GetCharacterEmotion(0));
        }

        /// <summary>
        /// Gets the character emotion string test.
        /// </summary>
        [Test]
        public void GetCharacterEmojiStringTest()
        {
            string actualString = ImageEnum.GetCharacterEmotion(0);
            string shouldBeString = "character_emoji_0.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the character string test.
        /// </summary>
        [Test]
        public void GetCharacterStringTest()
        {
            string actualString = ImageEnum.GetCharacter(0);
            string shouldBeString = "image_character_0.png";
            Assert.AreEqual(shouldBeString, actualString);
        }

        #endregion Methods
    }
}