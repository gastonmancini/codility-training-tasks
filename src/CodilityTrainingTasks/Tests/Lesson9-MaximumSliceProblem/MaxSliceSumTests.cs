using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MaxSliceSumTests
    {
        private MaxSliceSum _maxSliceSum;

        [TestInitialize]
        public void Initialize()
        {
            _maxSliceSum = new MaxSliceSum();
        }

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

            Test(A, 16);
        }

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxSliceSum.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
