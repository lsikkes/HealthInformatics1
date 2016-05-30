// <copyright file="CarHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>car handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class CarHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class CarHandler : AbstractDataHandler
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CarHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public CarHandler(MainWindow main)
            : base(main)
        {
        }

        #endregion Constructors
    }
}