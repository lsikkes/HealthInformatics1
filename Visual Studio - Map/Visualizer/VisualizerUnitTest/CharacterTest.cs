// <copyright file="CharacterTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System.Threading;
    using Visualizer;
    using Visualizer.Character;

    /// <summary>
    /// Class CharacterTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class CharacterTest
    {
        #region Methods

        /// <summary>
        /// Creates the character test.
        /// </summary>
        [Test]
        public void CreateCharacterTest()
        {
            Character character = new Character();
            Assert.IsNotNull(character);
        }

        /// <summary>
        /// Gets the character resource test.
        /// </summary>
        [Test]
        public void GetCharacterResourceTest()
        {
            Character character = new Character();
            string actualString = character.GetImageResource(0);
            string shouldBeString = ImageEnum.GetCharacter(0);
            Assert.AreEqual(shouldBeString, actualString);
        }

        /// <summary>
        /// Gets the character emotion resource test.
        /// </summary>
        [Test]
        public void GetCharacterEmotionResourceTest()
        {
            Character character = new Character();
            string actualString = character.GetImageEmojiResource(0);
            string shouldBeString = ImageEnum.GetCharacterEmoji(0);
            Assert.AreEqual(shouldBeString, actualString);
        }

        #endregion Methods
    }
}