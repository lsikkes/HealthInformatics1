// <copyright file="BuildingFactory.cs" company="HI1">
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
    /// Factory of the building.
    /// </summary>
    public class BuildingFactory
    {
        #region Methods

        /// <summary>
        /// Creates the new building.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="main">The main.</param>
        /// <param name="id">The identifier.</param>
        /// <returns> the view-model of the building</returns>
        public BuildingViewModel CreateNewBuilding(int x, int y, MainWindow main, int id)
        {
            SurroundingView view = new SurroundingView();
            BuildingViewModel viewModel = new BuildingViewModel(new VRPosition(x, y, 0), id);
            view.DataContext = viewModel;
            main.AddControl(view);
            return viewModel;
        }

        #endregion Methods
    }
}