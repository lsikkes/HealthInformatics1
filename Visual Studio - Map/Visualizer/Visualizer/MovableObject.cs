// <copyright file="MovableObject.cs" company="HI1">
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
    using System.Windows;

    /// <summary>
    /// Class MovableObject.
    /// </summary>
    /// <seealso cref="Visualizer.VRObject" />
    public class MovableObject : VRObject
    {
        #region Methods

        /// <summary>
        /// Constructor of MovableObject
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public MovableObject(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        /// <summary>
        /// Moves to.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void MoveTo(int x, int y)
        {
            Thickness margin = this.Margin;
            margin.Left = x;
            margin.Top = y;
            this.Margin = margin;
        }

        /// <summary>
        /// Walks the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void Walk(int x, int y)
        {
            Thickness margin = this.Margin;
            margin.Left += x;
            margin.Top += y;
            this.Margin = margin;
        }

        #endregion Methods
    }
}