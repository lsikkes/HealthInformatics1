// <copyright file="Tree.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Surroundings
{
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Class Tree.
    /// </summary>
    /// <seealso cref="Visualizer.Surroundings.Surrounding" />
    public class Tree : Surrounding
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
        private Color treeColor = Colors.Green;

        #endregion Fields

        #region Constructors

        public Tree(int x, int y, int rotation, int id, string name, int w, int h, int mx, int my)
            : base(x, y, rotation, id, name)
        {
            this.w = w;
            this.h = h;
            this.x = mx;
            this.y = my;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Makes a rectangle for a tree object.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public override Rectangle GetRect()
        {
            Rectangle rect = MakeRect(this.x, this.y, this.w, this.h);
            rect.Fill = new SolidColorBrush(this.treeColor);
            return rect;
        }

        #endregion Methods
    }
}