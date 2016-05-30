// <copyright file="TvHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>TV handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class TV Handler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class TvHandler : AbstractDataHandler
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TvHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public TvHandler(MainWindow main)
            : base(main)
        {
        }

        #endregion Constructors
    }
}