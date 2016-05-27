// <copyright file="CharacterFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>CharacterFactory</summary>
// ***********************************************************************
namespace Visualizer.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Utilities;
    using Visualizer.ViewModels;
    using Visualizer.Views;

    /// <summary>
    /// Class CharacterFactory.
    /// </summary>
    public class CharacterFactory
    {
        #region Methods

        /// <summary>
        /// Creates the character.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="main">The main.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="emotion">The emotion.</param>
        /// <param name="action">The action.</param>
        /// <returns>the CharacterViewModel</returns>
        public CharacterViewModel CreateCharacter(int x, int y, MainWindow main, int id, int emotion, int action)
        {
            CharacterViewModel character = new CharacterViewModel(new VRPosition(x, y, 0), id, emotion, action);
            CharacterView view = new CharacterView();
            view.DataContext = character;
            main.addControl(view);
            return character;
        }

        #endregion Methods
    }
}