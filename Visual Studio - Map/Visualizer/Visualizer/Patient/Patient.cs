﻿// <copyright file="Patient.cs" company="HI1">
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
    using Visualizer.Utilities;

    /// <summary>
    /// Class Patient.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    public class Patient : MovableObject
    {
        #region Fields

        /// <summary>
        /// The logger instance
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor of MovableObject
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="rotation">rotation of object</param>
        /// <param name="id">id of object</param>
        /// <param name="name">name of object</param>
        public Patient(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
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
        /// Walks the patient to the given position.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rotation">The rotation.</param>
        public void WalkTo(int x, int y, int rotation)
        {
            this.MoveTo(x, y);
            this.RenderTransform = new RotateTransform(rotation, 10, 190);
            this.UpdatePosition(x, y, rotation);
        }

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <returns> string of the image </returns>
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