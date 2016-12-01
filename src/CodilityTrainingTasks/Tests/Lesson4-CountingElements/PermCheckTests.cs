using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class PermCheckTests
    {
        private PermCheck _permCheck;

        [TestInitialize]
        public void Initialize()
        {
            _permCheck = new PermCheck();
        }

        [TestMethod]
        public void PermCheck_Example_Test_Is_A_Permutation()
        {
            var array = new int[4];
            array[0] = 4;
            array[1] = 1;
            array[2] = 3;
            array[3] = 2;
            Test(array, 1);
        }

        [TestMethod]
        public void PermCheck_Example_Test_Is_Not_A_Permutation()
        {
            var array = new int[3];
            array[0] = 4;
            array[1] = 1;
            array[2] = 3;
            Test(array, 0);
        }

        private void Test(int[] a, int expectedResult)
        {
            var result = _permCheck.solution(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
