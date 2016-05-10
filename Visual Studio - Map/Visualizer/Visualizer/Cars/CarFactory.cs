using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using Visualizer.Cars;

namespace Visualizer
{
    class CarFactory : Factory
    {
        /// <summary>
        /// Creates the car.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns>Car.</returns>
        public Car createCar(String type, int x, int y, int rotation)
        {
            Car car;
            switch (type)
            {
                case "police":
                     car = new PoliceCar();
                     break;
                case "normal":
                     car = new NormalCar();
                     break;
                case "fire":
                     car = new FirefighterCar();
                     break;
                case "ambulance":
                     car = new AmbulanceCar();
                     break;
                default:
                     car = null;
                     break;
            }
            if (car == null) { throw new Exception("carType not specified correctly"); }
            Image carImage = car.getCarImage();
            Image carIconImage = car.getIconImage();
            car.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            car.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            car.Margin = setMargin(car.Margin, x, y);
            car.Children.Add(carImage);
            car.Children.Add(carIconImage);
            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            car.RenderTransform = rotateTransform1;

            return car;
        }
    }
}
