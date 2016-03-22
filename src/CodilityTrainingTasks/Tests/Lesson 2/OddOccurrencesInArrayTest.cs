using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_2;

namespace Tests.Lesson_2
{
    [TestClass]
    public class OddOccurrencesInArrayTest
    {
        private OddOccurrencesInArray _oddOccurrencesInArray;

        [TestInitialize]
        public void Initialize()
        {
            _oddOccurrencesInArray = new OddOccurrencesInArray();
        }

        #region Example Tests

        [TestMethod]
        public void OddOccurrencesInArray_ExampleTest()
        {
            // A[0] = 9  A[1] = 3  A[2] = 9
            // A[3] = 3  A[4] = 9  A[5] = 7
            // A[6] = 9
            // the function should return 7

            Test(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7);
        }

        #endregion

        #region Extremes tests

        // TODO Test correctness and extremes
        
        #endregion

        private void Test(int[] array, int expectedResult)
        {
            var result = _oddOccurrencesInArray.solution(array);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
