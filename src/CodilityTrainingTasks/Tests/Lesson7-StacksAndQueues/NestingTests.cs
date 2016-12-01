using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks;

namespace Tests
{
    [TestClass]
    public class NestingTests
    {
        private Nesting _nesting;

        [TestInitialize]
        public void Initialize()
        {
            _nesting = new Nesting();
        }
        
        [TestMethod]
        public void Nesting_Example_Test_Properly_Nested()
        {
            var s = "(()(())())";
       
            Test(s, 1);
        }

        [TestMethod]
        public void Nesting_Example_Test_Not_Properly_Nested()
        {
            var s = "())";

            Test(s, 0);
        }

        [TestMethod]
        public void Nesting_Test_Empty_String()
        {
            var s = string.Empty;

            Test(s, 1);
        }

        [TestMethod]
        public void Nesting_Test_Complex_String_Is_Properly_Nested()
        {
            var s = "((((()))))()(())((()))(((((((((())))))))))((((()))))()(())((()))(((((((((())))))))))";

            Test(s, 1);
        }

        [TestMethod]
        public void Nesting_Test_Complex_String_Is_Not_Properly_Nested()
        {
            var s = "((((()))))()(())((()))(((((((((())))))))))((((()))))((())((()))(((((((((())))))))))";

            Test(s, 0);
        }

        private void Test(string S, int expectedResult)
        {
            var result = _nesting.solution(S);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
