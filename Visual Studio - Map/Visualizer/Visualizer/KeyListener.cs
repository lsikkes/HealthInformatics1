// <copyright file="KeyListener.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Class KeyListener.
    /// </summary>
    public class KeyListener
    {
        #region Methods

        /// <summary>
        /// Method that handles all keyboard events
        /// </summary>
        /// <param name="sender">The object that sends the event</param>
        /// <param name="e">The event that occurs</param>
        public static void KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    GeenNaam.MainWindow.patient.WalkUp();
                    break;

                case Key.Down:
                    GeenNaam.MainWindow.patient.WalkDown();
                    break;

                case Key.Left:
                    GeenNaam.MainWindow.patient.WalkLeft();
                    break;

                case Key.Right:
                    GeenNaam.MainWindow.patient.WalkRight();
                    break;

                default:
                    Console.WriteLine("Unknow key input " + e.Key);
                    break;
            }
        }

        #endregion Methods
    }
}