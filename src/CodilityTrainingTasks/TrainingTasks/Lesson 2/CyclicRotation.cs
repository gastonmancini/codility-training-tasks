using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks.Lesson_2
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {

            if (A.Length == 0) { return A; }

            var list = new List<int>(A);

            for (int i = 0; i < K; i++)
            {
                list.Insert(0, list.ElementAt(list.Count - 1));
                list.RemoveAt(list.Count - 1);
            }

            return list.ToArray();
        }
    }
}
