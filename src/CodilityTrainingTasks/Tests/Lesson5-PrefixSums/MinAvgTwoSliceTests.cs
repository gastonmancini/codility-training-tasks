using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MinAvgTwoSliceTests
    {
        private MinAvgTwoSlice _minAvgTwoSlice;

        [TestInitialize]
        public void Initialize()
        {
            _minAvgTwoSlice = new MinAvgTwoSlice();
        }

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

        private void Test(int[] A, int expectedResult)
        {
            var result = _minAvgTwoSlice.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
