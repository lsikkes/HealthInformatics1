// <copyright file="Character.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Character
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class Character.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    /// <seealso cref="Visualizer.VRObject" />
    public class Character : MovableObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Character" /> class.
        /// </summary>
        public Character()
        {
        }

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string resource of image</returns>
        public string GetImageResource(int id)
        {
            return ImageEnum.GetCharacter(id);
        }

        /// <summary>
        /// Gets the image emotion resource.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string resource of emotion</returns>
        public string GetImageEmojiResource(int id)
        {
            return ImageEnum.GetCharacterEmoji(id);
        }

        #endregion Constructors
    }
}