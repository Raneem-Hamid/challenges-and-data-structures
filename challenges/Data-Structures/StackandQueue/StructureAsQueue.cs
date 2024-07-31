using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.StackandQueue
{
    public class StructureAsQueue
    {
        public Node front;
        public Node back;
        public StructureAsQueue()
        {
            front = back = null;        
        }

        public void Enqueue(int data)
        {

            Node newNode = new Node(data);

            if (IsEmpty())
            {
                front = back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }

        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            Node t = front.Next;
            front = t;


        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

    }
}
