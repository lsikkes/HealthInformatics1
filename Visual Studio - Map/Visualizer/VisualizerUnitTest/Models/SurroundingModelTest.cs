namespace VisualizerUnitTest.Models
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
    public class SurroundingModelTest
    {
        #region Methods

        private AbstractSurroundingModel surrounding;
        private VRPosition position;

        [SetUp]
        public void SetUp()
        {
            position = new VRPosition(100, 100, 230);
            surrounding = new AbstractSurroundingModel(position, 10);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(surrounding);
        }

        #endregion Methods
    }
}