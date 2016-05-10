using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Visualizer
{
    class Car : VRObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        public Car() { }
        /// <summary>
        /// Gets the car image.
        /// </summary>
        /// <returns>Image.</returns>
        public virtual Image getCarImage() { return null; }
        /// <summary>
        /// Gets the icon image.
        /// </summary>
        /// <returns>Image.</returns>
        public virtual Image getIconImage() { return null; }
    }
}
