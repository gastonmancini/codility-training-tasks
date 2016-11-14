using System;

namespace TrainingTasks.Lesson_1
{
    public class BinaryGap
    {
        /// <summary>
        /// Convert the number into a binary array. Iterate the array and calculate the maximum binary gap.
        /// Space-complexity: O(1)
        /// Time-complexity: O(N)
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
        }

        // https://codility.com/demo/results/training57BZZ5-W5Z/
    }
}
