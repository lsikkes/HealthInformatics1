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
    public class Seat : Bench
    {
        #region Constructors

        public Seat()
        {
        }

        #endregion Constructors

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

        public Image createSeatImage(int x, int y)
        {
            Image seatImg = getImage();

            seatImg.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            seatImg.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            Thickness margin = seatImg.Margin;
            margin.Left = x;
            margin.Top = y;
            seatImg.Margin = margin;
            return seatImg;
        }

        #endregion Methods
    }
}