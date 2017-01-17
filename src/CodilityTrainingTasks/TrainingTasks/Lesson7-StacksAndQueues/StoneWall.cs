using System.Collections.Generic;

namespace TrainingTasks
{
    public class StoneWall
    {
        /// <summary>
        /// The idea is to work on levels. 
        /// A new level should be created when the current block has a different size than the previous one.
        /// This new block can be:
        /// - Lower than the previous one: take levels out until the height of the level is greater and increment the number of required blocks
        /// - Higher than the previous one: push the new block
        /// (every time the high drops, you basically close a construction block)
        /// 
        /// Time-complexity: O(N)
        /// Space-complexity: O(N)
        /// </summary>
        public int solution(int[] H)
        {
            var stack = new Stack<int>();

            var blockCount = 0;

            foreach (var height in H)
            {
                // If the height of the current block is less than the previous ones, the previous ones have to end before the current point.
                // So the current blocks are finished
                while (stack.Count > 0 && height < stack.Peek())
                {
                    stack.Pop();
                    blockCount++;
                }

                // If there are no elements in the stack, or the current block is greate than the previous one, 
                // a new block is needed for the current position
                if (stack.Count == 0 || height > stack.Peek())
                {
                    stack.Push(height);
                }

                // else the height of the current block is the same as the previous one, so they should be combined
            }

            blockCount += stack.Count; // some blocks with different heights are still in the stack

            return blockCount;
        }

        // https://codility.com/demo/results/trainingA4Q6F2-KRK/
    }
}
