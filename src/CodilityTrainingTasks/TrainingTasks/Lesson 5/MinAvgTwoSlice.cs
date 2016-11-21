using System;

namespace TrainingTasks.Lesson_5
{
    public class MinAvgTwoSlice
    {
        /// <summary>
        /// Tip: This is a math problem. Every slice must be of size two or three. Slices of bigger sizes are created from such smaller slices.
        /// Iterate the array and calculate the average of 2 and 3 elements, if one of those averages is lesser than the stored one, then keep the index.
        /// Time-complexity: O(1)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            var minimalAverage = decimal.MaxValue;
            int minimalAverageIndex = 0;

            for (int i = 0; i <= A.Length - 2; i++) // There are at least 2 elements in the array
            {
                var avgOfTwoElements = (decimal)(A[i] + A[i + 1])/2;

                var avgOfThreeElements = decimal.MaxValue;

                if (i <= A.Length - 3)
                {
                    avgOfThreeElements = (decimal)(A[i] + A[i + 1] + A[i + 2])/3;
                }

                var currentMinimalAverage = Math.Min(avgOfTwoElements, avgOfThreeElements);

                if (minimalAverage > currentMinimalAverage)
                {
                    minimalAverage = currentMinimalAverage;
                    minimalAverageIndex = i;
                }
            }

            return minimalAverageIndex;
        }

        // https://codility.com/demo/results/trainingZVGVJQ-CYN/
    }
}
