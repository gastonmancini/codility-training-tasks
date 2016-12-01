using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class PassingCarsTests
    {
        private PassingCars _passingCars;

        [TestInitialize]
        public void Initialize()
        {
            _passingCars = new PassingCars();
        }

        [TestMethod]
        public void PassingCars_Example_Test()
        {
            var array = new int[5];
            array[0] = 0;
            array[1] = 1;
            array[2] = 0;
            array[3] = 1;
            array[4] = 1;
            Test(array, 5);
        }

        private void Test(int[] a, int expectedResult)
        {
            var result = _passingCars.solution(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
