using System;

namespace TrainingTasks
{
    public class Triangle
    {
        /// <summary>
        /// Sort the array so we satisfy <![CDATA[ 0 ≤ P < Q < R < N ]]>
        /// Then iterate the array check if the ordered elements in the array satisfy the 3 given conditions
        /// Tip: cast values to long to avoid overflow
        /// Time-complexity: O(n*log(n))
        /// Space-complexity: O(n)
        /// </summary>
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i <= A.Length - 3; i++) // There should be at least 3 elements in the array
            {
                if ((long)A[i] + A[i + 1] > A[i + 2] &&
                    (long)A[i + 1] + A[i + 2] > A[i] &&
                    (long)A[i + 2] + A[i] > A[i + 1])
                {
                    return 1;
                }
            }

            return 0;
        }

        // https://codility.com/demo/results/trainingAHGG53-RVC/
    }
}
