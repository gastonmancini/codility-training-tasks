using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class CountDivTests
    {
        private CountDiv _countDiv;

        [TestInitialize]
        public void Initialize()
        {
            _countDiv = new CountDiv();
        }

        [TestMethod]
        public void CountDiv_Example_Test()
        {
            Test(6, 11, 2, 3);
        }

        private void Test(int A, int B, int K, int expectedResult)
        {
            var result = _countDiv.solution(A, B, K);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
