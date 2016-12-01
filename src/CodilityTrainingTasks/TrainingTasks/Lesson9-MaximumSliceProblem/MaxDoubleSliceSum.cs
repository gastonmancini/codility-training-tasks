using System;

namespace TrainingTasks.Lesson_9
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            // Calculate the maximum sum subarray with one element missing

            int length = A.Length;

            int[] maxStartingHere = new int[length];
            int maxSum = 0;

            // Kadane's algorithm in reverse direction.
            for (int i = length - 2; i > 0; i--)
            {
                maxSum = Math.Max(0, A[i] + maxSum);
                maxStartingHere[i] = maxSum;
            }

            int[] maxEndingHere = new int[length];
            maxSum = 0;

            // Kadane's algorithm in forward direction.
            for (int i = 1; i < length - 1; i++)
            {
                maxSum = Math.Max(0, A[i] + maxSum);
                maxEndingHere[i] = maxSum;
            }

            int maxDoubleSlice = 0;

            // Iterate arrays simultaneously and choose the 'Y' that has the maximum value of
            for (int i = 0; i < length - 2; i++)
            {
                maxDoubleSlice = Math.Max(maxDoubleSlice, maxEndingHere[i] + maxStartingHere[i + 2]);
            }
            return maxDoubleSlice;
        }
    }
}
