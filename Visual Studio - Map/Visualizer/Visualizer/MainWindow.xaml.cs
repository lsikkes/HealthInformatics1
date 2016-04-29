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

namespace GeenNaam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static String AbsolutePath = Directory.GetParent(@"..\..\..\..\").ToString() + @"\resources\";
        Double height, width;
        
        public MainWindow()
        {
            // Initialize the environment
            InitializeComponent();

            Uri iconUri = new Uri(AbsolutePath + "logo.PNG");
            this.Icon = BitmapFrame.Create(iconUri);

            map.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            width = System.Windows.SystemParameters.PrimaryScreenWidth;
            height = System.Windows.SystemParameters.PrimaryScreenHeight;

            Console.WriteLine("window size is " + width + "x" + height);

            // Fill the environment with objects
            setPlayer((int)Math.Round(0.55 * width), (int)Math.Round(0.35 * height), 230);
            addSurrounding();
            addCharacters();
            addCars();
            addLights();
            addTVs();
            addSeats();
        }

        // method to add all the surroundings to the environment
        public void addSurrounding()
        {
            // prepare the map
            map.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            map.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = map.Margin;
            margin.Left = 0;
            margin.Top = 0;
            map.Margin = margin;

            Brush color;
            // add walls to the the environment
            color = Brushes.LightGray;
            addSquare(50, 1080, 0, 0, color);
            addSquare(500, 200, 300, 0, color);
            addSquare(500, 200, 1000, 0, color);
            addSquare(1200, 200, 300, 700, color);
            // add trees to the environment
            color = Brushes.LightGreen;
            addSquare(100, 100, 400, 590, color);
            addSquare(100, 100, 550, 590, color);
        }
        // method to place all seats
        public void addSeats()
        {
            // Add bench #1
            Brush color;
            color = Brushes.Brown;
            addSquare(210, 70, 1100, 620, color);
            addSeat(1110, 630);
            addSeat(1180, 630);
            addSeat(1250, 630);
            // Add more benches
        }

        //method to add a square to the environment
        private void addSquare(int w, int h, int Mx, int My, System.Windows.Media.Brush color)
        {
            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle();
            rect = new Rectangle
            {
                Fill = color
            };
            rect.Width = w;
            rect.Height = h;

            Thickness margin = rect.Margin;
            margin.Left = Mx;
            margin.Top = My;
            rect.Margin = margin;
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            map.Children.Add(rect);
        }

        // method to set the player within the map
        public void setPlayer(int x, int y, int rotation)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the scoope
            Image Mole = new Image();
            Mole.Width = 400;
            Mole.Height = 400;

            String ImgNameMole = AbsolutePath + "image_player_scoope.PNG";

            ImageSource MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;
            panel.Children.Add(Mole);
            // add the image
            Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            ImgNameMole = AbsolutePath + "image_player.PNG";
            MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;
            margin = Mole.Margin;
            margin.Left = -380;
            margin.Top = -410;
            Mole.Margin = margin;
            panel.Children.Add(Mole);
            // apply the rotation
            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            panel.RenderTransform = rotateTransform1;
            // append
            map.Children.Add(panel);
        }

        //method to add all characters
        public void addCharacters()
        {
            addCharacter(1000, 300, 0, 0);
            addCharacter(800, 300, 1, 1);
        }
        //method to add a character
        public void addCharacter(int x, int y, int ID, int emoji)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the image
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
            // add the emoji
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
            // append
            map.Children.Add(panel);
        }

        // method to place all lights
        public void addLights()
        {
            addLight(800, 50);
            addLight(950, 50);
        }
        // Method to add a light to the environment
        public void addLight(int x, int y)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the image
            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_light_off.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

            panel.Children.Add(Mole);
            // append
            map.Children.Add(panel);
        }

        // method to place all lights
        public void addTVs()
        {
            addTV(500, 200);
        }
        // Method to add a light to the environment
        public void addTV(int x, int y)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the image
            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_tv.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;
            // append
            panel.Children.Add(Mole);
            map.Children.Add(panel);
        }

        // method to set the cars in the environment
        public void addCars()
        {
            addCar(150, 20, 0);
        }
        // method to set a car within the map
        public void addCar(int x, int y, int rotation)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the scoope
            Image Mole = new Image();
            Mole.Width = 125;
            Mole.Height = 250;
            String ImgNameMole = AbsolutePath + "image_police_car.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;
            panel.Children.Add(Mole);
            // add the image
            Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            ImgNameMole = AbsolutePath + "icon_police.PNG";
            MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;
            margin = Mole.Margin;
            margin.Left = 0;
            margin.Top = -300;
            Mole.Margin = margin;
            panel.Children.Add(Mole);
            // apply the rotation
            RotateTransform rotateTransform1 = new RotateTransform(rotation, 65, 125);
            panel.RenderTransform = rotateTransform1;
            // append
            map.Children.Add(panel);
        }

        // Method to add a light to the environment
        public void addSeat(int x, int y)
        {
            // Create a StackPanel to contain the shape.
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;
            // add the image
            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_chair.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;
            // append
            panel.Children.Add(Mole);
            map.Children.Add(panel);
        }
    }
}
