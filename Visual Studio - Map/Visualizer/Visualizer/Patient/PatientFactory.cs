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

namespace Visualizer
{
    /// <summary>
    /// Class PatientFactory.
    /// </summary>
    /// <seealso cref="Visualizer.Factory" />
    public class PatientFactory : Factory
    {
        #region Methods

        /// <summary>
        /// Creates the patient.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns>Patient.</returns>
        public Patient createPatient(int x, int y, int rotation)
        {
            Patient patient = new Patient();
            patient.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            patient.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            patient.Margin = setMargin(patient.Margin, x, y);

            patient.Children.Add(getImage("image_player_scoope.PNG", 400, 400));
            patient.Children.Add(getImage("image_player.PNG", 50, 50, -380, -410));

            RotateTransform rotateTransform1 = new RotateTransform(rotation, 10, 190);
            patient.RenderTransform = rotateTransform1;

            return patient;
        }

        #endregion Methods
    }
}