namespace TrainingTasks.Lesson_3
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            long N = A.Length + 1;
            long sum = N*(N + 1)/2;

            for (int i = 0; i < A.Length; i++)
            {
                sum -= A[i];
            }

            return (int)sum;
        }
    }
}
