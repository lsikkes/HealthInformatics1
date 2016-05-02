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
     * A Class for Objects to display in the environment
     * */
    public class VRObject : StackPanel
    {
        public void moveTo(int x, int y)
        {
            Thickness margin = this.Margin;
            margin.Left = x;
            margin.Top = y;
            this.Margin = margin;
        }

        public void walk(int x, int y)
        {
            Thickness margin = this.Margin;
            margin.Left += x;
            margin.Top += y;
            this.Margin = margin;
        }
    }
}
