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

        private int positionX, positionY, rotation;
        private int id;
        private string name;
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        public VRObject(int x, int y, int rotation, int id, string name)
        {
            updatePosition(x, y, rotation);
            this.id = id;
            this.name = name;
        }

        #endregion Constructors

        #region Methods

        protected virtual void updatePosition(int x, int y, int rotation)
        {
            this.positionX = x;
            this.positionY = y;
            this.rotation = rotation;
            logger.Info("Object " + name + " with id " + id + " updated to position " + x + ", " + y + ", " + rotation);
        }

        #endregion Methods
    }
}