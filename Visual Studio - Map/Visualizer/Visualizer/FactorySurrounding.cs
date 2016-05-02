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
     * A Class to create Surrounding VRObjects
     * */
    public class FactorySurrounding : Factory
    {
        public System.Windows.Shapes.Rectangle createSurrounding(int w, int h, int x, int y, System.Windows.Media.Brush color)
        {
            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle();
            rect = new Rectangle
            {
                Fill = color
            };
            rect.Width = w;
            rect.Height = h;

            rect.Margin = setMargin(rect.Margin,x,y);
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            return rect;
        }
    }
}
