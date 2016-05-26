using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Visualizer.Models;
using MVVM;

namespace Visualizer.ViewModels
{
    [Obsolete]
    public class VRObjectViewModel : ObservableObject
    {
        #region Construction

        /// <summary>
        /// Constructs the default instance of a SongViewModel
        /// </summary>
        public VRObjectViewModel()
        {
            _vrobject = new VRModel { x = 0, y = 0 };
        }

        public VRObjectViewModel(int _x, int _y)
        {
            _vrobject = new VRModel { x = _x, y = _y };
        }

        #endregion Construction

        #region Members

        private VRModel _vrobject;

        #endregion Members

        #region Properties

        private Thickness _margin;

        public VRModel VRObject
        {
            get { return _vrobject; }
            set { _vrobject = value; }
        }

        public int x
        {
            get { return VRObject.x; }

            set
            {
                if (VRObject.x != value)
                {
                    VRObject.x = value;
                    Thickness a = Margin;
                    a.Left = x;
                    Margin = a;
                }
            }
        }

        public Thickness Margin
        {
            get
            {
                return _margin;
            }

            set
            {
                _margin = value;
                RaisePropertyChanged("Margin");
            }
        }

        public int y
        {
            get { return VRObject.y; }

            set
            {
                if (VRObject.y != value)
                {
                    VRObject.y = value;
                    Thickness a = Margin;
                    Console.WriteLine("y raise property changer");
                    a.Top = y;
                    Margin = a;
                }
            }
        }

        #endregion Properties

        #region Commands

        public ICommand UpdateX { get { return new RelayCommand(UpdateXExecute, CanUpdateXExecute); } }

        private void UpdateXExecute()
        {
            x = x + 50;
        }

        private bool CanUpdateXExecute()
        {
            return true;
        }

        #endregion Commands
    }
}