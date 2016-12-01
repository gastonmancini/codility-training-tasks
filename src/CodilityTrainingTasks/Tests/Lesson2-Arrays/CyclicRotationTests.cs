using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class CyclicRotationTests
    {
        private CyclicRotation _cyclicRotation;

        [TestInitialize]
        public void Initialize()
        {
            _cyclicRotation = new CyclicRotation();
        }

        [TestMethod]
        public void CyclicRotation_Rotate_38976_Three_Times_Is_97638()
        {
            // Given array A = [3, 8, 9, 7, 6] and K = 3, the function should return [9, 7, 6, 3, 8].
            Test(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 });
        }

        [TestMethod]
        public void CyclicRotation_Rotate_38976_Zero_Times_Is_38976()
        {
            Test(new[] { 3, 8, 9, 7, 6 }, 0, new[] { 3, 8, 9, 7, 6 });
        }

        private void Test(int[] array, int times, int[] expectedResult)
        {
            var result = _cyclicRotation.solution(array, times);
            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }
    }
}
