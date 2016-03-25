using System;

namespace TrainingTasks.Lesson_7
{
    public class Nesting
    {
        public int solution(string S)
        {
            if (string.IsNullOrEmpty(S)) return 1;

            var count = 0;
            
            foreach (char current in S)
            {
                if (AreEqual(current, "("))
                {
                    count++;
                }
                else if (AreEqual(current, ")"))
                {
                    count--;
                }

                if (count < 0) return 0;
            }

            return count == 0 ? 1 : 0;
        }

        private static bool AreEqual(char c, string s)
        {
            return c == Convert.ToChar(s);
        }
    }
}
