// <copyright file="SurroundingHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>surrounding handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class SurroundingHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class SurroundingHandler : AbstractDataHandler
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SurroundingHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public SurroundingHandler(MainWindow main)
            : base(main)
        {
        }

        #endregion Constructors
    }
}