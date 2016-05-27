// <copyright file="SurroundingModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>SurroundingModel class</summary>
// ***********************************************************************
namespace Visualizer.Models
{
    using Utilities;

    /// <summary>
    /// Class SurroundingModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class SurroundingModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SurroundingModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public SurroundingModel(VRPosition pos, int id)
            : base(pos, id)
        {
        }

        #endregion Constructors
    }
}