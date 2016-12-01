using System;

namespace TrainingTasks.Lesson_10
{
    public class CountFactors
    {
        public int solution(int N)
        {
            // O(sqrt(N))

            if (N == 1) return N;

            int result = 0;

            int i = 1;

            int sqrt = (int) Math.Sqrt(N);

            while (i <= sqrt)
            {
                if (N%i == 0) result+=2;
                i++;
            }

            if (sqrt * sqrt == N) result--;

            return result;
        }
    }
}
