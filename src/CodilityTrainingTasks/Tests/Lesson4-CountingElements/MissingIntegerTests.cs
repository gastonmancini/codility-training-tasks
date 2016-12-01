using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MissingIntegerTests
    {
        private MissingInteger _missingInteger;

        [TestInitialize]
        public void Initialize()
        {
            _missingInteger = new MissingInteger();
        }

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

        private void Test(int[] a, int expectedResult)
        {
            var result = _missingInteger.solution(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
