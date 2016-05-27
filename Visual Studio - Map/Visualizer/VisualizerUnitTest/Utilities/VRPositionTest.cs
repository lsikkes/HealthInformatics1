namespace VisualizerUnitTest
{
    using NUnit.Framework;
    using System.Threading;
    using Visualizer;
    using Visualizer.Models;
    using Visualizer.Utilities;

    [TestFixture]
    public class VRPositionTest
    {
        #region Fields

        private VRPosition position1;
        private VRPosition position2;
        private VRPosition position3;
        private VRPosition position4;
        private VRPosition position5;
        private VRPosition position6;
        private VRPosition position7;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 360);
            position2 = new VRPosition(42, 42, 360);
            position3 = new VRPosition(24, 42, 360);
            position4 = new VRPosition(42, 24, 360);
            position5 = new VRPosition(42, 42, 300);
            position6 = new VRPosition(84, 84, 360);
            position7 = new VRPosition(42, 42);
        }

        [Test]
        public void ConstructorThreeTest()
        {
            Assert.NotNull(position1);
        }

        [Test]
        public void ConstructorTwoTest()
        {
            Assert.NotNull(position7);
        }

        [Test]
        public void XPropertyGetTest()
        {
            Assert.AreEqual(42, position1.X);
        }

        [Test]
        public void YPropertyGetTest()
        {
            Assert.AreEqual(42, position1.Y);
        }

        [Test]
        public void RotationPropertyGetTest()
        {
            Assert.AreEqual(360, position1.Rotation);
        }

        [Test]
        public void EqualsSameReferenceTest()
        {
            Assert.AreEqual(position1, position1);
        }

        [Test]
        public void EqualsDifferentReferenceTest()
        {
            Assert.AreEqual(position1, position2);
        }

        [Test]
        public void EqualsDifferentValueTest()
        {
            Assert.AreNotEqual(position2, position3);
            Assert.AreNotEqual(position2, position4);
            Assert.AreNotEqual(position2, position5);
        }

        [Test]
        public void EqualsNullTest()
        {
            Assert.False(position1.Equals(null));
        }

        [Test]
        public void EqualsDifferentObjectTest()
        {
            Assert.AreNotEqual(position1, new CharacterModel(position3, 10, 4, 4));
        }

        [Test]
        public void MoveTest()
        {
            position1.Move(84, 84);
            Assert.AreEqual(position1, position6);
        }

        #endregion Methods
    }
}