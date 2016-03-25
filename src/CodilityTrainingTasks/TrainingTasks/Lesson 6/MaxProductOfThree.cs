using System;

namespace TrainingTasks.Lesson_6
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);

            return Math.Max(
                A[0] * A[1] * A[2],
                A[0] * A[A.Length - 1] * A[A.Length - 2]);
        }
    }
}
