namespace TrainingTasks
{
    public class FrogRiverOne
    {
        /// <summary>
        /// Store the positions covered by the leafs in an array of bool and count the number of of positions covered... when the positions counter is equals to the number of positions X then we covered it all and the frog is able to jump to the other side.
        /// Time-complexity: O(N)
        /// Space-complexity: O(X)
        /// </summary>
        public int solution(int X, int[] A)
        {
            var positions = new bool[X];
            int positionsCounter = 0;

            for (int sec = 0; sec < A.Length; sec++)
            {
                if (!positions[A[sec] - 1])
                {
                    positions[A[sec] - 1] = true;
                    positionsCounter++;
                }

                if (positionsCounter == X) return sec;
            }

            return -1; // The frog was not able to jump to the other side of the river :(
        }

        // https://codility.com/demo/results/training55W98A-24K/
    }
}
