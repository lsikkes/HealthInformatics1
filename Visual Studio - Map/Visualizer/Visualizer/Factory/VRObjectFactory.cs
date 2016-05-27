using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visualizer.Models;
using Visualizer.Utilities;
using Visualizer.ViewModels;
using Visualizer.Views;

namespace Visualizer.Factories
{
    internal class VRObjectFactory
    {
        #region Methods

        public static BenchViewModel newVRObject(int x, int y, MainWindow main)
        {
            BenchView view = new BenchView();
            BenchViewModel viewModel = new BenchViewModel(new VRPosition(x, y, 0), 0, 4);
            view.DataContext = viewModel;
            main.addView(view, x, y);
            return viewModel;
        }

        #endregion Methods
    }
}