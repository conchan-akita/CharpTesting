using System;
using CalculationProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mwvm = new MainWindowViewModel();
            mwvm.X = 1;
            mwvm.Y = 2;
            var addCommand = new AddCommand(mwvm);
            addCommand.Execute(this);
            Assert.AreEqual(3, mwvm.Z);
        }
    }
}
