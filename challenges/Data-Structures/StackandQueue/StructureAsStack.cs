using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.StackandQueue
{
    public class StructureAsStack
    {
        public Node top;
        public StructureAsStack()
        {
            top = null;

        }

        public void Push(int data)
        {
           Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public void Pop() 
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            Node t = top.Next;
            top = t;


        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }

            return false;
        }
    }
}
