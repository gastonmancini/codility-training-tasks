namespace TrainingTasks
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            // An empty array does not have a dominator
            if (A.Length == 0) return -1;

            int count = 0;
            int candidate = 0;

            // Find the dominator candidate
            for (int i = 0; i < A.Length; i++)
            {
                if (count == 0)
                {
                    candidate = A[i];
                    count++;
                }
                else
                {
                    if (A[i] != candidate)
                    {
                        count--;
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            int index = 0;
            int total = 0;

            // Find the last index of the candidate and count the total
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    index = i;
                    total++;
                }
            }

            // Array does not have a dominator
            if (total <= A.Length/2) return -1;

            // Return the last index
            return index;
        }
    }
}
