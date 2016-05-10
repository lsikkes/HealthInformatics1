using System;
using System.Windows.Controls;

namespace Visualizer
{
    /// <summary>
    /// Class CharacterFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    internal class CharacterFactory : Factory
    {
        #region Methods

        /// <summary>
        /// Creates the character.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="charID">The character identifier.</param>
        /// <param name="emoteID">The emote identifier.</param>
        /// <returns>Character.</returns>
        public Character createCharacter(int x, int y, int charID, int emoteID)
        {
            Character character = new Character();
            character.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            character.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            character.Margin = setMargin(character.Margin, x, y);

            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            panel.Margin = setMargin(panel.Margin, 0, 0);

            String imgPath = "image_character_" + charID.ToString() + ".PNG";
            Image charImage = getImage(imgPath, 60, 60);

            panel.Children.Add(charImage);
            character.Children.Add(panel);

            imgPath = "character_emoji_" + emoteID.ToString() + ".PNG";
            Image charEmotionImage = getImage(imgPath, 25, 25, 45, -105);
            character.Children.Add(charEmotionImage);

            return character;
        }

        #endregion Methods
    }
}