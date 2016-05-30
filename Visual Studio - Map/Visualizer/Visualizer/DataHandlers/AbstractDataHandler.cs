// <copyright file="AbstractDataHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Abstract data handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class AbstractDataHandler.
    /// </summary>
    public abstract class AbstractDataHandler
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDataHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public AbstractDataHandler(MainWindow main)
        {
            this.Main = main;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        protected Logger Logger
        {
            get
            {
                return this.logger;
            }

            private set;
        }

        /// <summary>
        /// Gets the main.
        /// </summary>
        /// <value>The main.</value>
        protected MainWindow Main { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Creates the object.
        /// </summary>
        public abstract void CreateObject();

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="message">The message.</param>
        public abstract void Update(int id, object message);

        /// <summary>
        /// Sets the factory.
        /// </summary>
        public abstract void SetFactory();

        #endregion Methods
    }
}