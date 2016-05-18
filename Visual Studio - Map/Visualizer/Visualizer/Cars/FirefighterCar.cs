// <copyright file="FirefighterCar.cs" company="HI1">
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
    /// Class FirefighterCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class FirefighterCar : Car
    {
        #region Constructors

        public FirefighterCar(int x, int y, int rotation, int id, string name)
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
            Image carImage = GetImage(ImageEnum.FireFighterCar.ToString(), 125, 250);
            return carImage;
        }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image GetIconImage()
        {
            Image carIcon = GetImage(ImageEnum.FireFighterCarIcon.ToString(), 50, 50, 0, -300);
            return carIcon;
        }

        #endregion Methods
    }
}