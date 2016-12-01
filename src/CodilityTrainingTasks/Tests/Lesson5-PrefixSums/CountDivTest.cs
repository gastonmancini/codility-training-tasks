using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_5;

namespace Tests.Lesson_5
{
    [TestClass]
    public class CountDivTest
    {
        private CountDiv _countDiv;

        [TestInitialize]
        public void Initialize()
        {
            _countDiv = new CountDiv();
        }

        #region Example Tests

        [TestMethod]
        public void CountDiv_Example_Test()
        {
            Test(6, 11, 2, 3);
        }

        #endregion

        #region Extremes tests
        
        // TODO

        #endregion

        private void Test(int A, int B, int K, int expectedResult)
        {
            var result = _countDiv.solution(A, B, K);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
