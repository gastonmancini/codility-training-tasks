using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MaxDoubleSliceSumTests
    {
        private MaxDoubleSliceSum _maxDoubleSliceSum;

        [TestInitialize]
        public void Initialize()
        {
            _maxDoubleSliceSum = new MaxDoubleSliceSum();
        }

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

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxDoubleSliceSum.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
