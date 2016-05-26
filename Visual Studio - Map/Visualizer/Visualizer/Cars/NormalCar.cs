﻿// <copyright file="NormalCar.cs" company="HI1">
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
    using Visualizer.Utilities;

    /// <summary>
    /// Class NormalCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class NormalCar : Car
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor of NormalCar
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public NormalCar(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the car image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetCarImageResource()
        {
            string carImage = ImageEnum.NormalCar.ToString();
            this.logger.Info("Creating car image resource for NormalCar");
            return carImage;
        }

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetIconImageResource()
        {
            string carIcon = ImageEnum.NormalCarIcon.ToString();
            this.logger.Info("Creating car icon image resource for NormalCar");
            return carIcon;
        }

        #endregion Methods
    }
}