namespace TrainingTasks.Lesson_3
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            // return (int)Math.Ceiling((double)(-X + Y) / D);

            if ((-X + Y)%D == 0)
            {
                return (-X + Y)/D;
            }
            return (-X + Y)/D + 1;
        }
    }
}
