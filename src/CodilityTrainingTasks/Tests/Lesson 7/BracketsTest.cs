﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingTasks.Lesson_7;

namespace Tests.Lesson_7
{
    [TestClass]
    public class BracketsTest
    {
        private Brackets _brackets;

        [TestInitialize]
        public void Initialize()
        {
            _brackets = new Brackets();
        }

        #region Example Tests

        [TestMethod]
        public void Brackets_Example_Test_Properly_Nested()
        {
            var s = "{[()()]}";
       
            Test(s, 1);
        }

        [TestMethod]
        public void Brackets_Example_Test_Not_Properly_Nested()
        {
            var s = "([)()]";

            Test(s, 0);
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void Brackets_Test_Empty_String()
        {
            var s = string.Empty;

            Test(s, 1);
        }

        [TestMethod]
        public void Brackets_Test_Complex_String_Is_Properly_Nested()
        {
            var s = "[[[{{{((()))}}}]]][[[{{{((()))}}}]]][[[{{{((()))}}}]]][[[{{{}}}]]][[[]]][](){}";

            Test(s, 1);
        }

        [TestMethod]
        public void Brackets_Test_Complex_String_Is_Not_Properly_Nested()
        {
            var s = "[[[{{{((()))}}]]][[[{{{((()))}}}]]][[[{{{((()))}}}]]][[[{{{}}}]]][[[]]][](){}";

            Test(s, 0);
        }

        #endregion

        private void Test(string S, int expectedResult)
        {
            var result = _brackets.solution(S);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
