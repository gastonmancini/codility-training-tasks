using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_10;

namespace Tests.Lesson_10
{
    [TestClass]
    public class MinPerimeterRectangleTest
    {
        private MinPerimeterRectangle _minPerimeterRectangle;

        [TestInitialize]
        public void Initialize()
        {
            _minPerimeterRectangle = new MinPerimeterRectangle();
        }

        #region Example Tests

        [TestMethod]
        public void MinPerimeterRectangle_Example_Test()
        {
            Test(30, 22);
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void MinPerimeterRectangle_One()
        {
            Test(1, 4);
        }

        [TestMethod]
        public void MinPerimeterRectangle_Max()
        {
            Test(1000000000, 126500);
        }

        #endregion

        private void Test(int N, int expectedResult)
        {
            var result = _minPerimeterRectangle.solution(N);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
