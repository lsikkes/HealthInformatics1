// <copyright file="SeatModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>SeatModel class</summary>
// ***********************************************************************
namespace Visualizer.Models.Furniture
{
    using Utilities;

    /// <summary>
    /// Class SeatModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class SeatModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SeatModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public SeatModel(VRPosition pos, int id)
            : base(pos, id)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets if the seat is occupied.
        /// </summary>
        /// <value><c>true</c> if [is occupied]; otherwise, <c>false</c>.</value>
        public bool IsOccupied { get; set; }

        #endregion Properties
    }
}