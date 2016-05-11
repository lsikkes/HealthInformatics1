using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Visualizer.Furniture
{
    internal class Seat : StackPanel
    {
        #region Methods

        public Image getImage()
        {
            Image seatImg = new Image();
            seatImg.Width = 50;
            seatImg.Height = 50;
            String location = GeenNaam.MainWindow.AbsolutePath + "icon_chair.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            seatImg.Source = MoleImage;
            return seatImg;
        }

        public Panel createSeatPanel(int x, int y)
        {
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            panel.Children.Add(getImage());
            return panel;
        }

        #endregion Methods
    }
}