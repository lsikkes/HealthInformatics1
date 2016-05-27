namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Visualizer.Models;
    using Visualizer.Utilities;

    [TestFixture]
    public class AbstractVRObjectTest
    {
        #region Fields

        private AbstractVRObject objectVR;

        private VRPosition position;

        private int id;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            id = 1;
            position = new VRPosition(42, 42, 0);
            objectVR = new PatientModel(position, id);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(objectVR);
            Assert.AreEqual(position, objectVR.Position);
            Assert.AreEqual(id, objectVR.Id);
            Assert.AreEqual(new VRPosition(42, 42, 0), objectVR.Position);
        }

        #endregion Methods
    }
}