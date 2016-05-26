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

        public static PatientViewModel newVRObject(int x, int y, MainWindow main)
        {
            VRObjectView view = new VRObjectView();
            PatientViewModel viewModel = new PatientViewModel(new VRPosition(x, y, 0), 0);
            view.SetDataContext(viewModel);
            main.addView(view, x, y);
            return viewModel;
        }

        #endregion Methods
    }
}