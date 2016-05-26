// <copyright file="PatientModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PatientModel class</summary>
// ***********************************************************************
namespace Visualizer.Models
{
    using Visualizer.Utilities;

    /// <summary>
    /// Class PatientModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractMovableObject" />
    public class PatientModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public PatientModel(VRPosition pos, int id)
            : base(pos, id)
        {
        }

        #endregion Constructors
    }
}