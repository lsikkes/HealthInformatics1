// <copyright file="PatientTest.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Visualizer;
    using Visualizer.Patient;

    /// <summary>
    /// Class PatientTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class PatientTest
    {
        #region Methods

        /// <summary>
        /// Creates the patient test.
        /// </summary>
        [Test]
        public void CreatePatientTest()
        {
            Patient patient = new Patient(0, 0, 0, 0, "patient");
            Assert.IsNotNull(patient);
        }

        #endregion Methods
    }
}