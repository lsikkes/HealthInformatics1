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

namespace Visualizer
{
    /// <summary>
    /// Class SurroundingFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class SurroundingFactory : Factory
    {
        #region Methods

        /// <summary>
        /// Creates the surrounding.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="w">The w.</param>
        /// <param name="h">The h.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Surrounding.</returns>
        public Surrounding createSurrounding(int type, int w, int h, int x, int y)
        {
            Surrounding surrounding;
            switch (type)
            {
                case 0:
                    surrounding = new Tree(w, h, x, y);
                    break;

                case 1:
                    surrounding = new Wall(w, h, x, y);
                    break;

                default:
                    surrounding = new Surrounding();
                    break;
            }
            surrounding.Children.Add(surrounding.getRect());

            return surrounding;
        }

        #endregion Methods
    }
}