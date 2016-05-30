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

        /// <summary>
        /// Creates the object.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void CreateObject()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets the factory.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void SetFactory()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Update(int id, object message)
        {
            throw new System.NotImplementedException();
        }

        #endregion Constructors
    }
}