// <copyright file="DataHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Data handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    /// <summary>
    /// Class DataHandler.
    /// </summary>
    public class DataHandler
    {
        #region Fields

        /// <summary>
        /// The main
        /// </summary>
        private MainWindow main;

        /// <summary>
        /// The character handler
        /// </summary>
        private CharacterHandler characterHandler;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public DataHandler(MainWindow main)
        {
            this.main = main;
            this.CreateHandlers();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the handlers.
        /// </summary>
        public void CreateHandlers()
        {
            this.characterHandler = new CharacterHandler(this.main);
        }

        #endregion Methods
    }
}