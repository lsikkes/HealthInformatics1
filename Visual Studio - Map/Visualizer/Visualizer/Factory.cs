// <copyright file="Factory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using Visualizer.Utilities;

    /// <summary>
    /// Class Factory.
    /// </summary>
    public class Factory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        public Factory()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets the margin.
        /// </summary>
        /// <param name="margin">The margin.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>Thickness of the margin.</returns>
        public Thickness SetMargin(Thickness margin, int x, int y)
        {
            margin.Left = x;
            margin.Top = y;
            return margin;
        }

        /// <summary>
        /// Gets the image of any string.
        /// </summary>
        /// <param name="key">The name of image.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>image object.</returns>
        public Image GetImage(string key, int width, int height)
        {
            Image image = new Image();
            image.Width = width;
            image.Height = height;

            ImageSource imageSource = ImageMap.GetImage(key);
            image.Source = imageSource;

            return image;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>Image object.</returns>
        public Image GetImage(string path, int width, int height, int x, int y)
        {
            Image image = this.GetImage(path, width, height);
            image.Margin = this.SetMargin(image.Margin, x, y);
            return image;
        }

        #endregion Methods
    }
}