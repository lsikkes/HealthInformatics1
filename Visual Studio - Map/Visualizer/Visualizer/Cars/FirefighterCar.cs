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
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FirefighterCar"/> class.
        /// </summary>
        public FirefighterCar()
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
            string carImage = ImageEnum.FireFighterCar.ToString();
            this.logger.Info("Creating car image resource for FireFighter");
            return carImage;
        }

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetIconImageResource()
        {
            string carIcon = ImageEnum.FireFighterCarIcon.ToString();
            this.logger.Info("Creating car icon image resource for FireFighter");
            return carIcon;
        }

        #endregion Methods
    }
}