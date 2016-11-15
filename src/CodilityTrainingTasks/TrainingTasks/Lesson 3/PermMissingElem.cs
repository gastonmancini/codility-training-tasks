namespace TrainingTasks.Lesson_3
{
    public class PermMissingElem
    {
        /// <summary>
        /// Calculate the sum of the elements from 1 to the size of the array. And the substract that total sum from the actual sum of the elements in the array to find the missing element.
        /// Tip: use long instead of int
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(int[] A)
        {
            long N = A.Length + 1;

            long totalSum = N * (N + 1)  / 2; // Formula to calculate the sum of the first n natural numbers

            long sumOfTheElementsOfA = 0;

            foreach (var number in A)
            {
                sumOfTheElementsOfA += number;
            }

            return (int) (totalSum - sumOfTheElementsOfA);
        }
    }
}
