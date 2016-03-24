using System.Linq;

namespace TrainingTasks.Lesson_4
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            var arrayAux = new int[A.Length + 1];
            
            for (int i = 0; i<A.Length; i++)
            {
                // Out of range
                if (A[i] < 1 || A[i] > A.Length) return 0;

                // Duplicated elem
                if (arrayAux[A[i]] != 0) return 0;
                
                arrayAux[A[i]] = A[i];
            }

            return 1;
        }

        //private int NlogN(int[] A)
        //{
        //    // O(N * log(N))

        //    var intArr = Enumerable.Range(1, A.Length).Select(x => x).ToArray();

        //    return A.OrderBy(x => x).SequenceEqual(intArr) ? 1 : 0;
        //}

        //private int N2(int[] A)
        //{
        //    // O(N ** 2)

        //    for (int i = 1; i <= A.Length; i++)
        //    {
        //        if (!A.Contains(i)) return 0;
        //    }

        //    return 1;
        //}

        //private int NlogN_v2(int[] A)
        //{
        //    // O(N * log(N))

        //    var list = A.ToList();
        //    list.Sort();

        //    int count = 1;

        //    foreach (var number in list)
        //    {
        //        if (number != count) return 0;
        //        count++;
        //    }

        //    return 1;
        //}
    }
}
