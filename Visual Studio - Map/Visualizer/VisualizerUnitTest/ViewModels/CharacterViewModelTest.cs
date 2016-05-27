namespace VisualizerUnitTest.ViewModels
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Visualizer;
    using Visualizer.Factories;
    using Visualizer.Utilities;
    using Visualizer.ViewModels;

    [TestFixture, Apartment(ApartmentState.STA)]
    public class CharacterViewModelTest
    {
        #region Fields

        private CharacterFactory factory;
        private MainWindow main;
        private CharacterViewModel model;
        private int id;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            factory = new CharacterFactory();
            main = new MainWindow();
            id = 2;
            model = factory.CreateCharacter(100, 100, main, id, 1, 1);
        }

        [Test]
        public void SetActionTest()
        {
            int action = 2;
            model.SetAction(action);
            Assert.AreEqual(model.ActionBrush.ImageSource, ImageMap.GetImage(ImageEnum.GetCharacterAction(action)));
        }

        [Test]
        public void SetEmotionTest()
        {
            int emotion = 2;
            model.SetEmotion(emotion);
            Assert.AreEqual(model.EmotionBrush.ImageSource, ImageMap.GetImage(ImageEnum.GetCharacterEmotion(emotion)));
        }

        [Test]
        public void SetIconTest()
        {
            Assert.AreEqual(model.IconBrush.ImageSource, ImageMap.GetImage(ImageEnum.GetCharacter(id % 2)));
        }

        #endregion Methods
    }
}