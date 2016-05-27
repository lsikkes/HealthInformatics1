// <copyright file="BenchFactory.cs" company="HI1">
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
    /// Factory of the bench.
    /// </summary>
    public class BenchFactory
    {
        #region Methods

        /// <summary>
        /// Creates the new bench.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="main">The main window.</param>
        /// <returns> the viewModel of the bench.</returns>
        public BenchViewModel CreateNewBench(int x, int y, MainWindow main, int amountSeats)
        {
            BenchView view = new BenchView();
            BenchViewModel viewModel = new BenchViewModel(new VRPosition(x, y, 0), 0, amountSeats);
            view.DataContext = viewModel;
            main.AddControl(view);
            return viewModel;
        }

        #endregion Methods
    }
}