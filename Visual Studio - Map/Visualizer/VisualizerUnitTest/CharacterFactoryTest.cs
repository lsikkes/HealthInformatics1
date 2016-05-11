using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizer;

namespace VisualizerUnitTest
{
    [TestFixture]
    public class CharacterFactoryTest
    {
        #region Methods

        [Test]
        public void createCharacterFactoryTest()
        {
            CharacterFactory characterFactory = new CharacterFactory();
            Assert.IsNotNull(characterFactory);
        }

        #endregion Methods
    }
}