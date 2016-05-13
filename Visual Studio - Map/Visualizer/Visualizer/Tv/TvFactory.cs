﻿// <copyright file="TvFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Controls;

    /// <summary>
    /// Class TVFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class TVFactory : Factory
    {
        #region Methods

        /// <summary>
        /// Creates the TV screen.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>TVScreen.</returns>
        public TVScreen CreateTvScreen(int x, int y)
        {
            TVScreen tv = new TVScreen();

            tv.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tv.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            tv.Margin = this.SetMargin(tv.Margin, x, y);

            Image imageTV = this.GetImage("icon_tv.PNG", 50, 50);

            tv.Children.Add(imageTV);

            return tv;
        }

        #endregion Methods
    }
}