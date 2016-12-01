using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_1;

namespace Tests.Lesson_1
{
    [TestClass]
    public class BinaryGapTest
    {
        private BinaryGap _binaryGap;

        [TestInitialize]
        public void Initialize()
        {
            _binaryGap = new BinaryGap();
        }

        #region Example Tests

        [TestMethod]
        public void BinaryGap_Number_9_Should_Return_2()
        {
            // The number 9 has binary representation 1001 and contains a binary gap of length 2.
            TestNumber(9, 2);
        }

        [TestMethod]
        public void BinaryGap_Number_529_Should_Return_4()
        {
            // The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
            TestNumber(529, 4);
        }

        [TestMethod]
        public void BinaryGap_Number_20_Should_Return_1()
        {
            // The number 20 has binary representation 10100 and contains one binary gap of length 1.
            TestNumber(20, 1);
        }

        [TestMethod]
        public void BinaryGap_Number_15_Should_Return_0()
        {
            // The number 15 has binary representation 1111 and has no binary gaps.
            TestNumber(15, 0);
        }

        [TestMethod]
        public void BinaryGap_Number_1041_Should_Return_5()
        {
            // For the number 1041 should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.
            TestNumber(15, 0);
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void BinaryGap_Number_1_Should_Return_0()
        {
            TestNumber(1, 0);
        }

        [TestMethod]
        public void BinaryGap_Number_2147483647_Should_Return_0()
        {
            TestNumber(2147483647, 0);
        }
        
        #endregion

        private void TestNumber(int number, int expectedResult)
        {
            var result = _binaryGap.solution(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
