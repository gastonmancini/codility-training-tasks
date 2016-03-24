using System;

namespace TrainingTasks.Lesson_5
{
    public class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            return (int)(Math.Floor((double)B / K) - Math.Floor((double)(A - 1) / K));
        }

        //private int ON(int A, int B, int K)
        //{
        //    // O(N)

        //    int count = 0;

        //    for (int i = A; i <= B; i++)
        //    {
        //        if (i % K == 0) count++;
        //    }

        //    return count;
        //}
    }
}
