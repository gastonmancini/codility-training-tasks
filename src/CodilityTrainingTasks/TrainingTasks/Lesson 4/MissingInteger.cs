using System.Linq;

namespace TrainingTasks.Lesson_4
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            var list = A.Distinct().Where(x => x > 0).ToList();
            list.Sort();

            int count = 1;

            foreach (var number in list)
            {
                if (number != count) return count;
                count++;
            }

            return list.Count + 1;
        }
    }
}
