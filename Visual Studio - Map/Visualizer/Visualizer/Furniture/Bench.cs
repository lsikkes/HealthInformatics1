using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Visualizer.Furniture
{
    internal class Bench : ArrayList
    {
        #region Fields

        private int amountSeats;

        #endregion Fields

        #region Constructors

        public Bench(String orientation, int amountSeats, int x, int y)
        {
            Rectangle rect = createBenchRectangle(orientation, amountSeats, x, y);
            StackPanel panel = new StackPanel();
            panel.Children.Add(rect);
            Add(panel);
            x += 10;
            y += 10;
            for (int i = 0; i < amountSeats; i++)
            {
                StackPanel panel2 = new StackPanel();
                panel2.Children.Add(createSeat(x, y));
                Add(panel2);
                if (orientation.Equals("h"))
                {
                    x += 70;
                }
                else if (orientation.Equals("v"))
                {
                    y += 70;
                }
            }
            this.amountSeats = amountSeats;
        }

        #endregion Constructors

        #region Methods

        public Seat createSeat(int x, int y)
        {
            Seat seat = new Seat();
            seat.Children.Add(seat.createSeatPanel(x, y));
            return seat;
        }

        public Rectangle createBenchRectangle(String orientation, int amountSeats, int x, int y)
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Pink);

            if (orientation.Equals("h"))
            {
                rect.Width = 70 * amountSeats;
                rect.Height = 70;
            }
            else if (orientation.Equals("v"))
            {
                rect.Width = 70;
                rect.Height = 70 * amountSeats;
            }

            Thickness margin = rect.Margin;
            margin.Left = x;
            margin.Top = y;
            rect.Margin = margin;
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            return rect;
        }

        #endregion Methods
    }
}