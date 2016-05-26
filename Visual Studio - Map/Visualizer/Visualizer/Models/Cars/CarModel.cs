// <copyright file="CarModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Car Model class</summary>
// ***********************************************************************
namespace Visualizer.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utilities;

    /// <summary>
    /// Class CarModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class CarModel : AbstractVRObject
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
        }

        #endregion Constructors
    }
}