// <copyright file="CarModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>NormalCar class</summary>
// ***********************************************************************
namespace Visualizer.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Media.Imaging;
    using Utilities;

    /// <summary>
    /// Model for a normal car.
    /// </summary>
    /// <seealso cref="Visualizer.Models.CarModel" />
    public class CarModel : AbstractCarModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CarModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public CarModel(VRPosition pos, int id)
            : base(pos, id)
        {
            this.IconImage = null;
            this.Image = ImageMap.GetImage(ImageEnum.NormalCar.ToString());
        }

        #endregion Constructors
    }
}