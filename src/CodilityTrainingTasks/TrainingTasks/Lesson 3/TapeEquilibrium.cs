using System;

namespace TrainingTasks.Lesson_3
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            int arrayLenght = A.Length;

            if (arrayLenght < 2 || arrayLenght > 100000)
            {
                throw new Exception("N is an integer within the range [2..100,000]");
            }

            int rightSum = 0;

            for (int i = 0; i < arrayLenght; i++)
            {
                rightSum += A[i];
            }

            int leftSum = 0;
            int result = -1;

            for (int i = arrayLenght - 1; i > 0; i--)
            {
                leftSum += A[i];
                rightSum -= A[i];

                var difference = leftSum - rightSum;

                if (difference < 0)
                {
                    difference *= -1;
                }

                if (result > difference || result == -1)
                {
                    result = difference;
                }
            }

            return result;
        }
    }
}
