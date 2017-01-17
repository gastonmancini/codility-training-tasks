namespace TrainingTasks
{
    public class Nesting
    {
        /// <summary>
        /// The idea is to count the number of opening and closing parenthesis. 
        /// Time-complexity: O(N)
        /// Space-complexity: O(1)
        /// </summary>
        public int solution(string S)
        {
            var parenthesisCount = 0;

            foreach (var parenthesis in S)
            {
                if (parenthesisCount < 0) return 0; // There is no properly nested because in that moment there are more closing parenthesis than opening ones. Example: ))((

                if (parenthesis == '(') parenthesisCount++;
                else parenthesisCount--;
            }

            return parenthesisCount == 0 ? 1 : 0; // If the count is 0, then is properly nested
        }

        // https://codility.com/demo/results/trainingBYVAB6-JN3/
    }
}
