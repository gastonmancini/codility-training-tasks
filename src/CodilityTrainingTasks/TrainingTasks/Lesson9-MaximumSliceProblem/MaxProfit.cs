using System;

namespace TrainingTasks
{
    public class MaxProfit
    {
        /// <summary>
        /// Keep track of the minimum value on the left and the maximum profit, and for each value in the array check the current profit.
        /// If the current profit is greater than the maximum, then it is the new maxProfit
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            if (A.Length == 0) return 0; // The array can be emtpy

            var maxProfit = 0;
            var minimumOnTheLeft = A[0];

            for (int i = 0; i < A.Length - 1; i++)
            {
                minimumOnTheLeft = Math.Min(minimumOnTheLeft, A[i]);

                var currentProfit = A[i + 1] - minimumOnTheLeft;

                if (maxProfit < currentProfit)
                {
                    maxProfit = currentProfit;
                }
            }

            return maxProfit < 0 ? 0 : maxProfit;
        }

        // https://codility.com/demo/results/trainingUP452E-98H/
    }
}
