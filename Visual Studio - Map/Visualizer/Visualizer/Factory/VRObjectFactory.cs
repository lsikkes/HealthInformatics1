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

        public static CharacterViewModel newVRObject(int x, int y, MainWindow main)
        {
            CharacterView view = new CharacterView();
            CharacterViewModel viewModel = new CharacterViewModel(new VRPosition(x, y, 0), 0, 1, 0);
            view.DataContext = viewModel;
            main.addView(view, x, y);
            return viewModel;
        }

        #endregion Methods
    }
}