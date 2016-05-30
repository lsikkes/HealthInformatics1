
namespace VisualizerUnitTest.Log
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Visualizer.Log;

    [TestFixture]
    class LoggerViewModelTest
    {
        #region Fields

        private LoggerViewModel vm_1;

        #endregion

        #region Methods

        [SetUp]
        public void SetUp()
        {
            vm_1 = LoggerViewModel.Instance();
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(vm_1);
        }

        #endregion


    }
}
