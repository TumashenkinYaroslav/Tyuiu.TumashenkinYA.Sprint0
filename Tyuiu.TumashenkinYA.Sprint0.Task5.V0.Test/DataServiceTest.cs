﻿using Tyuiu.TumashenkinYA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.TumashenkinYA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }

        
    }
}
