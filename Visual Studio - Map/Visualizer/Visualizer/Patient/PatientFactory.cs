// <copyright file="PatientFactory.cs" company="HI1">
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

    /// <summary>
    /// Class PatientFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class PatientFactory : Factory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientFactory"/> class.
        /// </summary>
        public PatientFactory()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the patient.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns>Patient object.</returns>
        public Patient CreatePatient(int x, int y, int rotation)
        {
            Patient patient = new Patient(0, 0, 0, 0, "patient");
            patient.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            patient.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            patient.Margin = this.SetMargin(patient.Margin, x, y);

            patient.Children.Add(this.GetImage(patient.GetImageScopeResource(), 400, 400));
            patient.Children.Add(this.GetImage(patient.GetImageResource(), 50, 50, -380, -410));

            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            patient.RenderTransform = rotateTransform1;

            return patient;
        }

        #endregion Methods
    }
}