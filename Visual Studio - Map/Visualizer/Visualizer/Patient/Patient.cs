// <copyright file="Patient.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Patient
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
    using Visualizer;

    /// <summary>
    /// Class Patient.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    public class Patient : MovableObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient" /> class.
        /// </summary>
        public Patient()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Walks up.
        /// </summary>
        public void WalkUp()
        {
            this.Walk(0, -50);
            this.RenderTransform = new RotateTransform(270, 10, 190);
        }

        /// <summary>
        /// Walks down.
        /// </summary>
        public void WalkDown()
        {
            this.Walk(0, 50);
            this.RenderTransform = new RotateTransform(90, 10, 190);
        }

        /// <summary>
        /// Walks the right.
        /// </summary>
        public void WalkRight()
        {
            this.Walk(50, 0);
            this.RenderTransform = new RotateTransform(0, 10, 190);
        }

        /// <summary>
        /// Walks the left.
        /// </summary>
        public void WalkLeft()
        {
            this.Walk(-50, 0);
            this.RenderTransform = new RotateTransform(180, 10, 190);
        }

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <returns>string patient image</returns>
        public string GetImageResource()
        {
            return ImageEnum.PatientImage.ToString();
        }

        /// <summary>
        /// Gets the image scope resource.
        /// </summary>
        /// <returns>string image of the scope</returns>
        public string GetImageScopeResource()
        {
            return ImageEnum.PatientScope.ToString();
        }

        #endregion Methods
    }
}