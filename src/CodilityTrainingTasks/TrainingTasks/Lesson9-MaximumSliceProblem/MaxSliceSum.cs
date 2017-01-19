namespace TrainingTasks
{
    public class MaxSliceSum
    {
        /// <summary>
        /// The idea is quite simple. Store the maxSliceSum and a currentMaxSliceSum.
        /// The MaxSliceSum is initialized with the first element in the array.
        /// Then we iterate all over the array and we start calculating the currentMaxSliceSum...
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            var maxSliceSum = A[0];
            var currentMaxSliceSum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                currentMaxSliceSum += A[i];

                // If the current element itself is greater than the sum with the previous elements, then this is the new currentMaxSlice.
                if (A[i] > currentMaxSliceSum) 
                {
                    currentMaxSliceSum = A[i];
                }

                // If the currentMaxSliceSum is greater than the final maxSliceSum, then we override it with the new value.
                if (maxSliceSum < currentMaxSliceSum) maxSliceSum = currentMaxSliceSum;
            }

            return maxSliceSum;
        }
    }
}
