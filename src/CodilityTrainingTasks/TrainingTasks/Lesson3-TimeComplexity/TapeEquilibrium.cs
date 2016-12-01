using System;
using System.Linq;

namespace TrainingTasks
{
    public class TapeEquilibrium
    {
        /// <summary>
        /// Sum all the elements in the array. Then, foreach of the elements calculate the first and the second part of P and get the difference. If the current difference is lesser thath the minimal stored one, replace it.
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            if (A.Length < 2 && A.Length > 100000) throw new ArgumentOutOfRangeException("N should be an integer within the range 2..100000");

            int minimalDifference = -1;

            int sum = A.Sum();

            int currentP1 = 0;
            int currentP2 = sum;

            for (int i = 0; i < A.Length - 1; i++)
            {
                currentP1 += A[i];
                currentP2 -= A[i];

                int currentDifference = Math.Abs(currentP1 - currentP2);

                if (currentDifference < minimalDifference || minimalDifference < 0)
                {
                    minimalDifference = currentDifference;
                }
            }

            return minimalDifference;
        }

        // https://codility.com/demo/results/trainingG82S87-ZX5/
    }
}
