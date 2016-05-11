using System.Windows;
using System.Windows.Shapes;

namespace Visualizer.Surroundings
{
    /// <summary>
    /// Class Surrounding.
    /// </summary>
    public class Surrounding : ImmovableObject
    {
        #region Methods

        /// <summary>
        /// Gets the rectangle.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public virtual Rectangle getRect()
        {
            Rectangle rect = new Rectangle();
            return rect;
        }

        /// <summary>
        /// Makes the rectangle.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public virtual Rectangle makeRect()
        {
            Rectangle rect = new Rectangle();
            return rect;
        }

        /// <summary>
        /// Sets the margin.
        /// </summary>
        /// <param name="margin">The margin.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>Thickness.</returns>
        public Thickness setMargin(Thickness margin, int x, int y)
        {
            margin.Left = x;
            margin.Top = y;
            return margin;
        }

        #endregion Methods
    }
}