using System;

namespace TrainingTasks.Lesson_6
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] >= 0 && A[i] > A[i + 2] - A[i + 1]) return 1;
            }

            return 0;
        }

        //private int N3(int[] A)
        //{
        //    // O(N ** 3)

        //    var combinations = Enumerable.Range(0, A.Length)
        //        .SelectMany(
        //            x =>
        //            Enumerable.Range(0, A.Length)
        //            .SelectMany(
        //            y =>
        //            Enumerable.Range(0, A.Length)
        //            .Select(
        //            z => new Tuple<int, int, int>(x, y, z))));

        //    int P, Q, R;

        //    foreach (var tuple in combinations)
        //    {
        //        P = tuple.Item1;
        //        Q = tuple.Item2;
        //        R = tuple.Item3;

        //        if ((A[P] + A[Q] > A[R]) &&
        //            (A[Q] + A[R] > A[P]) &&
        //            (A[R] + A[P] > A[Q]) &&
        //            0 <= P && P < Q && Q < R && R < A.Length)
        //        {
        //            return 1;
        //        }
        //    }

        //    return 0;
        //}


    }
}
