using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.StackandQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : StructureAsStack
    {

       public void DeleteMiddle()
        {
            int count = Count();
            int middleIndex = (count % 2 == 0) ? (count / 2)  : (count - 1) / 2;
            if (IsEmpty())
            {
                return;
            }
            else
            {
                StructureAsStack stack2 = new StructureAsStack();
                for (int i = 0; i < middleIndex; i++)
                {
                    stack2.Push(Peek());
                    Pop();
                }
                Pop();
                while (!stack2.IsEmpty())
                {
                    Push(stack2.Peek());
                    stack2.Pop();
                }
            }   
        }

    }
}
