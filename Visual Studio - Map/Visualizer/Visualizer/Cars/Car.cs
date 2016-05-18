// <copyright file="Car.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Class Car.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    public class Car : MovableObject
    {
        #region Fields

        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car" /> class.
        /// </summary>
        public Car()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the car image.
        /// should not be called
        /// </summary>
        /// <returns> Image of the car </returns>
        public virtual Image GetCarImage()
        {
            logger.Warning("GetCarImage called while it should not be called");
            return null;
        }

        /// <summary>
        /// Gets the icon image.
        /// should not be called
        /// </summary>
        /// <returns> Icon of the car </returns>
        public virtual Image GetIconImage()
        {
            logger.Warning("GetIconImage called while it should not be called");
            return null;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns> Image of from the requested path </returns>
        public Image GetImage(string key, int width, int height)
        {
            Image carImage = new Image();
            carImage.Source = ImageMap.getImage(key);
            carImage.Width = width;
            carImage.Height = height;
            return carImage;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns> Image. </returns>
        public Image GetImage(string path, int width, int height, int x, int y)
        {
            Image carImage = this.GetImage(path, width, height);
            carImage.Margin = this.SetMargin(carImage.Margin, x, y);
            return carImage;
        }

        /// <summary>
        /// Sets the margin.
        /// </summary>
        /// <param name="margin">The margin.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns> Thickness. </returns>
        public Thickness SetMargin(Thickness margin, int x, int y)
        {
            margin.Left = x;
            margin.Top = y;
            return margin;
        }

        #endregion Methods
    }
}