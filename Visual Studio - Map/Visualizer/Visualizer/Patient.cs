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
using Visualizer;
namespace Visualizer
{
    /**
     * A Class to handle all input and output regarding the patient VRObject
     * */
    public class Patient : VRObject
    {
        public Patient()        {     }

        public void walkUp()
        {
            walk(0, -50);
            RenderTransform = new RotateTransform(270, 10, 190);
        }

        public void walkDown()
        {
            walk(0, 50);
            RenderTransform = new RotateTransform(90, 10, 190);
        }

        public void walkRight(){
            walk(50, 0);
            RenderTransform = new RotateTransform(0, 10, 190);
        }

        public void walkLeft(){
            walk(-50, 0);
            RenderTransform = new RotateTransform(180, 10, 190);
        }
    }
}
