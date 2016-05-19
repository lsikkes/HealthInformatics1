// <copyright file="BenchFactory.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Furniture
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Class BenchFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Furniture.FurnitureFactory" />
    public class BenchFactory : FurnitureFactory
    {
        #region Fields

        /// <summary>
        /// The rectangle height
        /// </summary>
        private int rectangleHeight = 0,

            /// <summary>
            /// The rectangle width
            /// </summary>
        rectangleWidth = 0,

            /// <summary>
            /// The start position x
            /// </summary>
        startPositionX = 0,

            /// <summary>
            /// The start position y
            /// </summary>
        startPositionY = 0,

            /// <summary>
            /// The offset between seats
            /// </summary>
        offset = 70;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Creates the bench.
        /// </summary>
        /// <param name="orientation">The orientation.</param>
        /// <param name="amountSeats">The amount seats.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Bench.</returns>
        public Bench CreateBench(string orientation, int amountSeats, int x, int y)
        {
            Bench bench = new Bench(0, 0, 0, 10, "bench");
            this.DetermineParameters(orientation, amountSeats, x, y);
            bench.Children.Add(this.CreateBenchRectangle(orientation, amountSeats, x, y));
            for (int i = 0; i < amountSeats; i++)
            {
                Seat seat = new Seat(0, 0, 0, 0, "seat");
                Image seatImg = seat.GetImage();
                seatImg.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                seatImg.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                seatImg.Margin = this.SetMargin(seat.Margin, this.startPositionX, -10);

                bench.Children.Add(seatImg);
                if (orientation == "h")
                {
                    x += this.offset;
                }
                else
                {
                    y += this.offset;
                }
            }

            return bench;
        }

        /// <summary>
        /// Determines the parameters.
        /// </summary>
        /// <param name="orientation">The orientation.</param>
        /// <param name="amountSeats">The amount seats.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void DetermineParameters(string orientation, int amountSeats, int x, int y)
        {
            if (orientation.Equals("h"))
            {
                this.rectangleWidth = 70 * amountSeats;
                this.rectangleHeight = 70;
            }
            else if (orientation.Equals("v"))
            {
                this.rectangleWidth = 70;
                this.rectangleHeight = 70 * amountSeats;
                this.startPositionX = this.rectangleWidth + 10;
                this.startPositionY = -y - 1000;
            }
        }

        /// <summary>
        /// Creates the bench rectangle.
        /// </summary>
        /// <param name="orientation">The orientation.</param>
        /// <param name="amountSeats">The amount seats.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Rectangle.</returns>
        public Rectangle CreateBenchRectangle(string orientation, int amountSeats, int x, int y)
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Pink);
            rect.Height = this.rectangleHeight;
            rect.Width = this.rectangleWidth;

            rect.Margin = this.SetMargin(rect.Margin, x, y);
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            return rect;
        }

        #endregion Methods
    }
}