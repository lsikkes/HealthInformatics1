using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Visualizer
{
    public class Car : MovableObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        public Car() { }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public virtual Image getCarImage() { return null; }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public virtual Image getIconImage() { return null; }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>Image.</returns>
        public Image getImage(String path, int width, int height)
        {
            Image Mole = new Image();
            Mole.Width = width;
            Mole.Height = height;

            String ImgNameMole = GeenNaam.MainWindow.AbsolutePath + path;

            ImageSource MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;

            return Mole;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>Image.</returns>
        public Image getImage(String path, int width, int height, int x, int y)
        {
            Image Mole = getImage(path, width, height);
            Mole.Margin = setMargin(Mole.Margin, x, y);
            return Mole;
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