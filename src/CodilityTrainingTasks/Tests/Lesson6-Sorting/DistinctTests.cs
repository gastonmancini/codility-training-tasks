using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class DistinctTests
    {
        private Distinct _distinct;

        [TestInitialize]
        public void Initialize()
        {
            _distinct = new Distinct();
        }

        [TestMethod]
        public void Distinct_Example_Test()
        {
            var array = new int[6];
            array[0] = 2;
            array[1] = 1;
            array[2] = 1;
            array[3] = 2;
            array[4] = 3;
            array[5] = 1;
            Test(array, 3);
        }

        private void Test(int[] A, int expectedResult)
        {
            var result = _distinct.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
