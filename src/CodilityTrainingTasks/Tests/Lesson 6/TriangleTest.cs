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
        public void Triangle_Example_Test_Exist_Triangular_Triplet()
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
        public void Triangle_Example_Test_Not_Exist_Triangular_Triplet()
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

        [TestMethod]
        public void Triangle_Extreme_Test_Arith_Overflow()
        {
            var array = new int[3];
            array[0] = int.MaxValue;
            array[1] = int.MaxValue;
            array[2] = int.MaxValue;
            Test(array, 1);
        }

        #endregion

        private void Test(int[] A, int expectedResult)
        {
            var result = _triangle.solution(A);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
