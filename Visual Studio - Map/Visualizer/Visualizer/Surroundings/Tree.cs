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

        /// <summary>
        /// Constructor of Tree
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        /// <param name="w"> width of tree</param>
        /// <param name="h"> height of tree</param>
        /// <param name="mx"> margin x of tree</param>
        /// <param name="my"> margin y of tree</param>
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
        /// <returns>Rectangle object.</returns>
        public override Rectangle GetRect()
        {
            Rectangle rect = MakeRect(this.x, this.y, this.w, this.h);
            rect.Fill = new SolidColorBrush(this.treeColor);
            return rect;
        }

        #endregion Methods
    }
}