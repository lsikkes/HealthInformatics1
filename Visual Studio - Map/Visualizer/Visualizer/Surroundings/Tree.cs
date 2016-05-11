using System.Windows.Media;
using System.Windows.Shapes;

namespace Visualizer.Surroundings
{
    /// <summary>
    /// Class Tree.
    /// </summary>
    /// <seealso cref="Visualizer.Surroundings.Surrounding" />
    public class Tree : Surrounding
    {
        #region Fields

        private int w, h, x, y;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Tree"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="marginX">The margin x.</param>
        /// <param name="marginY">The margin y.</param>
        public Tree(int width, int height, int marginX, int marginY)
        {
            this.w = width;
            this.h = height;
            this.x = marginX;
            this.y = marginY;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Makes the rectangle.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public override Rectangle makeRect()
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Green);
            rect.Width = this.w;
            rect.Height = this.h;

            rect.Margin = setMargin(rect.Margin, x, y);
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            return rect;
        }

        /// <summary>
        /// Gets the rectangle.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public override Rectangle getRect()
        {
            return makeRect();
        }

        #endregion Methods
    }
}