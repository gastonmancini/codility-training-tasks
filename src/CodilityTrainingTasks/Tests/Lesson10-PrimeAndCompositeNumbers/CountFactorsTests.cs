using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class CountFactorsTests
    {
        private CountFactors _countFactors;

        [TestInitialize]
        public void Initialize()
        {
            _countFactors = new CountFactors();
        }

        [TestMethod]
        public void CountFactors_Example_Test()
        {
            Test(24, 8);
        }

        [TestMethod]
        public void CountFactors_One()
        {
            Test(1, 1);
        }

        [TestMethod]
        public void CountFactors_Two()
        {
            Test(2, 2);
        }

        [TestMethod]
        public void CountFactors_Three()
        {
            Test(3, 2);
        }

        [TestMethod]
        public void CountFactors_Max_Int()
        {
            Test(int.MaxValue, 2);
        }

        private void Test(int N, int expectedResult)
        {
            var result = _countFactors.solution(N);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
