namespace TrainingTasks.Lesson_4
{
    public class PermCheck
    {
        /// <summary>
        /// Store an array of bools to check if all the elements are present or not. If the array of bools is true from 1 to N, then is permutation.
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] A)
        {
            var presence = new bool[A.Length];

            foreach (var number in A)
            {
                if (number - 1 >= A.Length) return 0; // If we are outside the bounds of the array then is not permutation

                presence[number - 1] = true;
            }

            foreach (var isPresent in presence)
            {
                if (!isPresent) return 0;
            }

            return 1;
        }

        // https://codility.com/demo/results/trainingEDVB9R-T5W/
    }
}
