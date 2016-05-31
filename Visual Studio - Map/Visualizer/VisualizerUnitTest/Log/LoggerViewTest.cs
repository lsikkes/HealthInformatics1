using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizerUnitTest.Log
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Visualizer;
    using Visualizer.Log;

    [TestFixture, Apartment(ApartmentState.STA)]
    class LoggerViewTest
    {
        #region Fields

        private MainWindow main;
        private LoggerView view;
        private LoggerViewModel viewmodel;

        #endregion Fields

        #region Methods

        [SetUp]
        public void SetUp()
        {
            main = new MainWindow();
            view = LoggerView.Instance();
            viewmodel = (LoggerViewModel)view.DataContext;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.IsNotNull(main);
            Assert.IsNotNull(view);
            Assert.IsNotNull(viewmodel);
        }

        [Test]
        public void ShowAllTest()
        {
            view.ButtonShowAll(null, null);
            Assert.AreEqual(LoggerEnum.AllString.ToString(), viewmodel.Type);
        }

        [Test]
        public void ShowDebugTest()
        {
            view.ButtonShowDebug(null, null);
            Assert.AreEqual(LoggerEnum.DebugString.ToString(), viewmodel.Type);
        }

        [Test]
        public void ShowErrorTest()
        {
            view.ButtonShowError(null, null);
            Assert.AreEqual(LoggerEnum.ErrorString.ToString(), viewmodel.Type);
        }

        [Test]
        public void ShowInfoTest()
        {
            view.ButtonShowInfo(null, null);
            Assert.AreEqual(LoggerEnum.InfoString.ToString(), viewmodel.Type);
        }

        [Test]
        public void ShowWarningTest()
        {
            view.ButtonShowWarning(null, null);
            Assert.AreEqual(LoggerEnum.WarningString.ToString(), viewmodel.Type);
        }

        [Test]
        public void ResetTest()
        {
            view.ButtonShowInfo(null, null);
            view.ButtonShowError(null, null);
            Assert.AreNotEqual(1, viewmodel.Logs.Count);
            view.ButtonReset(null, null);
            Assert.AreEqual(1, viewmodel.Logs.Count);
        }

        #endregion
    }
}
