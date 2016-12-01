using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_2;

namespace Tests.Lesson_2
{
    [TestClass]
    public class CyclicRotationTest
    {
        private CyclicRotation _cyclicRotation;

        [TestInitialize]
        public void Initialize()
        {
            _cyclicRotation = new CyclicRotation();
        }

        #region Example Tests

        [TestMethod]
        public void CyclicRotation_Rotate_38976_Three_Times_Is_97638()
        {
            // Given array A = [3, 8, 9, 7, 6] and K = 3, the function should return [9, 7, 6, 3, 8].
            Test(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 });
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void CyclicRotation_Rotate_38976_Zero_Times_Is_38976()
        {
            Test(new[] { 3, 8, 9, 7, 6 }, 0, new[] { 3, 8, 9, 7, 6 });
        }

        // TODO Test correctness
        
        #endregion

        private void Test(int[] array, int times, int[] expectedResult)
        {
            var result = _cyclicRotation.solution(array, times);
            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }
    }
}
