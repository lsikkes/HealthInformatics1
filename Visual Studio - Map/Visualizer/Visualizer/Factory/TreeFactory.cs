// <copyright file="TreeFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>VRObjectModel class</summary>
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
    /// Factory of the tree.
    /// </summary>
    public class TreeFactory
    {
        #region Methods

        /// <summary>
        /// Creates the new tree.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="main">The main.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>the view-model of the tree</returns>
        public TreeViewModel CreateNewTree(int x, int y, MainWindow main, int id)
        {
            SurroundingView view = new SurroundingView();
            TreeViewModel viewModel = new TreeViewModel(new VRPosition(x, y, 0), id);
            view.DataContext = viewModel;
            main.AddControl(view);
            return viewModel;
        }

        #endregion Methods
    }
}