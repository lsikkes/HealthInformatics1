using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Visualizer;
using Visualizer.Patient;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class PatientFactoryTest
    {
        #region Methods

        [Test]
        public void createSurroundingFactoryTest()
        {
            PatientFactory patientFactory = new PatientFactory();
            Assert.IsNotNull(patientFactory);
        }

        #endregion Methods
    }
}