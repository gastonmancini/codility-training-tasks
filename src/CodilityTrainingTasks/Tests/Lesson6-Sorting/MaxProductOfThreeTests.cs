using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MaxProductOfThreeTests
    {
        private MaxProductOfThree _maxProductOfThree;

        [TestInitialize]
        public void Initialize()
        {
            _maxProductOfThree = new MaxProductOfThree();
        }

        [TestMethod]
        public void MaxProductOfThree_Example_Test()
        {
            var array = new int[6];
            array[0] = -3;
            array[1] = 1;
            array[2] = 2;
            array[3] = -2;
            array[4] = 5;
            array[5] = 6;
            Test(array, 60);
        }

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxProductOfThree.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
