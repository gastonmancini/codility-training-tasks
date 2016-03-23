using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_3;

namespace Tests.Lesson_3
{
    [TestClass]
    public class TapeEquilibriumTest
    {
        private TapeEquilibrium _tapeEquilibrium;

        [TestInitialize]
        public void Initialize()
        {
            _tapeEquilibrium = new TapeEquilibrium();
        }

        #region Example Tests

        [TestMethod]
        public void TapeEquilibrium_Example_Test()
        {
            Test(new[] { 3, 1, 2, 4, 3 }, 1);
        }

        #endregion

        #region Extremes tests
        
        [TestMethod]
        public void TapeEquilibrium_Huge_Array_With_Highest_Values()
        {
            int size = 100000;

            var hugeArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                hugeArray[i] = 1000;
            }

            Test(hugeArray, 0);
        }

        [TestMethod]
        public void TapeEquilibrium_Small_Array_With_Smallest_Values()
        {
            var smallArray = new[] { -1000, -1000 };
            
            Test(smallArray, 0);
        }

        #endregion

        private void Test(int[] array, int expectedResult)
        {
            var result = _tapeEquilibrium.solution(array);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
