using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks.Lesson_7
{
    public class Brackets
    {
        public int solution(string S)
        {
            if (string.IsNullOrEmpty(S)) return 1;

            var charArray = S.ToCharArray();
            var stack = new Stack<char>();

            foreach (char current in charArray)
            {
                if (!stack.Any())
                {
                    stack.Push(current);
                    continue;
                }

                var previous = stack.Peek();

                if (AreEqual(previous, "(") && AreEqual(current, ")")
                    || AreEqual(previous, "[") && AreEqual(current, "]")
                    || AreEqual(previous, "{") && AreEqual(current, "}"))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(current);
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }

        private static bool AreEqual(char c, string s)
        {
            return c == Convert.ToChar(s);
        }
    }
}
