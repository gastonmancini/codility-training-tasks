using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class FrogJmpTests
    {
        private FrogJmp _frogJmp;

        [TestInitialize]
        public void Initialize()
        {
            _frogJmp = new FrogJmp();
        }

        [TestMethod]
        public void FrogJmp_Example_Test()
        {
            Test(10, 85, 30, 3);
        }

        private void Test(int x, int y, int d, int expectedResult)
        {
            var result = _frogJmp.solution(x, y, d);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
