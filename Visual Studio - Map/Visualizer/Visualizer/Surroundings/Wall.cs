// <copyright file="Wall.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Surroundings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Class Wall.
    /// </summary>
    /// <seealso cref="Visualizer.Surroundings.Surrounding" />
    public class Wall : Surrounding
    {
        #region Fields

        /// <summary>
        /// The width of the tree
        /// </summary>
        private int w,

            /// <summary>
            /// The height of the tree
            /// </summary>
            h,

            /// <summary>
            /// The x coordinate of the tree
            /// </summary>
            x,

            /// <summary>
            /// The y coordinate of the tree
            /// </summary>
            y;

        /// <summary>
        /// The tree color
        /// </summary>
        private Color wallColor = Colors.Brown;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall" /> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="marginX">The margin x.</param>
        /// <param name="marginY">The margin y.</param>
        public Wall(int width, int height, int marginX, int marginY)
        {
            this.w = width;
            this.h = height;
            this.x = marginX;
            this.y = marginY;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Makes a rectangle for a wall object.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public override Rectangle GetRect()
        {
            Rectangle rect = MakeRect(this.x, this.y, this.w, this.h);
            rect.Fill = new SolidColorBrush(this.wallColor);
            return rect;
        }

        #endregion Methods
    }
}