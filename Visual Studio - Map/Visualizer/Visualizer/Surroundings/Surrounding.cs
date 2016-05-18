// <copyright file="Surrounding.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Surroundings
{
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Class Surrounding.
    /// </summary>
    /// <seealso cref="Visualizer.ImmovableObject" />
    public class Surrounding : ImmovableObject
    {
        #region Methods

        /// <summary>
        /// Gets the rectangle.
        /// </summary>
        /// <returns>Rectangle object.</returns>
        public virtual Rectangle GetRect()
        {
            Rectangle rect = new Rectangle();
            return rect;
        }

        /// <summary>
        /// Makes the rectangle for the surrounding.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="w">The width.</param>
        /// <param name="h">The height.</param>
        /// <returns>Rectangle object.</returns>
        public virtual Rectangle MakeRect(int x, int y, int w, int h)
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Brown);
            rect.Width = w;
            rect.Height = h;

            rect.Margin = this.SetMargin(rect.Margin, x, y);
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            return rect;
        }

        #endregion Methods
    }
}