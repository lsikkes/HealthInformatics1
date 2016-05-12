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
    * A Class to create character VRObjects
    * */
    class CharacterFactory : Factory {

        public static String AbsolutePath = Directory.GetParent(@"..\..\..\..\").ToString() + @"\resources\";

        public StackPanel createCharacter(int x, int y, int ID, int emoji)
            {
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;

            StackPanel panel2;
            panel2 = new StackPanel();
            panel2.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel2.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            margin = panel2.Margin;
            margin.Left = 0;
            margin.Top = 0;
            panel2.Margin = margin;

            Image Mole = new Image();
            Mole.Width = 60;
            Mole.Height = 60;
            String location = "";
            if (ID == 0) { location = AbsolutePath + "image_character_0.PNG"; }
            else if (ID == 1) { location = AbsolutePath + "image_character_1.PNG"; }
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

            panel2.Children.Add(Mole);
            panel.Children.Add(panel2);

            Mole = new Image();
            Mole.Width = 25;
            Mole.Height = 25;
            if (emoji == 0) { location = AbsolutePath + "emoji_xhappy.PNG"; }
            else if (emoji == 1) { location = AbsolutePath + "emoji_sick.PNG"; }
            MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

            margin = Mole.Margin;
            margin.Left = 45;
            margin.Top = -105;
            Mole.Margin = margin;
            panel.Children.Add(Mole);
            return panel;
            }
        }
}
