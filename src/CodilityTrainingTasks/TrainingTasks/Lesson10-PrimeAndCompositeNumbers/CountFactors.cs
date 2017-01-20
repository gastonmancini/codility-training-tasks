using System;

namespace TrainingTasks
{
    public class CountFactors
    {
        /// <summary>
        /// To count the number of divisors of N. The easiest approach is to iterate through all the numbers from 1 to N, and check whether or not each one is a divisor.
        /// The time solution is O(N). 
        /// But we can improve this with a O(sqrt(N)). So we iterate from 1 to sqrt(N)
        /// Based on one divisor, we can fid a symmetric divisor. More precisely if number A is a divisor of N, then N/A is also a divisor.
        /// For example: N = 12
        /// The divisors are 1,2,3,4 and 12. 12 is the symmetric divisor of 1, 6 is the symmetric divisor of 2 and 4 is the symmetric divisor of 3.
        /// There is an exception to the rule. When the number N is divisible by SQRT(N), then it has odd number of factors, and one of them
        /// does not have a symmetric one.
        /// Time-complexity: O(sqrt(N))
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int N)
        {
            var factorsCount = 0;

            // Iterate from 1 to sqrt(N), and count the factors
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N%i == 0) factorsCount++;
            }

            factorsCount *= 2; // Each of the factors counted above has a symmetric one, so we duplicate that number

            if (N%Math.Sqrt(N) == 0) factorsCount--; // When the number N is divisible by SQRT(N), then it has odd number of factors, and one of them does not have a symmetric one.

            return factorsCount;
        }

        // https://codility.com/demo/results/trainingHA9FJG-ANK/
    }
}
