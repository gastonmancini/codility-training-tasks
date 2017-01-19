using System;

namespace TrainingTasks
{
    public class MaxDoubleSliceSum
    {
        /// <summary>
        /// The solution uses Kanade's algorithm in two directions.
        /// We calculate the max contiguous sum starting at a point i and the max contiguous sum ending at point i.
        /// Finally we have to find the maximum sum of contiguousSumStartingAt[i-1] + contiguousSumEndingAt[i+1]. This is the max double slice sum.
        /// 
        /// If the numbers are all negative, then we should return zero.
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] A)
        {
            var N = A.Length;

            var contiguousSumStartingAt = new int[N];

            // Start from 1, we can discard A[0] since by definition they can't be part of any double-slice sum.
            // End at size of A - 2 to leave place to the other indexes
            for (int i = 1; i <= N - 2; i++)
            {
                // A higher sum can always be found by dropping any negative-sum prefix
                contiguousSumStartingAt[i] = Math.Max(contiguousSumStartingAt[i - 1] + A[i], 0);
            }

            var contiguousSumEndingAt = new int[N];

            // Start from size of A - 2 sice by definition A[N-1] is not part of any double-slice sum
            // End at 1 so we discard A[0]
            for (int i = N - 2; i >= 1; i--)
            {
                contiguousSumEndingAt[i] = Math.Max(contiguousSumEndingAt[i + 1] + A[i], 0);
            }

            int maxDoubleSliceSum = 0;

            // Then, we iterate over i, and find the maximum sum of contiguousSumStartingAt[i-1] + contiguousSumEndingAt[i+1]. This is the max double slice sum.
            for (int i = 1; i < N - 1; i++)
            {
                var currentSum = contiguousSumStartingAt[i - 1] + contiguousSumEndingAt[i + 1];
                if (maxDoubleSliceSum < currentSum) maxDoubleSliceSum = currentSum;
            }

            return maxDoubleSliceSum;
        }

        // https://codility.com/demo/results/trainingNYH4QU-TWS/
    }
}
