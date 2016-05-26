namespace VisualizerUnitTest.Models
{
    using NUnit.Framework;
    using Visualizer.Models;
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;

    [TestFixture]
    internal class CharacterModelTest
    {
        #region Fields

        private VRPosition position1;
        private CharacterModel character1;
        private CharacterModel character2;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            position1 = new VRPosition(42, 42, 42);
            character1 = new CharacterModel(position1, 0, 0, 0);
            character2 = new CharacterModel(position1, 0, 2, 5);
        }

        [Test]
        public void ConstructorInvalidParametersTest()
        {
            Assert.NotNull(character1);
            Assert.AreEqual(character1.Action, CharacterAction.Nothing);
            Assert.AreEqual(character1.Emotion, CharacterEmotion.Neutral);
        }

        [Test]
        public void ConstructorValidParametersTest()
        {
            Assert.NotNull(character2);
            Assert.AreEqual(character2.Action, CharacterAction.FollowUser);
            Assert.AreEqual(character2.Emotion, CharacterEmotion.Afraid);
        }

        [Test]
        public void setEmotionTestSucceed()
        {
            character1.SetEmotion(5);
            Assert.AreEqual(CharacterEmotion.Happy, character1.Emotion);
        }

        [Test]
        public void setEmotionTestFail()
        {
            character1.SetEmotion(2);
            Assert.AreEqual(CharacterEmotion.Afraid, character1.Emotion);
            character1.SetEmotion(0);
            Assert.AreEqual(CharacterEmotion.Afraid, character1.Emotion);
        }

        [Test]
        public void setActionTestSucceed()
        {
            character1.SetAction(3);
            Assert.AreEqual(CharacterAction.TakingPicture, character1.Action);
        }

        [Test]
        public void setActionTestFail()
        {
            character1.SetAction(2);
            Assert.AreEqual(CharacterAction.CallingPhone, character1.Action);
            character1.SetAction(0);
            Assert.AreEqual(CharacterAction.CallingPhone, character1.Action);
        }

        #endregion Methods
    }
}