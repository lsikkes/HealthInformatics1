// <copyright file="CharacterFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Windows.Controls;

    /// <summary>
    /// Class CharacterFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class CharacterFactory : Factory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterFactory"/> class.
        /// </summary>
        public CharacterFactory()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the character.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="charID">The character identifier.</param>
        /// <param name="emoteID">The emote identifier.</param>
        /// <returns>Character.</returns>
        public Character CreateCharacter(int x, int y, int charID, int emoteID)
        {
            Character character = new Character(0, 0, 0, 1, "character");
            character.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            character.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            character.Margin = this.SetMargin(character.Margin, x, y);

            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            panel.Margin = this.SetMargin(panel.Margin, 0, 0);

            string imgPath = "image_character_" + charID.ToString() + ".PNG";
            Image charImage = this.GetImage(imgPath, 60, 60);

            panel.Children.Add(charImage);
            character.Children.Add(panel);

            imgPath = "character_emoji_" + emoteID.ToString() + ".PNG";
            Image charEmotionImage = this.GetImage(imgPath, 25, 25, 45, -105);
            character.Children.Add(charEmotionImage);

            return character;
        }

        #endregion Methods
    }
}