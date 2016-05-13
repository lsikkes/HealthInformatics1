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