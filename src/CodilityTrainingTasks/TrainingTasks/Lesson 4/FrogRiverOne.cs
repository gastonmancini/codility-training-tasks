namespace TrainingTasks.Lesson_4
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            var pathArray = new int[X + 1];

            var jumps = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > X || pathArray[A[i]] != 0) continue;

                pathArray[A[i]] = A[i];
                jumps++;

                if (jumps == X) return i;
            }

            return -1;
        }
        
    }
}
