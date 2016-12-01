using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_9;

namespace Tests.Lesson_9
{
    [TestClass]
    public class MaxDoubleSliceSumTest
    {
        private MaxDoubleSliceSum _maxDoubleSliceSum;

        [TestInitialize]
        public void Initialize()
        {
            _maxDoubleSliceSum = new MaxDoubleSliceSum();
        }

        #region Example Tests

        [TestMethod]
        public void MaxDoubleSliceSum_Example_Test()
        {
            var A = new int[8];
            A[0] = 3;
            A[1] = 2;
            A[2] = 6;
            A[3] = -1;
            A[4] = 4;
            A[5] = 5;
            A[6] = -1;
            A[7] = 2;

            Test(A, 17);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxDoubleSliceSum.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
