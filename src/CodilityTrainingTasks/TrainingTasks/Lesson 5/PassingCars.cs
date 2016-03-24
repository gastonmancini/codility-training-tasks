namespace TrainingTasks.Lesson_5
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int zeros = 0;
            long total = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) 
                    zeros++;
                else
                    total = total + zeros;
            }

            if (total > 1000000000) return -1;
            
            return (int)total;
        }
    }
}
