// <copyright file="Bench.cs" company="HI1">
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
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Class Bench.
    /// </summary>
    /// <seealso cref="Visualizer.ImmovableObject" />
    public class Bench : ImmovableObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Bench" /> class.
        /// </summary>
        public Bench(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Methods

        ////public ArrayList makeBenchArray(String orientation, int amountSeats, int x, int y)
        ////{
        ////    ArrayList list = new ArrayList();
        ////    x += 10;
        ////    y += 10;
        ////    for (int i = 0; i < amountSeats; i++)
        ////    {
        ////        StackPanel panel2 = new StackPanel();
        ////        panel2.Children.Add(createSeat(x, y));
        ////        list.Add(createSeat(x, y));
        ////        if (orientation.Equals("h"))
        ////        {
        ////            x += 70;
        ////        }
        ////        else if (orientation.Equals("v"))
        ////        {
        ////            y += 70;
        ////        }
        ////    }
        ////    return list;
        ////}

        ////public Seat createSeat(int x, int y)
        ////{
        ////    Seat seat = new Seat();
        ////    return (Seat)seat.createSeatImage(x, y);
        /////}

        #endregion Methods
    }
}