// <copyright file="BenchModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>BenchModel class</summary>
// ***********************************************************************
namespace Visualizer.Models.Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utilities;

    /// <summary>
    /// Class BenchModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class BenchModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public BenchModel(VRPosition pos, int id, int amountSeats)
            : base(pos, id)
        {
            this.NumberOfSeats = amountSeats;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the number of seats.
        /// </summary>
        /// <value>The number of seats.</value>
        public int NumberOfSeats { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds a seat.
        /// </summary>
        public void AddSeat()
        {
            this.NumberOfSeats++;
        }

        /// <summary>
        /// Removes a seat.
        /// </summary>
        public void RemoveSeat()
        {
            if (NumberOfSeats > 0)
            {
                this.NumberOfSeats--;
            }
            else
            {
                Logger.Warning(this, "number of seats cannot go below 0");
            }
        }

        #endregion Methods
    }
}