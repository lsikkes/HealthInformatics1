// <copyright file="Car.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Cars
{
    using System;
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Class Car.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    public class Car : MovableObject
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car" /> class.
        /// </summary>
        public Car()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the car image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public virtual string GetCarImageResource()
        {
            this.logger.Warning("GetCarImageResource called in Car class, should not happen");
            return null;
        }

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public virtual string GetIconImageResource()
        {
            this.logger.Warning("GetIconImageResource called in Car class, should not happen");
            return null;
        }

        #endregion Methods
    }
}