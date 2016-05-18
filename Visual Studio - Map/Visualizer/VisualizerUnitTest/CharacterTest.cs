// <copyright file="CharacterTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System.Threading;
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
            Character character = new Character(0, 0, 0, 0, "character");
            Assert.IsNotNull(character);
        }

        [Test]
        public void getEmotionTest()
        {
            Character character = new Character(0, 0, 0, 0, "character");
            Assert.AreEqual(CharacterEmotion.Neutral, character.CharEmotion);
            character.EmotionUpdatedTo(5);
            character.EmotionUpdatedTo(8);
            Assert.AreEqual(CharacterEmotion.Happy, character.CharEmotion);
        }

        #endregion Methods
    }
}