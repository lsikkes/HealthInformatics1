// <copyright file="CarFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Cars
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;
    using Visualizer.Cars;
    using Visualizer.Log;

    /// <summary>
    /// Class CarFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factories" />
    public class CarFactory : Factory
    {
        #region Fields

        /// <summary>
        /// The image width
        /// </summary>
        private int imageWidth = 125;

        /// <summary>
        /// The image height
        /// </summary>
        private int imageHeight = 250;

        /// <summary>
        /// The image icon width
        /// </summary>
        private int imageIconWidth = 50;

        /// <summary>
        /// The image icon height
        /// </summary>
        private int imageIconHeight = 50;

        /// <summary>
        /// The image icon x
        /// </summary>
        private int imageIconX = 0;

        /// <summary>
        /// The image icon y
        /// </summary>
        private int imageIconY = -300;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFactory"/> class.
        /// </summary>
        public CarFactory()
        {
            Logger.GetInstance().Info("CarFactory created");
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the car.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns>Car object.</returns>
        /// <exception cref="System.NullReferenceException">carType not specified correctly</exception>
        public Car CreateCar(int type, int x, int y, int rotation)
        {
            Car car;

            switch (type)
            {
                case 0:
                    car = new PoliceCar(0, 0, 0, 0, "PoliceCar");
                    break;

                case 1:
                    car = new NormalCar(0, 0, 0, 0, "NormalCar");
                    break;

                case 2:
                    car = new FirefighterCar(0, 0, 0, 0, "FireFighterCar");
                    break;

                case 3:
                    car = new AmbulanceCar(0, 0, 0, 0, "AmbulanceCar");
                    break;

                default:
                    car = null;
                    break;
            }

            if (car == null)
            {
                throw new NullReferenceException("carType not specified correctly");
            }

            string imageKey = car.GetCarImageResource();
            string imageIconKey = car.GetIconImageResource();
            Image carImage = this.GetImage(imageKey, this.imageWidth, this.imageHeight);
            Image carIconImage = this.GetImage(imageIconKey, this.imageIconWidth, this.imageIconHeight, this.imageIconX, this.imageIconY);
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