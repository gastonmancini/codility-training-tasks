namespace TrainingTasks
{
    public class MaxCounters
    {
        /// <summary>
        /// Tip: Keep track of the current maximum value in the array, and the last MaxCounter. Before exiting the method check which values remains to be set with the last max counter and set them.
        /// Time-complexity: O(N + M)
        /// Space-complexity: O(N)
        /// </summary>
        public int[] solution(int N, int[] A)
        {
            var result = new int[N];
            int currentMaxValue = 0;
            int lastMaxCounter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (1 <= A[i] && A[i] <= N)
                {
                    if (result[A[i] - 1] < lastMaxCounter) result[A[i] - 1] = lastMaxCounter; // If the current value was not previusly set with the maxCounter, then set it

                    result[A[i] - 1]++; // increase(x)

                    if (result[A[i] - 1] > currentMaxValue) currentMaxValue = result[A[i] - 1]; // Store the maximum value in the array until this moment
                }
                else if (A[i] == N + 1)
                {
                    lastMaxCounter = currentMaxValue; // Store the last max value to be set in the array after this loop finish (maxCounter)
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (result[i] < lastMaxCounter) result[i] = lastMaxCounter; // Complete the remaining elements with the last maximum counter
            }

            return result;
        }

        // https://codility.com/demo/results/trainingYBPKQS-JNV/

        /// <summary>
        /// 88%
        /// Time-complexity: O(N * M)
        /// Space-complexity: O(N)
        /// </summary>
        //public int[] solutionNxM(int N, int[] A)
        //{
        //    var result = new int[N];
        //    int maxValue = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (1 <= A[i] && A[i] <= N)
        //        {
        //            result[A[i] - 1]++; // increase(x)

        //            if (result[A[i] - 1] > maxValue) maxValue = result[A[i] - 1]; // Store the maximum value
        //        } else if (A[i] == N + 1) 
        //        {
        //            for (int j = 0; j < N; j++) // maxCounter
        //            {
        //                result[j] = maxValue;
        //            }
        //        }
        //    }

        //    return result;

        //    // https://codility.com/demo/results/training93ZQSY-G9W/
        //}


    }
}
