// <copyright file="Character.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
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
        public Character(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors
    }
}