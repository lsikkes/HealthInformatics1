using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Visualizer.ViewModels;

namespace Visualizer.Views
{
    /// <summary>
    /// Interaction logic for VRObjectView.xaml
    /// </summary>
    public partial class VRObjectView : UserControl
    {
        #region Constructors

        public VRObjectView()
        {
            InitializeComponent();
            base.DataContext = new VRObjectViewModel();
        }

        #endregion Constructors

        #region Methods

        public void SetDataContext(PatientViewModel viewModel)
        {
            base.DataContext = viewModel;
        }

        #endregion Methods
    }
}