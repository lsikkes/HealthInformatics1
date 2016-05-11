using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Visualizer.Furniture
{
    public class BenchFactory : FurnitureFactory
    {
        #region Fields

        private int rectangleHeight = 0, rectangleWidth = 0, startPositionX = 0, startPositionY = 0, offset = 70;

        #endregion Fields

        #region Methods

        public Bench createBench(String orientation, int amountSeats, int x, int y)
        {
            Bench bench = new Bench();
            DetermineParameters(orientation, amountSeats, x, y);
            bench.Children.Add(createBenchRectangle(orientation, amountSeats, x, y));
            for (int i = 0; i < amountSeats; i++)
            {
                Seat seat = new Seat();
                Image seatImg = seat.getImage();
                seatImg.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                seatImg.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                seatImg.Margin = setMargin(seat.Margin, startPositionX, -10);

                bench.Children.Add(seatImg);
                if (orientation == "h")
                {
                    x += offset;
                }
                else
                {
                    y += offset;
                }
            }

            return bench;
        }

        public void DetermineParameters(String orientation, int amountSeats, int x, int y)
        {
            if (orientation.Equals("h"))
            {
                rectangleWidth = 70 * amountSeats;
                rectangleHeight = 70;
            }
            else if (orientation.Equals("v"))
            {
                rectangleWidth = 70;
                rectangleHeight = 70 * amountSeats;
                startPositionX = rectangleWidth + 10;
                startPositionY = -y - 1000;
            }
        }

        public Rectangle createBenchRectangle(String orientation, int amountSeats, int x, int y)
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Pink);
            rect.Height = rectangleHeight;
            rect.Width = rectangleWidth;

            rect.Margin = setMargin(rect.Margin, x, y);
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            return rect;
        }

        #endregion Methods
    }
}