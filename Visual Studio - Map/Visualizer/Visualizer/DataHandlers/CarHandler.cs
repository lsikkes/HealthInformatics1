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