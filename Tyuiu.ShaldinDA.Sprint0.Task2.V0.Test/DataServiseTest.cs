using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaldinDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShaldinDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Данил";
            var res = DataServise.GetMessage(name);
            Assert.AreEqual("Привет, Данил", res);
        }
    }
}