using System;

namespace TrainingTasks
{
    public class OddOccurrencesInArray
    {
        /// <summary>
        /// If we XOR a number with itself odd number of times the result is 0, otherwise if we XOR even number of times the result is the number itself
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            if (A.Length % 2 == 0) throw new Exception("The number of elements must be odd.");

            int unpaired = 0;

            foreach (var number in A)
            {
                unpaired ^= number;
            }

            return unpaired;
        }

        // https://codility.com/demo/results/trainingYZ8GRJ-4FX/

        //public int solution(int[] A)
        //{
        //    // Space Complexity O(N)

        //    if (A.Length % 2 == 0) throw new Exception("The number of elements must be odd.");

        //    var set = new HashSet<int>();

        //    foreach (var number in A)
        //    {
        //        if (set.Contains(number))
        //        {
        //            set.Remove(number);
        //        }
        //        else
        //        {
        //            set.Add(number);
        //        }
        //    }

        //    return set.First();

        //    // https://codility.com/demo/results/trainingC2G9WH-HT8/
        //}
    }
}
