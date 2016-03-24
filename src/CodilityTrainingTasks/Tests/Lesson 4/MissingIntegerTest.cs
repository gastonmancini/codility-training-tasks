using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_4;

namespace Tests.Lesson_4
{
    [TestClass]
    public class MissingIntegerTest
    {
        private MissingInteger _missingInteger;

        [TestInitialize]
        public void Initialize()
        {
            _missingInteger = new MissingInteger();
        }

        #region Example Tests

        [TestMethod]
        public void MissingInteger_Example_Test()
        {
            var array = new int[6];
            array[0] = 1;
            array[1] = 3;
            array[2] = 6;
            array[3] = 4;
            array[4] = 1;
            array[5] = 2;
            Test(array, 5);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[] a, int expectedResult)
        {
            var result = _missingInteger.solution(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
