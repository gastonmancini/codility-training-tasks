using System;

namespace TrainingTasks.Lesson_9
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            int maxSum = 0;
            int maxSliceSum = int.MinValue;

            // Kadane's algorithm
            for (int i = 0; i < A.Length; i++)
            {
                maxSum = Math.Max(int.MinValue, A[i] + maxSum);
                if (A[i] > maxSum) maxSum = A[i];

                maxSliceSum = Math.Max(maxSliceSum, maxSum);
            }
            
            return maxSliceSum;
        }
    }
}
