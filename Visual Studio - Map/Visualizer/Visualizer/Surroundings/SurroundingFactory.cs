// <copyright file="SurroundingFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Surroundings
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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
    using Visualizer.Surroundings;

    /// <summary>
    /// Class SurroundingFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factories" />
    public class SurroundingFactory : Factory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SurroundingFactory" /> class.
        /// </summary>
        public SurroundingFactory()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the surrounding.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="w">The w.</param>
        /// <param name="h">The h.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Surrounding object.</returns>
        /// <exception cref="System.NullReferenceException">surrounding type not specified correctly</exception>
        public Surrounding CreateSurrounding(int type, int w, int h, int x, int y)
        {
            Surrounding surrounding;
            switch (type)
            {
                case 0:
                    surrounding = new Tree(0, 0, 0, 0, "tree", w, h, x, y);
                    break;

                case 1:
                    surrounding = new Wall(0, 0, 0, 0, "building", w, h, x, y);
                    break;

                default:
                    surrounding = null;
                    break;
            }

            if (surrounding == null)
            {
                throw new NullReferenceException("surrounding type not specified correctly");
            }

            surrounding.Children.Add(surrounding.GetRect());

            return surrounding;
        }

        #endregion Methods
    }
}