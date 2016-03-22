using System;
using System.Linq;

namespace TrainingTasks.Lesson_1
{
    public class BinaryGap
    { 
        public int solution(int N)
        {
            var bitString = Convert.ToString(N, 2);
            int[] bitArray = bitString.ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();

            int longestBinaryGap = 0;
            int currentBinaryGap = 0;

            foreach (int bit in bitArray)
            {
                if (bit == 0)
                {
                    currentBinaryGap++;
                }
                else
                {
                    if (currentBinaryGap > longestBinaryGap)
                    {
                        longestBinaryGap = currentBinaryGap;
                    }

                    currentBinaryGap = 0;
                }
            }

            return longestBinaryGap;
        }
    }
}
