using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class FlagsTests
    {
        private Flags _flags;

        [TestInitialize]
        public void Initialize()
        {
            _flags = new Flags();
        }

        [TestMethod]
        public void Flags_Example_Test()
        {
            var array = new int[12];
            array[0] = 1;
            array[1] = 5;
            array[2] = 3;
            array[3] = 4;
            array[4] = 3;
            array[5] = 4;
            array[6] = 1;
            array[7] = 2;
            array[8] = 3;
            array[9] = 4;
            array[10] = 6;
            array[11] = 2;

            Test(array, 3);
        }

        private void Test(int[] N, int expectedResult)
        {
            var result = _flags.solution(N);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
