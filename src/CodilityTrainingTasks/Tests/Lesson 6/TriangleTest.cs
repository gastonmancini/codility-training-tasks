using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_6;

namespace Tests.Lesson_6
{
    [TestClass]
    public class TriangleTest
    {
        private Triangle _triangle;

        [TestInitialize]
        public void Initialize()
        {
            _triangle = new Triangle();
        }

        #region Example Tests

        [TestMethod]
        public void Distinct_Example_Test_Exist_Triangular_Triplet()
        {
            var array = new int[6];
            array[0] = 10;
            array[1] = 2;
            array[2] = 5;
            array[3] = 1;
            array[4] = 8;
            array[5] = 20;
            Test(array, 1);
        }

        [TestMethod]
        public void Distinct_Example_Test_Not_Exist_Triangular_Triplet()
        {
            var array = new int[4];
            array[0] = 10;
            array[1] = 50;
            array[2] = 5;
            array[3] = 1;
            Test(array, 0);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _triangle.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
