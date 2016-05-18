// <copyright file="TVScreen.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Tv
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class TVScreen.
    /// </summary>
    /// <seealso cref="Visualizer.ImmovableObject" />
    public class TVScreen : ImmovableObject
    {
        #region Constructors

        public TVScreen(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets the text on TV.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetTextOnTV(string text)
        {
        }

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <returns>string of TVScreen</returns>
        public string GetImageResource()
        {
            return ImageEnum.TvIcon.ToString();
        }

        #endregion Methods
    }
}