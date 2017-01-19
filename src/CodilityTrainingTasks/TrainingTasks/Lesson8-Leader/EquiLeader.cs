using System.Collections.Generic;

namespace TrainingTasks
{
    public class EquiLeader
    {
        /// <summary>
        /// We can divide this solution in three parts...
        /// 1) We count all the elements in the array and store them in a dictionary
        /// 2) Find if we have a leader, if not return
        /// 3) Find the equileaders
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] A)
        {
            // Create a dictionary that contains the count of the elements in the array
            var elementsCount = new Dictionary<int, int>();

            foreach (var number in A)
            {
                if (elementsCount.ContainsKey(number))
                {
                    elementsCount[number]++;
                }
                else
                {
                    elementsCount[number] = 1;
                }
            }

            // Get the leader candidate - This could be done within the previous loop...
            var leaderCandidate = 0;
            var leaderCandidateCount = 0;
            foreach (var candidate in elementsCount.Keys)
            {
                if (elementsCount[candidate] > leaderCandidateCount)
                {
                    leaderCandidate = candidate;
                    leaderCandidateCount = elementsCount[candidate];
                }
            }

            // If there is no leader return early. Is leader if it occurrs in more than a half of the array
            if (leaderCandidateCount < A.Length/2) return 0;

            // Find the equi-leaders
            
            var leadersInTheLeft = 0;
            var equiLeadersCount = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leaderCandidate)
                {
                    leadersInTheLeft++;
                }

                if (leadersInTheLeft > (i + 1) / 2 // is leader in the left part if the leaders on the left are greater than the size of subarray / 2
                    && (leaderCandidateCount - leadersInTheLeft) > (A.Length - i - 1) /2) // is leader in the right part if the leaders on the right are greater than the size of the subarray / 2
                {
                    equiLeadersCount++;
                }
            }

            return equiLeadersCount;
        }

        // https://codility.com/demo/results/trainingWUQ2JW-U37/
    }
}
