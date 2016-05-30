// <copyright file="MainWindow.xaml.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>The main window</summary>
// ***********************************************************************
namespace Visualizer
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Visualizer.Log;

    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    public partial class MainWindow : Window
    {
        #region Fields

        /// <summary>
        /// The Data handler
        /// </summary>
        private Handler handler;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.StartMain();
            this.InitializeComponent();
            this.SetIcon();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public void StartMain()
        {
            this.handler = new Handler(this);
        }

        /// <summary>
        /// Adds the user control to the map
        /// </summary>
        /// <param name="view">The view.</param>
        public void AddControl(UserControl view)
        {
            canvas.Children.Add(view);
        }

        /// <summary>
        /// Adds an object to the map.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void Click(object sender, RoutedEventArgs e)
        {
            this.handler.AddObjects(250, 250);
            this.handler.MoveObject(0, 610, 410);
        }

        /// <summary>
        /// Moves the first object.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void Click2(object sender, RoutedEventArgs e)
        {
            this.handler.MoveObject(0, 310, 410);
        }

        /// <summary>
        /// Toggles the logger.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        public void ToggleLogger(object sender, RoutedEventArgs e)
        {
            if (this.logRow.Height.Value == 0)
            {
                Logger.GetInstance().Info("Showing Log panel");
                Logger.GetInstance().Debug("Showing Log panel");
                Logger.GetInstance().Warning("Showing Log panel");
                Logger.GetInstance().Error("Showing Log panel");
                if (this.LogPanel.Children.Count == 0)
                {
                    this.LogPanel.Children.Add(LoggerView.Instance());
                }

                this.logRow.Height = new GridLength(1, GridUnitType.Star);
            }
            else
            {
                Logger.GetInstance().Info("Hiding Log panel");
                this.logRow.Height = new GridLength(0);
            }
        }

        /// <summary>
        /// Called when mouse enters a bouncer.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        public void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
        }

        /// <summary>
        /// Called when mouse leaves a bouncer.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        public void OnMouseLeaveHandler(object sender, MouseEventArgs e)
        {
        }

        /// <summary>
        /// Toggles the menu.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ToggleMenu(object sender, RoutedEventArgs e)
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

        /// <summary>
        /// Sets the icon.
        /// </summary>
        private void SetIcon()
        {
        }

        /// <summary>
        /// Closes the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion Methods
    }
}