﻿// <copyright file="PoliceCarModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PoliceCar class</summary>
// ***********************************************************************

namespace Visualizer.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Utilities;

    /// <summary>
    /// Model for a police car.
    /// </summary>
    /// <seealso cref="Visualizer.Models.Cars.AbstractEmergencyCarModel" />
    /// <autogeneratedoc />
    public class PoliceCarModel : AbstractCarModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliceCarModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public PoliceCarModel(VRPosition pos, int id)
            : base(pos, id)
        {
            this.Image = ImageMap.GetImage("image_car_police.png");
        }

        #endregion Constructors
    }
}
