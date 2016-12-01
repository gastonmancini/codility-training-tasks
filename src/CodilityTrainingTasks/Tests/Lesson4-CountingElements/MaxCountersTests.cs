using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MaxCountersTests
    {
        private MaxCounters _maxCounters;

        [TestInitialize]
        public void Initialize()
        {
            _maxCounters = new MaxCounters();
        }

        [TestMethod]
        public void MaxCounters_Example_Test()
        {
            var array = new int[7];
            array[0] = 3;
            array[1] = 4;
            array[2] = 4;
            array[3] = 6;
            array[4] = 1;
            array[5] = 4;
            array[6] = 4;

            int N = 5;

            var expectedResult = new int[N];
            expectedResult[0] = 3;
            expectedResult[1] = 2;
            expectedResult[2] = 2;
            expectedResult[3] = 4;
            expectedResult[4] = 2;

            Test(N, array, expectedResult);
        }

        private void Test(int N, int[] a, int[] expectedResult)
        {
            var result = _maxCounters.solution(N, a);

            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}
