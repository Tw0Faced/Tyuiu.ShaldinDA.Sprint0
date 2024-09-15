using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShaldinDA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShaldinDA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]

        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataServise.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubrationValid()
        {
            Assert.AreEqual(5, DataServise.Subtraction(10, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataServise.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataServise.Division(9, 3));
        }
    }
}