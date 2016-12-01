using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_4;

namespace Tests.Lesson_4
{
    [TestClass]
    public class FrogRiverOneTest
    {
        private FrogRiverOne _frogRiverOne;

        [TestInitialize]
        public void Initialize()
        {
            _frogRiverOne = new FrogRiverOne();
        }

        #region Example Tests

        [TestMethod]
        public void FrogRiverOne_Example_Test()
        {
            var array = new int[8];
            array[0] = 1;
            array[1] = 3;
            array[2] = 1;
            array[3] = 4;
            array[4] = 2;
            array[5] = 3;
            array[6] = 5;
            array[7] = 4;
            Test(5, array, 6);
        }

        [TestMethod]
        public void FrogRiverOne_Example_Test_2()
        {
            var array = new int[7];
            array[0] = 1;
            array[1] = 3;
            array[2] = 1;
            array[3] = 3;
            array[4] = 2;
            array[5] = 1;
            array[6] = 3;
            Test(3, array, 4);
        }

        #endregion

        #region Extremes tests


        [TestMethod]
        public void FrogRiverOne_Array_With_Single_Element()
        {
            var array = new[] {5};
            Test(5, array, -1);
        }

        [TestMethod]
        public void FrogRiverOne_Never_Cross_The_River()
        {
            var array = new int[8];
            array[0] = 1;
            array[1] = 3;
            array[2] = 1;
            array[3] = 4;
            array[4] = 2;
            array[5] = 3;
            array[6] = 6;
            array[7] = 4;
            Test(6, array, -1);
        }

        #endregion

        private void Test(int x, int[] a, int expectedResult)
        {
            var result = _frogRiverOne.solution(x, a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
