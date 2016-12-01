using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_9;

namespace Tests.Lesson_9
{
    [TestClass]
    public class MaxProfitTest
    {
        private MaxProfit _maxProfit;

        [TestInitialize]
        public void Initialize()
        {
            _maxProfit = new MaxProfit();
        }

        #region Example Tests

        [TestMethod]
        public void MaxProfit_Example_Test()
        {
            var A = new int[6];
            A[0] = 23171;
            A[1] = 21011;
            A[2] = 21123;
            A[3] = 21366;
            A[4] = 21013;
            A[5] = 21367;

            Test(A, 356);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxProfit.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
