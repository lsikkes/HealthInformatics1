// <copyright file="FirefighterCar.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Cars
{
    using Visualizer.Utilities;
    using Visualizer.Log;

    /// <summary>
    /// Class FirefighterCar.
    /// </summary>
    /// <seealso cref="Visualizer.Car" />
    public class FirefighterCar : Car
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor of FireFighterCar
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public FirefighterCar(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the icon image resource.
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetIconImageResource()
        {
            string carIcon = ImageEnum.FireFighterCarIcon.ToString();
            this.logger.Info("Creating car icon image resource for FireFighter");
            return carIcon;
        }

        /// <summary>
        /// Gets the recourse image
        /// </summary>
        /// <returns>Image string.</returns>
        public override string GetCarImageResource()
        {
            string carImage = ImageEnum.FireFighterCar.ToString();
            this.logger.Info("Creating car image resource for FireFighter");
            return carImage;
        }

        #endregion Methods
    }
}