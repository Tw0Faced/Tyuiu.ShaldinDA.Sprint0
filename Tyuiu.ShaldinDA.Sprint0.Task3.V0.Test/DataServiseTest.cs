using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShaldinDA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.ShaldinDA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataServise.Sum(5, 5));
        }
    }
}