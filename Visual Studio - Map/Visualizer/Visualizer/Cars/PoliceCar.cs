// <copyright file="PoliceCar.cs" company="HI1">
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
    /// Class PoliceCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class PoliceCar : Car
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliceCar"/> class.
        /// </summary>
        public PoliceCar()
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
            string carImage = ImageEnum.PoliceCar.ToString();
            this.logger.Info("Creating car image resource for Police");
            return carImage;
        }

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetIconImageResource()
        {
            string carIcon = ImageEnum.PoliceCarIcon.ToString();
            this.logger.Info("Creating car icon image resource for Police");
            return carIcon;
        }

        #endregion Methods
    }
}