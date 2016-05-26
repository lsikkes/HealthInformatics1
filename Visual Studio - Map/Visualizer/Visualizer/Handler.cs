using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Visualizer.Factories;
using Visualizer.Utilities;
using Visualizer.ViewModels;

namespace Visualizer
{
    public class Handler
    {
        #region Fields

        private Collection<CharacterViewModel> _objects = new Collection<CharacterViewModel>();
        private MainWindow _main;

        #endregion Fields

        #region Constructors

        public Handler()
        {
        }

        public Handler(MainWindow main)
        {
            _main = main;
        }

        #endregion Constructors

        #region Methods

        public void moveObject(int id, int x, int y)
        {
            Console.WriteLine("setting x and y");
            _objects[id].SetPosition(new VRPosition(x, y, 0));
        }

        public void addObject(int x, int y)
        {
            _objects.Add(VRObjectFactory.newVRObject(x, y, _main));
        }

        #endregion Methods
    }
}