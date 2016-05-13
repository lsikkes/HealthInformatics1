﻿// <copyright file="FirefighterCar.cs" company="HI1">
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
        #region Methods

        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image GetCarImage()
        {
            Image carImage = GetImage("image_police_car.PNG", 125, 250);
            return carImage;
        }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image GetIconImage()
        {
            Image carIcon = GetImage("icon_police.PNG", 50, 50, 0, -300);
            return carIcon;
        }

        #endregion Methods
    }
}