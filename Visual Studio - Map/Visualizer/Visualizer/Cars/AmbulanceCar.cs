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
    using Visualizer.Utilities;


    /// <summary>
    /// Class AmbulanceCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class AmbulanceCar : Car
    {
        #region Fields

        /// <summary>
        /// Instance of the logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor of class Ambulance car
        /// </summary>
        /// <param name="x"> x position </param>
        /// <param name="y"> y position </param>
        /// <param name="rotation"> rotation position </param>
        /// <param name="id"> id of the object</param>
        /// <param name="name">name of the object</param>
        public AmbulanceCar(int x, int y, int rotation, int id, string name)
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