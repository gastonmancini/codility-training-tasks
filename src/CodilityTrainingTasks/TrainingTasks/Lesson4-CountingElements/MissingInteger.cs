using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks.Lesson_4
{
    public class MissingInteger
    {
        /// <summary>
        /// Store all the elements in a set. Then iterate from 1 to the MaxValue in the array and the first element that is not present in the set is the missing integer.
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] A)
        {
            // Get min and max value of the array
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            foreach (var number in A)
            {
                if (number < minValue) minValue = number;
                if (number > maxValue) maxValue = number;
            }

            if (maxValue < 1) return 1; // If all the elements are lesser than zero

            var set = new HashSet<int>();

            foreach (var number in A.Distinct())
            {
                set.Add(number);
            }

            // From 1 to the max value, the first missing element is the result
            int i = 1;
            while (i <= maxValue)
            {
                if (!set.Contains(i)) return i;
                i++;
            }

            return i;
        }

        // https://codility.com/demo/results/training26XPGY-CX4/
    }
}
