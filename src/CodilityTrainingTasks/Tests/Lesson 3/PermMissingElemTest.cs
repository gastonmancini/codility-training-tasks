using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_3;

namespace Tests.Lesson_3
{
    [TestClass]
    public class PermMissingElemTest
    {
        private PermMissingElem _permMissingElem;

        [TestInitialize]
        public void Initialize()
        {
            _permMissingElem = new PermMissingElem();
        }

        #region Example Tests

        [TestMethod]
        public void PermMissingElem_Example_Test()
        {
            Test(new[] { 2, 3, 1, 5 }, 4);
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void PermMissingElem_Huge_Array()
        {
            int size = 100000;

            int missingNumber = 1000;

            var hugeArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (i >= missingNumber - 1)
                {
                    hugeArray[i] = i + 2;
                }
                else
                {
                    hugeArray[i] = i + 1;
                }
            }

            Test(hugeArray, missingNumber);
        }

        [TestMethod]
        public void PermMissingElem_Small_Array()
        {
            var smallArray = new[] { 1, 3 };

            Test(smallArray, 2);
        }

        [TestMethod]
        public void PermMissingElem_Empty_Array()
        {
            var emptyArray = new int[0];

            Test(emptyArray, 1);
        }

        [TestMethod]
        public void PermMissingElem_Single_Element_Array()
        {
            var singleElementArray = new [] { 2 };

            Test(singleElementArray, 1);
        }

        [TestMethod]
        public void PermMissingElem_Missing_First_Element()
        {
            var array = new [] { 2, 3, 4 };

            Test(array, 1);
        }

        [TestMethod]
        public void PermMissingElem_Missing_Last_Element()
        {
            var array = new[] { 1, 2, 3 };

            Test(array, 4);
        }

        #endregion

        private void Test(int[] array, int expectedResult)
        {
            var result = _permMissingElem.solution(array);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
