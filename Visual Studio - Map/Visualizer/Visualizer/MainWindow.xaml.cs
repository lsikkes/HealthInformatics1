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
using System.Threading;

namespace GeenNaam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static String AbsolutePath = Directory.GetParent(@"..\..\..\..\").ToString() + @"\resources\";
        public Double height, width;

        private Visualizer.FactoryPatient patientFactory = new Visualizer.FactoryPatient();
        private Visualizer.FactorySurrounding surroundingFactory = new Visualizer.FactorySurrounding();
        private Visualizer.CharacterFactory characterFactory = new Visualizer.CharacterFactory();
        public static Visualizer.Patient patient;

        private static readonly int stepMapMove = 100, zeroMapMove = 0;

        //static String AbsolutePath = @"..\..\resources\";
        public MainWindow()
        {
            init();

            patient = patientFactory.createPatient((int)Math.Round(0.55 * width), (int)Math.Round(0.35 * height), 0);
            map.Children.Add(patient);


            addSurrounding();

            addCharacters();
            addCars();
            addLights();
            addTVs();
            addSeats();
        }

        public void init()
        {
            InitializeComponent();
            Uri iconUri = new Uri(AbsolutePath + "logo.PNG");
            this.Icon = BitmapFrame.Create(iconUri);
            width = System.Windows.SystemParameters.PrimaryScreenWidth;
            height = System.Windows.SystemParameters.PrimaryScreenHeight;
            Console.WriteLine("window size is " + width + "x" + height);

            map.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            map.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            map.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            map.Margin = patientFactory.setMargin(map.Margin, 0, 0);
        }

        // method to add all the surroundings to the environment
        public void addSurrounding()
        {
            Brush color;
            // add walls
            color = Brushes.LightGray;
            map.Children.Add(surroundingFactory.createSurrounding(w2p(0.05), h2p(1.00), 0,         0,         color));
            map.Children.Add(surroundingFactory.createSurrounding(w2p(0.35), h2p(0.15), w2p(0.25), 0,         color));
            map.Children.Add(surroundingFactory.createSurrounding(w2p(0.35), h2p(0.15), w2p(0.75), 0,         color));
            map.Children.Add(surroundingFactory.createSurrounding(w2p(0.75), h2p(0.15), w2p(0.25), h2p(0.85), color));
            // adds trees to the environment
            color = Brushes.LightGreen;
            map.Children.Add(surroundingFactory.createSurrounding(h2p(0.15), h2p(0.15), w2p(0.30), h2p(0.67), color));
            map.Children.Add(surroundingFactory.createSurrounding(h2p(0.15), h2p(0.15), w2p(0.50), h2p(0.67), color));
        }

        public int w2p(double perc) { return (int)Math.Round(perc * width); }
        public int h2p(double perc) { return (int)Math.Round(perc * height); }

        // method to place all seats
        public void addSeats()
        {
            Brush color = Brushes.Brown;
            addSquare(210, 70, 1100, 620, color);
            addSeat(1110, 630);
            addSeat(1180, 630);
            addSeat(1250, 630);
        }

        //method to add a square to the environment
        private void addSquare(int w, int h, int mx, int my, System.Windows.Media.Brush color)
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
            margin.Left = mx;
            margin.Top = my;
            rect.Margin = margin;
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            map.Children.Add(rect);
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
            
            map.Children.Add(characterFactory.createCharacter(x, y, ID, emoji));
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
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;

            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_light_off.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

            panel.Children.Add(Mole);

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
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;

            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_tv.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

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
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;

            Image Mole = new Image();
            Mole.Width = 125;
            Mole.Height = 250;
            String ImgNameMole = AbsolutePath + "image_police_car.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(ImgNameMole));
            Mole.Source = MoleImage;
            panel.Children.Add(Mole);

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

            RotateTransform rotateTransform1 = new RotateTransform(rotation, 65, 125);
            panel.RenderTransform = rotateTransform1;

            map.Children.Add(panel);
        }

        // Method to add a light to the environment
        public void addSeat(int x, int y)
        {
            StackPanel panel;
            panel = new StackPanel();
            panel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            panel.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            Thickness margin = panel.Margin;
            margin.Left = x;
            margin.Top = y;
            panel.Margin = margin;

            Image Mole = new Image();
            Mole.Width = 50;
            Mole.Height = 50;
            String location = AbsolutePath + "icon_chair.PNG";
            ImageSource MoleImage = new BitmapImage(new Uri(location));
            Mole.Source = MoleImage;

            panel.Children.Add(Mole);
            map.Children.Add(panel);
        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape: this.Close(); break;
                case Key.A: moveMap(stepMapMove, zeroMapMove); break;
                case Key.D: moveMap(-stepMapMove, zeroMapMove); break;
                case Key.W: moveMap(zeroMapMove, stepMapMove); break;
                case Key.S: moveMap(zeroMapMove, -stepMapMove); break;
                default: Visualizer.KeyListener.keyPress(sender, e); break;
            }
        }        

        /// <summary>
        /// Moves the map in the direction of dx and dy.
        /// </summary>
        /// <param name="dx">Moving dx pixels on the x axis</param>
        /// <param name="dy">Moving dy pixels on the y axis</param>
        public void moveMap(int dx, int dy)
        {
            Thickness m = map.Margin;
            m.Left = m.Left + dx;
            m.Top = m.Top + dy;
            map.Margin = m;
        }

    }
}
