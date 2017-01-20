using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    public class Flags
    {
        /// <summary>
        /// Score 66% - REVIEW, this is a brute force solution :(
        /// 
        /// https://codility.com/media/train/solution-flags.pdf
        /// 
        /// Correctness: 100%
        /// Performance: 28%
        /// 
        /// </summary>
        public int solution(int[] A)
        {
            // If we have less than three elements, there is no peak
            if (A.Length < 3) return 0;

            // Create a list with the index of the peaks
            var peaks = new List<int>();
            for (int index = 1; index < A.Length - 1; index++)
            {
                if (A[index - 1] < A[index] && A[index] > A[index + 1])
                {
                    peaks.Add(index);
                }
            }
            
            var maxFlagsCount = 0;
            
            // For each allowed flag (1..number of peaks) try to put a flag on the peaks
            for (int flag = 1; flag <= Math.Sqrt(peaks.Count) + 1; flag++)
            {
                var peakCount = 1;
                var lastPeak = peaks[0];

                var i = 1;

                while (peakCount < flag && i < peaks.Count)
                {
                    var currentDistance = peaks[i] - lastPeak;

                    if (currentDistance >= flag) // If the distance is greater than the number of flags, the we can use it
                    {
                        peakCount++;
                        lastPeak = peaks[i];
                    }
                    i++;
                }
                
                if (flag <= peakCount) // Check that there are no more flags than peaks
                {
                    maxFlagsCount = Math.Max(maxFlagsCount, flag);
                }
            }

            return maxFlagsCount;
        }

        // https://codility.com/demo/results/trainingXZ83G5-3V3/
    }
}
