using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_5;

namespace Tests.Lesson_5
{
    [TestClass]
    public class MinAvgTwoSliceTest
    {
        private MinAvgTwoSlice _minAvgTwoSlice;

        [TestInitialize]
        public void Initialize()
        {
            _minAvgTwoSlice = new MinAvgTwoSlice();
        }

        #region Example Tests

        [TestMethod]
        public void MinAvgTwoSlice_Example_Test()
        {
            var array = new int[7];
            array[0] = 4;
            array[1] = 2;
            array[2] = 2;
            array[3] = 5;
            array[4] = 1;
            array[5] = 5;
            array[6] = 8;

            Test(array, 1);
        }

        #endregion

        #region Extremes tests
        
        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _minAvgTwoSlice.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
