// ***********************************************************************
// <copyright file="AmbulanceCar.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Cars
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Class AmbulanceCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class AmbulanceCar : Car
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbulanceCar"/> class.
        /// </summary>
        public AmbulanceCar()
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
            string carImage = ImageEnum.AmbulanceCar.ToString();
            this.logger.Info("Creating car image resource for Ambulance");
            return carImage;
        }

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetIconImageResource()
        {
            string carIcon = ImageEnum.AmbulanceCarIcon.ToString();
            this.logger.Info("Creating car image icon resource for Ambulance");
            return carIcon;
        }

        #endregion Methods
    }
}