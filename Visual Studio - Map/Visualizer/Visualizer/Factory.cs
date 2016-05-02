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
     * A Class to create VRObjects
     * */
    public class Factory
    {
        /**
         * A method to set the margin of VRobject
         * */
        public Thickness setMargin(Thickness margin, int x, int y)
        {
            margin.Left = x;
            margin.Top = y;
            return margin;
        }

        /**
         * A method to return an image
         * */
        public Image getImage(String path, int width, int height)
        {
            Image Mole = new Image();
            Mole.Width = 400;
            Mole.Height = 400;

            String ImgNameMole = GeenNaam.MainWindow.AbsolutePath + path;

            ImageSource MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;

            return Mole;
        }

        /**
         * A method to return an image with a set margin
         * */
        public Image getImage(String path, int width, int height, int x, int y)
        {
            Image Mole = getImage(path, width, height);
            Mole.Margin = setMargin(Mole.Margin, x, y);
            return Mole;
        }

    }

}
