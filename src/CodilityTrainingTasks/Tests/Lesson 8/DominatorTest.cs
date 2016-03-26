using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_8;

namespace Tests.Lesson_8
{
    [TestClass]
    public class DominatorTest
    {
        private Dominator _dominator;

        [TestInitialize]
        public void Initialize()
        {
            _dominator = new Dominator();
        }

        #region Example Tests

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

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _dominator.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
