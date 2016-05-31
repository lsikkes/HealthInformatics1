// <copyright file="CarFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>CarFactory</summary>
// ***********************************************************************

namespace Visualizer.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Log;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;
    using Visualizer.ViewModels;
    using Visualizer.Views;

    /// <summary>
    /// CarFactory Class
    /// </summary>
    public class CarFactory
    {
        #region fields

        /// <summary>
        /// The logger
        /// </summary>
        private static Logger logger;

        #endregion fields

        #region constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CarFactory"/> class.
        /// </summary>
        public CarFactory(){
            logger = Logger.GetInstance();
        }

        #endregion constructor

        #region Methods
        /// <summary>
        /// Creates the car.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="r">The r.</param>
        /// <param name="main">The main.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public AbstractCarViewModel CreateCar(int x, int y, int r, MainWindow main, int id, int type)
        {
            AbstractCarViewModel car = null;
            switch (type)
            {
                case (int) CarEnum.Normal:
                    car = new NormalCarViewModel(new VRPosition(x, y, r), id);
                    break;
                case (int) CarEnum.Police:
                    car = new PoliceCarViewModel(new VRPosition(x, y, r), id);
                    break;
                case (int) CarEnum.Ambulance:
                    car = new AmbulanceCarViewModel(new VRPosition(x, y, r), id);
                    break;
                case (int) CarEnum.Firetruck:
                    car = new FiretruckCarViewModel(new VRPosition(x, y, r), id);
                    break;
                default:
                    logger.Error("Unknown Car Type: " + type);
                    break;
            }
            
            CarView view = new CarView();
            view.DataContext = car;
            main.AddControl(view);
            return car;
        }

        #endregion Methods
    }
}
