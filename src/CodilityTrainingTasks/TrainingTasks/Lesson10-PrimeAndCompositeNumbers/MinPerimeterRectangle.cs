using System;

namespace TrainingTasks.Lesson_10
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            // O(sqrt(N))
            int i = 1;
            int sqrt = (int) Math.Sqrt(N);
            int minPerimeter = calculatePerimeter(1, N);

            while (i <= sqrt)
            {
                if (N%i == 0)
                {
                    var currentPerimeter = calculatePerimeter(i, N/i);
                    if (currentPerimeter < minPerimeter)
                    {
                        minPerimeter = currentPerimeter;
                    }
                }

                i++;
            }

            return minPerimeter;
        }

        private int calculatePerimeter(int A, int B)
        {
            return 2*(A + B);
        }
    }
}
