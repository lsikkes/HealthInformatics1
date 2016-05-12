using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Visualizer.Tv
{
    internal class TvFactory : Factory
    {
        #region Methods

        public TvScreen createTvScreen(int x, int y)
        {
            TvScreen tv = new TvScreen();

            tv.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tv.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            tv.Margin = setMargin(tv.Margin, x, y);

            Image tvImg = getImage("icon_tv.PNG", 50, 50);

            tv.Children.Add(tvImg);

            return tv;
        }

        #endregion Methods
    }
}