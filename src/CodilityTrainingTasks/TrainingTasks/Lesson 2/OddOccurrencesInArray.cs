using System;

namespace TrainingTasks.Lesson_2
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            int unpaired = 0;

            for (int i = 0; i < A.Length; i++)
            {
                unpaired ^= A[i];
            }

            return unpaired;
        }

        //public int solution(int[] A)
        //{
        //    // O (N * LOG N)
        //    Array.Sort(A);

        //    int previousValue = A[0];
        //    int count = 1;

        //    for (int i = 1; i < A.Length; i++)
        //    {
        //        if (A[i] == previousValue)
        //        {
        //            previousValue = -1;
        //            count = 0;
        //        }
        //        else
        //        {
        //            if (count == 1)
        //            {
        //                break;
        //            }

        //            previousValue = A[i];
        //            count++;
        //        }
        //    }

        //    return previousValue;
        //}
    }
}
