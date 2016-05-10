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

namespace Visualizer
{
    /// <summary>
    /// Class Factory.
    /// </summary>
    public class Factory
    {
        #region Methods

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

        #endregion Methods
    }
}