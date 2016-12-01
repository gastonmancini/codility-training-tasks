namespace TrainingTasks.Lesson_5
{
    public class PassingCars
    {
        /// <summary>
        /// Iterate the array, when a zero is found then increment the zeros counter. When a one is found, sum the total counted zeros until that moment to the result.
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            const int maximumPassingCars = 1000000000;

            int zerosCount = 0;
            int passingCars = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zerosCount++;
                }
                else
                {
                    if (passingCars + zerosCount > maximumPassingCars) return -1; // Just in case - potential overflow using int
                    passingCars += zerosCount;
                }
            }

            if (passingCars > maximumPassingCars) return -1;

            return passingCars;
        }

        // https://codility.com/demo/results/training4ACBUK-K3C/
    }
}
