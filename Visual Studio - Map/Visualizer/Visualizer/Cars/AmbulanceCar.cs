using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Visualizer.Cars
{
    public class AmbulanceCar : Car
    {
        #region Methods

        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image getCarImage()
        {
            Image carImage = getImage("image_police_car.PNG", 125, 250);
            return carImage;
        }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image getIconImage()
        {
            Image carIcon = getImage("icon_police.PNG", 50, 50, 0, -300);
            return carIcon;
        }

        #endregion Methods
    }
}