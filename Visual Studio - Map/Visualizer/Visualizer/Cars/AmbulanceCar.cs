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
        #region Methods

        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed.")]

        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns> Image. </returns>
        public override Image GetCarImage()
        {
            Image carImage = GetImage(ImageEnum.AmbulanceCar.ToString(), 125, 250);
            return carImage;
        }

        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed.")]

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns> Image. </returns>
        public override Image GetIconImage()
        {
            Image carIcon = GetImage(ImageEnum.AmbulanceCarIcon.ToString(), 50, 50, 0, -300);
            return carIcon;
        }

        #endregion Methods
    }
}