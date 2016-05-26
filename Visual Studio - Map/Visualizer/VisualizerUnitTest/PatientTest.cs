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
    using Visualizer.Utilities;


    /// <summary>
    /// Class PatientTest.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class PatientTest
    {
        #region Fields

        private Patient patient;

        #endregion Fields

        #region Methods

        [SetUp]
        public void setUp()
        {
            patient = new Patient(0, 0, 0, 0, "patient");
        }

        /// <summary>
        /// Creates the patient test.
        /// </summary>
        [Test]
        public void CreatePatientTest()
        {
            Assert.IsNotNull(patient);
        }

        /// <summary>
        /// Gets the patient resource test.
        /// </summary>
        [Test]
        public void GetPatientResourceTest()
        {
            string actualString = patient.GetImageResource();
            string expectedString = ImageEnum.PatientImage.ToString();
            Assert.AreEqual(expectedString, actualString);
        }

        /// <summary>
        /// Gets the patient scope resource test.
        /// </summary>
        [Test]
        public void GetPatientScopeResourceTest()
        {
            string actualString = patient.GetImageScopeResource();
            string expectedString = ImageEnum.PatientScope.ToString();
            Assert.AreEqual(expectedString, actualString);
        }

        #endregion Methods
    }
}