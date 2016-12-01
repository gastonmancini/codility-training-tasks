using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_10;

namespace Tests.Lesson_10
{
    [TestClass]
    public class CountFactorsTest
    {
        private CountFactors _countFactors;

        [TestInitialize]
        public void Initialize()
        {
            _countFactors = new CountFactors();
        }

        #region Example Tests

        [TestMethod]
        public void CountFactors_Example_Test()
        {
            Test(24, 8);
        }

        #endregion

        #region Extremes tests

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

        #endregion

        private void Test(int N, int expectedResult)
        {
            var result = _countFactors.solution(N);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
