// <copyright file="CharacterHandler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>character handler class</summary>
// ***********************************************************************
namespace Visualizer.DataHandlers
{
    using System.Collections.Generic;
    using Visualizer.Factories;
    using Visualizer.ViewModels;

    /// <summary>
    /// Class CharacterHandler.
    /// </summary>
    /// <seealso cref="Visualizer.DataHandlers.AbstractDataHandler" />
    public class CharacterHandler : AbstractDataHandler
    {
        #region Fields

        /// <summary>
        /// The characters
        /// </summary>
        private Dictionary<int, CharacterViewModel> characters = new Dictionary<int, CharacterViewModel>();

        /// <summary>
        /// The factory
        /// </summary>
        private CharacterFactory factory;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterHandler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public CharacterHandler(MainWindow main)
            : base(main)
        {
            this.SetFactory();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets the factory.
        /// </summary>
        public override void SetFactory()
        {
            if (this.factory != null)
            {
                this.factory = new CharacterFactory();
                this.Logger.Info("Character factory set");
            }

            this.Logger.Warning("Character factory already created");
        }

        /// <summary>
        /// Creates the Character object.
        /// </summary>
        public override void CreateObject()
        {
            int id = 0;
            if (this.characters.ContainsKey(id))
            {
                this.Logger.Warning("Character object already exist");
                return;
            }
            else
            {
                this.Logger.Debug("create character");
            }
        }

        /// <summary>
        /// Updates the object with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="message">The message.</param>
        public override void Update(int id, object message)
        {
        }

        #endregion Methods
    }
}