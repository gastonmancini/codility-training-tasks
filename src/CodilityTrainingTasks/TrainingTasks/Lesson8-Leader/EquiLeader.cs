using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks.Lesson_8
{
    public class EquiLeader
    {
        public int solution(int[] A)
        {
            // TODO
            return 0;
        }

        //public int Sloooooooowww(int[] A)
        //{
        //    var list = new List<int>(A);
        //    int equiLeaderCount = 0;

        //    for (int S = 1; S < A.Length ; S++)
        //    {
        //        var slice1 = list.GetRange(0, S);
        //        var slice2 = list.GetRange(S, A.Length - S);

        //        var slice1Leader = findLeader(slice1);
        //        var slice2Leader = findLeader(slice2);

        //        if (slice1Leader == slice2Leader)
        //        {
        //            equiLeaderCount++;
        //        }

        //    }

        //    return equiLeaderCount;
        //}

        //private int findLeader(List<int> list)
        //{
        //    int size = 0;
        //    int value = -1;

        //    foreach (int elem in list)
        //    {
        //        if (size == 0)
        //        {
        //            size++;
        //            value = elem;
        //        }
        //        else
        //        {
        //            if (value != elem)
        //                size--;
        //            else
        //                size++;
        //        }
        //    }

        //    int candidate = -1;

        //    if (size > 0) candidate = value;

        //    int count = list.Count(elem => elem == candidate);

        //    if (count > list.Count / 2) return candidate;

        //    return -1;
        //}

    }
}
