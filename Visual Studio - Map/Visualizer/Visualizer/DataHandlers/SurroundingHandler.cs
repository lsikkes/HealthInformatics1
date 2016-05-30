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