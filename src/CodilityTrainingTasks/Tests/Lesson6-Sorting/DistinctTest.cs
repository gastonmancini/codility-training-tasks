using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_6;

namespace Tests.Lesson_6
{
    [TestClass]
    public class DistinctTest
    {
        private Distinct _distinct;

        [TestInitialize]
        public void Initialize()
        {
            _distinct = new Distinct();
        }

        #region Example Tests

        [TestMethod]
        public void Distinct_Example_Test()
        {
            var array = new int[6];
            array[0] = 2;
            array[1] = 1;
            array[2] = 1;
            array[3] = 2;
            array[4] = 3;
            array[5] = 1;
            Test(array, 3);
        }

        #endregion

        #region Extremes tests
        
        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _distinct.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
