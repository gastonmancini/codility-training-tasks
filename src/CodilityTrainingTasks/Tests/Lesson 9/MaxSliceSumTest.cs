using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_9;

namespace Tests.Lesson_9
{
    [TestClass]
    public class MaxSliceSumTest
    {
        private MaxSliceSum _maxSliceSum;

        [TestInitialize]
        public void Initialize()
        {
            _maxSliceSum = new MaxSliceSum();
        }

        #region Example Tests

        [TestMethod]
        public void MaxSliceSum_Example_Test()
        {
            var A = new int[5];
            A[0] = 3;
            A[1] = 2;
            A[2] = -6;
            A[3] = -4;
            A[4] = 0;

            Test(A, 5);
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void MaxSliceSum_One_Elem_Array()
        {
            var A = new int[1];
            A[0] = 3;

            Test(A, 3);
        }

        [TestMethod]
        public void MaxSliceSum_a()
        {
            var A = new int[5];
            A[0] = 3;
            A[1] = 2;
            A[2] = -6;
            A[3] = -4;
            A[4] = 16;

            Test(A, 6);
        }

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxSliceSum.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
