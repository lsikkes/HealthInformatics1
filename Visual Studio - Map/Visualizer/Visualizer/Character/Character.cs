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
        /// Constructor of class Character
        /// </summary>
        /// <param name="x"> x position </param>
        /// <param name="y"> y position </param>
        /// <param name="rotation"> rotation position </param>
        /// <param name="id"> id of the object</param>
        /// <param name="name">name of the object</param>
        public Character(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
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