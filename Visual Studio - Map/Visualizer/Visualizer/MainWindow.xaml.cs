using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Visualizer;
using Visualizer.Models;
using Visualizer.MVVM;
using Visualizer.Views;

namespace Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        private Handler _handler;

        #endregion Fields

        #region Constructors

        public MainWindow()
        {
            StartMain();
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        public static String getPath()
        {
            return "";
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public void StartMain()
        {
            _handler = new Handler(this);
        }

        public void addView(VRObjectView view, int x, int y)
        {
            canvas.Children.Add(view);

            //    Thickness a = view.Margin;
            //    a.Left = x;
            //    a.Top = y;
            //    view.Margin = a;
        }

        public void click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("click");
            _handler.addObject(250, 250);
        }

        public void click2(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("click2");
            _handler.moveObject(0, 310, 410);
        }

        public void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("hovering on: ");
        }

        public void OnMouseLeaveHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("hovering off ");
        }

        //method to add a square to the environment
        private void toggleMenu(object sender, RoutedEventArgs e)
        {
            if (menu.Visibility == System.Windows.Visibility.Collapsed)
            {
                menu.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                menu.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion Methods
    }
}