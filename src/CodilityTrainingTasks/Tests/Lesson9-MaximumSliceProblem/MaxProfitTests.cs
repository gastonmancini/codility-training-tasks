using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MaxProfitTests
    {
        private MaxProfit _maxProfit;

        [TestInitialize]
        public void Initialize()
        {
            _maxProfit = new MaxProfit();
        }

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

        private void Test(int[] A, int expectedResult)
        {
            var result = _maxProfit.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
