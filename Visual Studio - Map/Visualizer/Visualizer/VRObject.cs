// <copyright file="VRObject.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Class VRObject.
    /// </summary>
    /// <seealso cref="System.Windows.Controls.StackPanel" />
    public class VRObject : StackPanel
    {
        #region Fields

        /// <summary>
        /// position of the object
        /// </summary>
        private int positionX, positionY, rotation;

        /// <summary>
        /// logger instance
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VRObject"/> class.
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public VRObject(int x, int y, int rotation, int id, string name)
        {
            this.Identifier = id;
            this.ObjectName = name;
            this.UpdatePosition(x, y, rotation);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets id of the object
        /// </summary>
        public int Identifier { get; private set; }

        /// <summary>
        /// Gets name of the object
        /// </summary>
        public string ObjectName { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sets the margin.
        /// </summary>
        /// <param name="margin">The margin.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns> Thickness of the object </returns>
        public Thickness SetMargin(Thickness margin, int x, int y)
        {
            margin.Left = x;
            margin.Top = y;
            return margin;
        }

        /// <summary>
        /// Updates the position of the object
        /// </summary>
        /// <param name="x"> new x position</param>
        /// <param name="y"> new y position</param>
        /// <param name="rotation"> new rotation</param>
        protected virtual void UpdatePosition(int x, int y, int rotation)
        {
            this.positionX = x;
            this.positionY = y;
            this.rotation = rotation;
        }

        #endregion Methods
    }
}