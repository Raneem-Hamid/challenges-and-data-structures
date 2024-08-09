using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.StackandQueue.MinStack
{
    public class MinStack : StructureAsStack
    {
        public string GetMin()
        {
            if (IsEmpty())
            {
                return "stack is empty";
            }
            else
            {
                Node current = top;
                int min = top.Data;
                while (current != null)
                {
                    if (current.Data <= min)
                    {
                        min = current.Data;
                    }
                    current = current.Next;
                }
                return min.ToString();

            }
           
        }
    }
}
