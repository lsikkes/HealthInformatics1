// <copyright file="TvFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Tv
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Controls;

    /// <summary>
    /// Class TVFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factories" />
    public class TVFactory : Factory
    {
        #region Methods

        /// <summary>
        /// Creates the TV screen.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>TVScreen object.</returns>
        public TVScreen CreateTvScreen(int x, int y)
        {
            TVScreen tv = new TVScreen(0, 0, 0, 0, "TVscreen");

            tv.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tv.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            tv.Margin = this.SetMargin(tv.Margin, x, y);

            Image imageTV = this.GetImage(tv.GetImageResource(), 50, 50);

            tv.Children.Add(imageTV);

            return tv;
        }

        #endregion Methods
    }
}