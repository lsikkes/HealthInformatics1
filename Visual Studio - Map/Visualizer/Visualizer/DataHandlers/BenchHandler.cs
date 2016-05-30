// <copyright file="BenchHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>bench handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class BenchHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class BenchHandler : AbstractDataHandler
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public BenchHandler(MainWindow main)
            : base(main)
        {
        }

        #endregion Constructors
    }
}