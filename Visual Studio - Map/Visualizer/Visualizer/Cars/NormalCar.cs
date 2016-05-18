// <copyright file="NormalCar.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Cars
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Class NormalCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class NormalCar : Car
    {
        #region Constructors

        public NormalCar(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image GetCarImage()
        {
            Image carImage = GetImage("image_police_car", 125, 250);
            return carImage;
        }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image GetIconImage()
        {
            Image carIcon = GetImage("icon_police", 50, 50, 0, -300);
            return carIcon;
        }

        #endregion Methods
    }
}