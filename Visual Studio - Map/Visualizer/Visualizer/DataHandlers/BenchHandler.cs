// <copyright file="BenchHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>bench handler class</summary>
// ***********************************************************************
using Visualizer.Factories;

namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class BenchHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class BenchHandler : AbstractDataHandler
    {
        #region Fields

        private BenchFactory factory;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public BenchHandler(MainWindow main)
            : base(main)
        {
            this.SetFactory();
        }

        /// <summary>
        /// Sets the factory.
        /// </summary>
        public override void SetFactory()
        {
            this.factory = new BenchFactory();
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