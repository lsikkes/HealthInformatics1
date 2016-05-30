// <copyright file="PatientHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>patient handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class PatientHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class PatientHandler : AbstractDataHandler
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public PatientHandler(MainWindow main)
            : base(main)
        {
        }

        #endregion Constructors
    }
}