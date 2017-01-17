using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class StoneWallTests
    {
        private StoneWall _stoneWall;

        [TestInitialize]
        public void Initialize()
        {
            _stoneWall = new StoneWall();
        }

        [TestMethod]
        public void StoneWall_Example_Test()
        {
            var array = new int[9];
            array[0] = 8;
            array[1] = 8;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;
            array[5] = 8;
            array[6] = 7;
            array[7] = 4;
            array[8] = 8;

            Test(array, 7);
        }
        
        private void Test(int[] H, int expectedResult)
        {
            var result = _stoneWall.solution(H);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
