using System;

namespace TrainingTasks
{
    public class CountDiv
    {
        /// <summary>
        /// There are N(A) = floor(A / K) factors of K in interval [0;A]
        /// 
        ///          1K       2K       3K       4K       5K
        /// ●········x········x··●·····x········x········x···>
        /// 0                    A
        /// 
        /// There are N(B) = floor(B / K) factors of K in interval [0;B]
        /// 
        ///          1K       2K       3K       4K       5K
        /// ●········x········x··.·····x········x··●·····x···>
        /// 0                                      B
        /// 
        /// Then N = N(B) - N(A) equals to the number of K's (the number of integers divisible by K) in range (A;B]. 
        /// The point A is not included, because the subtracted N(A) includes this point. 
        /// Therefore, the result should be incremented by one, if A mod K is zero.
        /// 
        /// Time-complexity: O(1)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int A, int B, int K)
        {
            var result = Math.Floor((double) B/K) - Math.Floor((double) A/K);

            if (A % K == 0) 
            {
                result++;
            }

            return (int) result;
        }
    }
}
