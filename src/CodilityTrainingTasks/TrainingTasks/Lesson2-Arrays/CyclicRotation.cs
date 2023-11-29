﻿using System.Linq;

namespace TrainingTasks
{
    public class CyclicRotation
    {
        /// <summary>
        /// The key of this task is correctness, not performance. Convert the array into a list and use linq.
        /// Foreach of the desired rotations, copy the last element of the array in the index 0 and remove the last element of the array.
        /// Time-complexity: O(N^2)
        /// Space-complexity: O(N)
        /// </summary>
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0 || A.Length == 1) return A;

            var aAsList = A.ToList();

            for (int i = 1; i <= K; i++)
            {
                aAsList.Insert(0, aAsList.Last());
                aAsList.RemoveAt(aAsList.Count - 1);
            }

            return aAsList.ToArray();
            // https://codility.com/demo/results/trainingUQ2T2N-8TQ/
        }

        public int[] solutionV2(int[] A, int K)
        {
            if (K == 0 || A.Length < 2) return A;

            while (K > 0)
            {
                var lastElement = A[A.Length - 1];
                for (int i = A.Length - 1; i > 0; i--)
                {
                    A[i] = A[i - 1];
                }
                A[0] = lastElement;
                K--;
            }

            return A;
            // https://app.codility.com/demo/results/trainingJNBMCZ-GHG/
        }
    }
}
