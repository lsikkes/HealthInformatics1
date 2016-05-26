// <copyright file="Seat.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Class Seat.
    /// </summary>
    /// <seealso cref="Visualizer.Furniture.Bench" />
    public class Seat : Bench
    {
        #region Constructors

        /// <summary>
        /// Constructor of class Seat
        /// </summary>
        /// <param name="x"> x position </param>
        /// <param name="y"> y position </param>
        /// <param name="rotation"> rotation position </param>
        /// <param name="id"> id of the object</param>
        /// <param name="name">name of the object</param>
        public Seat(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>Image.</returns>
        public Image GetImage()
        {
            Image seatImg = new Image();
            seatImg.Width = 50;
            seatImg.Height = 50;
            string location = Visualizer.MainWindow.getPath() + "icon_chair.PNG";
            ImageSource seatImgSource = new BitmapImage(new Uri(location));
            seatImg.Source = seatImgSource;
            return seatImg;
        }

        /// <summary>
        /// Creates the seat image.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>Image.</returns>
        public Image CreateSeatImage(int x, int y)
        {
            Image seatImg = this.GetImage();

            seatImg.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            seatImg.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            Thickness margin = seatImg.Margin;
            margin.Left = x;
            margin.Top = y;
            seatImg.Margin = margin;
            return seatImg;
        }

        #endregion Methods
    }
}