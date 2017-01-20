using System;

namespace TrainingTasks
{
    /// <summary>
    /// Let the length of one side A, and the length of the other side B. For a rectangle with area N.
    /// Then the minimal possible perimeter is can be found when the difference between B and A is minimal.
    /// We can find those values by looking for the factors of N, and the minimal are going to be the ones in the middle.
    /// So we can iterate from 1 to sqrt(N) to get the maximum factor from the left side, and then we get the symmetrical one. 
    /// That values are the ones that make the permineter minimal.
    /// </summary>
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            int maxFactorFromLeftSide = 0;

            // Iterate from 1 to sqrt(N) to get the maximum factor from the middle
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N%i == 0) maxFactorFromLeftSide = i;
            }

            // Get the symettrical factor
            int symmetricFactor = N/maxFactorFromLeftSide;

            return 2 * (symmetricFactor + maxFactorFromLeftSide);
        }

        // https://codility.com/demo/results/trainingKR7PFS-NE9/
    }
}
