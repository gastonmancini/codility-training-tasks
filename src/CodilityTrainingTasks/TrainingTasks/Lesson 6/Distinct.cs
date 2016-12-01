using System;

namespace TrainingTasks.Lesson_6
{
    public class Distinct
    {
        /// <summary>
        /// Option 1: use linq.
        /// Option 2: sort the array and count the different values.
        /// Time-complexity: O(n*log(n))
        /// Space-complexity: O(n)
        /// </summary>
        public int solution(int[] A)
        {
            // Option 1
            // return A.Distinct().Count();
            // https://codility.com/demo/results/trainingH34CVV-3CF/

            // Option 2
            Array.Sort(A);

            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if ((i + 1 < A.Length && A[i] != A[i+1]) || i == A.Length - 1)
                {
                    count++;
                }
            }

            return count;
        }

        // https://codility.com/demo/results/trainingAQ8GJS-ZRA/
    }
}
