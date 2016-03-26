namespace TrainingTasks.Lesson_9
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            if (A == null || A.Length <= 0) return 0;
            
            int min = A[0];
            int maxDiff = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int currentDiff = A[i] - min;
                if (currentDiff > maxDiff)
                {
                    maxDiff = currentDiff;
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
            }

            return maxDiff;
        }
    }
}
