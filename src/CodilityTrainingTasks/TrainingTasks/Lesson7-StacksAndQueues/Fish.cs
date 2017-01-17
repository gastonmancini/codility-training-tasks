using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks
{
    public class Fish
    {
        /// <summary>
        /// Iterate for each fish and push in the stack the position of the survival ones.
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] A, int[] B)
        {
            var survivalsStack = new Stack<int>();

            for (int i = 0; i < B.Length; i++)
            {
                // Push the first fish
                if (survivalsStack.Count == 0)
                {
                    survivalsStack.Push(i);
                    continue;
                }

                // Get the previous fish
                var previous = survivalsStack.Peek();
                
                // The current fish goes upstream and the previous fish goes downstream
                if (B[previous] == 1 && B[i] == 0)
                {
                    bool fishAlive = true;

                    // There is any fish and they go in different directions
                    while (survivalsStack.Any() && B[previous] != B[i])
                    {
                        if (A[previous] < A[i])
                        {
                            // The previous fish was eaten
                            survivalsStack.Pop();
                        }
                        else
                        {
                            // The current fish died
                            fishAlive = false;
                            break;
                        }

                        if (survivalsStack.Any()) previous = survivalsStack.Peek();
                    }

                    // If the current fish didn't die
                    if (fishAlive) survivalsStack.Push(i);
                }
                else
                {
                    // Go in the same direction
                    survivalsStack.Push(i);
                }
            }

            return survivalsStack.Count;
        }

        // https://codility.com/demo/results/trainingP574HE-VB8/
    }
}
