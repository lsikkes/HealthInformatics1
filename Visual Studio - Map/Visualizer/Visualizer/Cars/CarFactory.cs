// <copyright file="CarFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;
    using Visualizer.Cars;

    /// <summary>
    /// Class CarFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class CarFactory : Factory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFactory"/> class.
        /// </summary>
        public CarFactory()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the car.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns>Car.</returns>
        /// <exception cref="System.NullReferenceException">carType not specified correctly</exception>
        /// <exception cref="System.Exception">carType not specified correctly</exception>
        public Car CreateCar(int type, int x, int y, int rotation)
        {
            Car car;
            switch (type)
            {
                case 0:
                    car = new PoliceCar();
                    break;

                case 1:
                    car = new NormalCar();
                    break;

                case 2:
                    car = new FirefighterCar();
                    break;

                case 3:
                    car = new AmbulanceCar();
                    break;

                default:
                    car = null;
                    break;
            }

            if (car == null)
            {
                throw new NullReferenceException("carType not specified correctly");
            }

            Image carImage = car.GetCarImage();
            Image carIconImage = car.GetIconImage();
            car.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            car.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            car.Margin = this.SetMargin(car.Margin, x, y);
            car.Children.Add(carImage);
            car.Children.Add(carIconImage);
            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            car.RenderTransform = rotateTransform1;

            return car;
        }

        #endregion Methods
    }
}