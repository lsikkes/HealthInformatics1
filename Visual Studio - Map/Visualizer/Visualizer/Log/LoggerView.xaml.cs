// <copyright file="LoggerView.xaml.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for LoggerControl
    /// </summary>
    public partial class LoggerControl : UserControl
    {
        /// <summary>
        /// The instance of the controller
        /// </summary>
        private static LoggerControl instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="LoggerControl"/> class from being created.
        /// </summary>
        private LoggerControl()
        {
            instance = this;
            this.InitializeComponent();
            this.DataContext = LoggerViewModel.Instance();
        }

        /// <summary>
        /// Returns this instance.
        /// </summary>
        /// <returns>this instance</returns>
        public static LoggerControl Instance()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                return new LoggerControl();
            }
        }

        /// <summary>
        /// The button to show all.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnShowAll(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("pressed all");
            LoggerViewModel.Instance().SetActive(LoggerEnum.AllString.ToString());
        }

        /// <summary>
        /// The button to show only errors.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnShowErr(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("pressed err");
            LoggerViewModel.Instance().SetActive(LoggerEnum.ErrorString.ToString());
        }

        /// <summary>
        /// The button to show only debug.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnShowDeb(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("pressed deb");
            LoggerViewModel.Instance().SetActive(LoggerEnum.DebugString.ToString());
        }

        /// <summary>
        /// The button to show only information.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnShowInf(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("pressed inf");
            LoggerViewModel.Instance().SetActive(LoggerEnum.InfoString.ToString());
        }

        /// <summary>
        /// The button to show only warnings.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnShowWar(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("pressed war");
            LoggerViewModel.Instance().SetActive(LoggerEnum.WarningString.ToString());
        }

        /// <summary>
        /// The button to reset the log memory.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        public void BtnResetLo(object sender, RoutedEventArgs e)
        {
            LoggerViewModel.Instance().Reset();
            Logger.GetInstance().Info("Reset the logger window");
        }
    }
}