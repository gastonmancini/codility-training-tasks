using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_7;

namespace Tests.Lesson_7
{
    [TestClass]
    public class DistinctTest
    {
        private Fish _fish;

        [TestInitialize]
        public void Initialize()
        {
            _fish = new Fish();
        }

        #region Example Tests

        [TestMethod]
        public void Distinct_Example_Test()
        {
            var A = new int[5];
            A[0] = 4;
            A[1] = 3;
            A[2] = 2;
            A[3] = 1;
            A[4] = 5;

            var B = new int[5];
            B[0] = 0;
            B[1] = 1;
            B[2] = 0;
            B[3] = 0;
            B[4] = 0;

            Test(A, B, 2);
        }

        #endregion

        #region Extremes tests
        
        // TODO

        #endregion

        private void Test(int[] A, int[] B, int expectedResult)
        {
            var result = _fish.solution(A, B);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
