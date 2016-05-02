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

namespace Visualizer
{
    /**
     * A Class to create Patient VRObjects
     * */
    public class FactoryPatient : Factory
    {
        public Patient createPatient(int x, int y, int rotation)
        {
            Patient patient = new Patient();
            patient.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            patient.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            patient.Margin = setMargin(patient.Margin,x,y);

            patient.Children.Add(getImage("image_player_scoope.PNG",400,400));
            patient.Children.Add(getImage("image_player.PNG",50,50,-380,-410));

            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            patient.RenderTransform = rotateTransform1;

            return patient;
        }
    }
}
