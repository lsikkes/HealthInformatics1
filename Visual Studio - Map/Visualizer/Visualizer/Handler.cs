// <copyright file="Handler.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Visualizer.Factories;
    using Visualizer.Utilities;
    using Visualizer.ViewModels;

    /// <summary>
    /// Handler which manages which models will be imported.
    /// </summary>
    public class Handler
    {
        #region Fields

        /// <summary>
        /// The _objects which will be included in the main.
        /// </summary>
        private Collection<AbstractViewModel> objects = new Collection<AbstractViewModel>();

        /// <summary>
        /// The mainWindow.
        /// </summary>
        private MainWindow main;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Handler"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public Handler(MainWindow main)
        {
            this.main = main;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Moves the object.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void MoveObject(int id, int x, int y)
        {
            Console.WriteLine("setting x and y");
            this.objects[id].SetPosition(new VRPosition(x, y, 0));
        }

        /// <summary>
        /// Add the objects.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void AddObjects(int x, int y)
        {
            int amountSeats = 3;
            this.objects.Add((new BenchFactory()).CreateNewBench(x, y, this.main, amountSeats));
            CharacterFactory factory = new CharacterFactory();

            this.objects.Add(factory.CreateCharacter(x + 500, y-200, this.main, 0, 1, 1));
            this.objects.Add(factory.CreateCharacter(x + 750, y-100, this.main, 1, 6, 1));
            this.objects.Add(factory.CreateCharacter(x + 900, y, this.main, 0, 1, 1));
        }

        #endregion Methods
    }
}