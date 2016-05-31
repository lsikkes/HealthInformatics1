
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

        private LoggerViewModel vm;

        #endregion

        #region Methods

        [SetUp]
        public void SetUp()
        {
            vm = LoggerViewModel.Instance();
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(vm);
        }

        [Test]
        public void ResetTest()
        {
            vm.Reset();
            vm.Type = LoggerEnum.AllString.ToString();

            Assert.AreEqual(0, vm.Logs.Count);
            Assert.AreEqual(0, vm.Show.Count);
        }

        [Test]
        public void AddTest()
        {
            vm.Reset();
            vm.Add(new LogMessageDebug("Test"));
            vm.Type = LoggerEnum.AllString.ToString();

            Assert.AreEqual(1, vm.Logs.Count);
            Assert.AreEqual(1, vm.Show.Count);
        }

        [Test]
        public void AddDebugTest()
        {
            vm.Reset();
            vm.Add(new LogMessageDebug("Test"));
            vm.Type = LoggerEnum.AllString.ToString();

            Assert.AreEqual(1, vm.Logs.Count);
            Assert.AreEqual(1, vm.Show.Count);
        }

        [Test]
        public void ShowDebugTest()
        {
            vm.Reset();
            vm.Add(new LogMessageDebug("Test"));
            vm.Type = LoggerEnum.AllString.ToString();

            Assert.AreEqual(LoggerEnum.AllString.ToString(), vm.Type);
            Assert.AreEqual(1, vm.Logs.Count);
            Assert.AreEqual(1, vm.Show.Count);

            vm.SetActive(LoggerEnum.DebugString.ToString());

            Assert.AreEqual(LoggerEnum.DebugString.ToString(), vm.Type);
            Assert.AreEqual(2, vm.Logs.Count);
            Assert.AreEqual(2, vm.Show.Count);

            vm.SetActive(LoggerEnum.ErrorString.ToString());

            Assert.AreEqual(LoggerEnum.ErrorString.ToString(), vm.Type);
            Assert.AreEqual(3, vm.Logs.Count);
            Assert.AreEqual(0, vm.Show.Count);
        }

        [Test]
        public void MaxTest()
        {
            vm.Reset();
            Assert.AreEqual(0, vm.Logs.Count);

            for (int i = 0; i < vm.Max+10; i++)
            {
                vm.Add(new LogMessageInfo("Test"));
            }

            Assert.AreEqual(vm.Max, vm.Logs.Count);
        }
        #endregion


    }
}
