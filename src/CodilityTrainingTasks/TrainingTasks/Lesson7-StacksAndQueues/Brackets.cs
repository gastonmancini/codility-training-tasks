using System.Collections.Generic;

namespace TrainingTasks
{
    public class Brackets
    {
        /// <summary>
        /// Directly iterate over the given string and use a stack to check if it is properly nested.
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(string S)
        {
            var stack = new Stack<char>();

            // Iterate the array of chars
            foreach (var c in S)
            {
                // If it is an opening char, then push it in the stack
                if (IsOpeningChar(c))
                {
                    stack.Push(c);
                }
                else
                {
                    // If we found a closing char, and there is nothing in the stack, then it is not properly nested
                    if (stack.Count == 0) return 0;

                    // If there is something to peek, get it
                    var top = stack.Pop();

                    // If the element in the stack  is not the closing one of the one we are looking for, then is not properly nested.
                    if (!IsProperlyNested(top, c)) return 0;
                }
            }

            return stack.Count == 0 ? 1 : 0; // If there is a remaining element in the stack then, it is not properly nested
        }

        private static bool IsOpeningChar(char c)
        {
            return c == '{' || c == '[' || c == '(';
        }

        private static bool IsProperlyNested(char c1, char c2)
        {
            return (c1 == '(' && c2 == ')') || (c1 == '[' && c2 == ']') || (c1 == '{' && c2 == '}');
        }

        // https://codility.com/demo/results/trainingCU8TAD-DJD/
    }
}
