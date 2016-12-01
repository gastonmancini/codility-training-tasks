using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks.Lesson_7
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < B.Length; i++)
            {
                // Push the first fish
                if (stack.Count == 0)
                {
                    stack.Push(i);
                    continue;
                }

                // Get the previous fish
                var previous = stack.Peek();
                
                // The current fish goes upstream and the previous fish goes downstream
                if (B[previous] == 1 && B[i] == 0 )
                {
                    bool fishAlive = true;

                    // There is any fish and they go in different directions
                    while (stack.Any() && B[previous] != B[i])
                    {
                        if (A[previous] < A[i])
                        {
                            // The previous fish was eaten
                            stack.Pop();
                        }
                        else
                        {
                            // The current fish died
                            fishAlive = false;
                            break;
                        }

                        if (stack.Any()) previous = stack.Peek();
                    }

                    // If the current fish didn't die
                    if (fishAlive) stack.Push(i);
                }
                else
                {
                    // Go in the same direction
                    stack.Push(i);
                }
            }

            return stack.Count;
        }
    }
}
