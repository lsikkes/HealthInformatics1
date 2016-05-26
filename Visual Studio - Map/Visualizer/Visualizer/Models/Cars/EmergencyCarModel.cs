// <copyright file="EmergencyCarModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>EmergencyCarModel class</summary>
// ***********************************************************************
namespace Visualizer.Models.Cars
{
    using Utilities;

    /// <summary>
    /// Class EmergencyCarModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.Cars.CarModel" />
    public class EmergencyCarModel : CarModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyCarModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public EmergencyCarModel(VRPosition pos, int id)
            : base(pos, id)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether [siren on].
        /// </summary>
        /// <value><c>true</c> if [siren on]; otherwise, <c>false</c>.</value>
        public bool SirenOn { get; set; }

        #endregion Properties
    }
}