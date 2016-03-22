using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_3;

namespace Tests.Lesson_3
{
    [TestClass]
    public class FrogJmpTest
    {
        private FrogJmp _frogJmp;

        [TestInitialize]
        public void Initialize()
        {
            _frogJmp = new FrogJmp();
        }

        #region Example Tests

        [TestMethod]
        public void FrogJmp_Example_Test()
        {
            Test(10, 85, 30, 3);
        }

        #endregion

        #region Extremes tests

        // TODO Test correctness and extremes
        
        #endregion

        private void Test(int x, int y, int d, int expectedResult)
        {
            var result = _frogJmp.solution(x, y, d);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
