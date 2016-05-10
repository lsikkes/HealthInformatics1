using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Visualizer.Cars
{
    class FirefighterCar : Car
    {
        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image getCarImage()
        {
            Image carImage = new Image();
            carImage.Width = 125;
            carImage.Height = 250;
            String pathName = GeenNaam.MainWindow.AbsolutePath + "image_police_car.PNG";
            ImageSource carImgSource = new BitmapImage(new Uri(pathName));
            carImage.Source = carImgSource;
            return carImage;
        }

        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public override Image getIconImage()
        {
            Image carIcon = new Image();
            carIcon.Width = 50;
            carIcon.Height = 50;
            String pathName = GeenNaam.MainWindow.AbsolutePath + "icon_police.PNG";
            ImageSource carIconImgSource = new BitmapImage(new Uri(pathName));
            carIcon.Source = carIconImgSource;
            Thickness margin = carIcon.Margin;
            margin.Left = 0;
            margin.Top = -300;
            carIcon.Margin = margin;

            return carIcon;
        }
    }
}
