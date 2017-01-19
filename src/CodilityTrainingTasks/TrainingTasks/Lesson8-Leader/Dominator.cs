namespace TrainingTasks
{
    public class Dominator
    {
        /// <summary>
        /// The idea of the solution is to split this problem in two. First we try to find the candidate by counting the elements.
        /// Then when we have our candidate we can check if it really is a dominator (occurs more than half of the elements of A).
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            // First we try to find our candidate by counting the elements
            var auxCounter = 0;
            var candidate = 0;

            foreach (var number in A)
            {
                if (auxCounter == 0)
                {
                    candidate = number;
                    auxCounter++;
                }
                else
                {
                    if (candidate == number)
                    {
                        auxCounter++;
                    }
                    else
                    {
                        auxCounter--;
                    }
                }
            }

            var candidateOccurreces = 0;
            var index = 0; // Will contain the last index

            // Once we have our candidate we have to check if it is a dominator (occurs more than half of the elements of A)
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    candidateOccurreces++;
                    index = i;
                }
            }

            if (candidateOccurreces <= A.Length/2) return -1;
            
            return index;
        }

        // https://codility.com/demo/results/trainingW632RP-WMM/
    }
}
