using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class MinPerimeterRectangleTests
    {
        private MinPerimeterRectangle _minPerimeterRectangle;

        [TestInitialize]
        public void Initialize()
        {
            _minPerimeterRectangle = new MinPerimeterRectangle();
        }

        [TestMethod]
        public void MinPerimeterRectangle_Example_Test()
        {
            Test(30, 22);
        }

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

        private void Test(int N, int expectedResult)
        {
            var result = _minPerimeterRectangle.solution(N);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
