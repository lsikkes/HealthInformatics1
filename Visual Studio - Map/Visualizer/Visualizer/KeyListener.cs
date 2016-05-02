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
using System.IO;
using System.Threading;

namespace Visualizer
{
    class KeyListener
    {

        /// <summary>
        /// Method that handles all keyboard events
        /// </summary>
        /// <param name="sender"> The object that sends the event </param>
        /// <param name="e"> The event that occurs </param>
        public static void keyPress(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up: GeenNaam.MainWindow.patient.walkUp(); break;
                case Key.Down: GeenNaam.MainWindow.patient.walkDown(); break;
                case Key.Left: GeenNaam.MainWindow.patient.walkLeft(); break;
                case Key.Right: GeenNaam.MainWindow.patient.walkRight(); break;
                default: Console.WriteLine("Unknow key input " + e.Key); break;
            }
        }
    }
}
