using Tyuiu.TumashenkinYA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.TumashenkinYA.Sprint0.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicatonValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
