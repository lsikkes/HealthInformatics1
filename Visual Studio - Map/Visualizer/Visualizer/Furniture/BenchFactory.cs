using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualizer.Furniture
{
    internal class BenchFactory : FurnitureFactory
    {
        #region Methods

        public Bench createBench(String orientation, int amountSeats, int x, int y)
        {
            Bench bench = new Bench(orientation, amountSeats, x, y);

            return bench;
        }

        #endregion Methods
    }
}