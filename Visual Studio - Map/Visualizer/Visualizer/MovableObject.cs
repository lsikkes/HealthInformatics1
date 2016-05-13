using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Visualizer
{
    public class MovableObject : VRObject
    {
        #region Methods

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

        #endregion Methods
    }
}