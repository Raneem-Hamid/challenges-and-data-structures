using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.StackandQueue.ReverseStackUsingQueue
{
    public class StackWithReverse : StructureAsStack
    {

        public void ReverseStack()
        {
            if (IsEmpty() || top.Next == null)
            {
                return;
            }
            StructureAsQueue queue = new StructureAsQueue();
            while (!IsEmpty())
            {
            int data = Peek();
            
            queue.Enqueue(data);
            Pop();
            }
            while (!queue.IsEmpty() && queue.front.Data != null)
            {
                int data = queue.Peek();
                Push(data);
                queue.Dequeue();
            }
           
        }

    }
}
