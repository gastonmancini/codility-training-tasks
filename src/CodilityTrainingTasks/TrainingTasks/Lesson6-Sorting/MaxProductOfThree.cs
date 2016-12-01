using System;

namespace TrainingTasks
{
    public class MaxProductOfThree
    {
        /// <summary>
        /// First, sort the array. Then the max product of the last 3 elements, or the last element multiplied the first two of them is the expected result.
        /// Time-complexity: O(n*log(n))
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            Array.Sort(A);

            return Math.Max(
                A[A.Length - 1] * A[0] * A[1],
                A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3]);
        }

        // https://codility.com/demo/results/trainingD3ZEHJ-S8T/
    }
}
