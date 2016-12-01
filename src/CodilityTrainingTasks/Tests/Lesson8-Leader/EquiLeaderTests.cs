using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class EquiLeaderTests
    {
        private EquiLeader _equiLeader;

        [TestInitialize]
        public void Initialize()
        {
            _equiLeader = new EquiLeader();
        }

        [TestMethod]
        public void EquiLeader_Example_Test()
        {
            var A = new int[6];
            A[0] = 4;
            A[1] = 3;
            A[2] = 4;
            A[3] = 4;
            A[4] = 4;
            A[5] = 2;

            Test(A, 2);
        }

        private void Test(int[] A, int expectedResult)
        {
            var result = _equiLeader.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
