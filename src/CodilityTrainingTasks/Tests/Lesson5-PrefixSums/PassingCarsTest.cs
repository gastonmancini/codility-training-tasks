using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_5;

namespace Tests.Lesson_5
{
    [TestClass]
    public class PassingCarsTest
    {
        private PassingCars _passingCars;

        [TestInitialize]
        public void Initialize()
        {
            _passingCars = new PassingCars();
        }

        #region Example Tests

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

        #endregion

        #region Extremes tests


        // TODO

        #endregion

        private void Test(int[] a, int expectedResult)
        {
            var result = _passingCars.solution(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
