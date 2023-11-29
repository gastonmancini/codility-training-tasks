using System;

namespace TrainingTasks
{
    public class BinaryGap
    {
        /// <summary>
        /// Convert the number into a binary array. Iterate the array and calculate the maximum binary gap.
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int N)
        {
            var binaryNumber = Convert.ToString(N, 2);

            int maxBinaryGap = 0;
            int currentBinaryGap = 0;

            foreach (var b in binaryNumber)
            {
                if (b == '0') // Compare with a char since we have an string of chars
                {
                    currentBinaryGap++;
                }
                else
                {
                    if (currentBinaryGap > maxBinaryGap)
                    {
                        maxBinaryGap = currentBinaryGap;
                    }

                    currentBinaryGap = 0;
                }
            }

            return maxBinaryGap;
            // https://codility.com/demo/results/training57BZZ5-W5Z/
        }

        // looks like this solutions got 80% score because there are some tests that do not pass in codility,
        // but they do pass here!
        // examples of this tests:
        // N = 561892, got 4 expected 3
        // N = 74901729, got 6 expected 4
        // N = 1376796946, got 8 expected 5
        public int solutionV2(int N)
        {
            var binaryRepresentation = Convert.ToString(N, 2);
            var currentCount = 0;
            var max = 0;

            for (int i = 0; i < binaryRepresentation.Length; i++)
            {
                char number = binaryRepresentation[i];
                if (number == '1' && currentCount == 0) continue; // nothing to count
                if (number == '0')
                {
                    currentCount++;
                }
                else if (number == '1' && currentCount > max)
                {
                    max = currentCount;
                    currentCount = 0;
                }
            }

            return max;
            // https://app.codility.com/demo/results/trainingKRX2NK-PJM/
        }
    }
}
