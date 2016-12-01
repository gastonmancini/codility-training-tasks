using System;

namespace TrainingTasks
{
    public class FrogJmp
    {
        /// <summary>
        /// Solution = (Y - X) / D
        /// Time-complexity: O(1)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((decimal)(Y - X)/D);
        }
    }
}
