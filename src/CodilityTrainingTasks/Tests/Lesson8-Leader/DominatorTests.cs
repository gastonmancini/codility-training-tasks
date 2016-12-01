using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class DominatorTests
    {
        private Dominator _dominator;

        [TestInitialize]
        public void Initialize()
        {
            _dominator = new Dominator();
        }

        [TestMethod]
        public void Dominator_Example_Test()
        {
            var A = new int[8];
            A[0] = 3;
            A[1] = 4;
            A[2] = 3;
            A[3] = 2;
            A[4] = 3;
            A[5] = -1;
            A[6] = 3;
            A[7] = 3;

            Test(A, 7);
        }

        private void Test(int[] A, int expectedResult)
        {
            var result = _dominator.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
