using System;

namespace challenges.Data_Structures.LinkedList
{
    public class Linked_List
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }

        public void AddEnd(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        public void AddFirst(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }

        public int PrintList()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("Linked List is Empty");
                return 0;
            }
            else
            {
                int count = 0;
                while (Start != null)
                {
                    Console.WriteLine(Start.Data);
                    Start = Start.Next;
                    count++;
                }
                return count;
            }
        }

        public bool Include(int value)
        {
            Node current = Head;
            int position = 1;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine($"Item: {value} Found at: {position}");
                    return true;
                }
                current = current.Next;
                position++;
            }

            Console.WriteLine("Item Not Found");

            return false;
        }

        public void Remove(int value)
        {
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            if (Head.Data == value)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                return;
            }

            Node previous = Head;
            Node current = Head.Next;
            while (current != null)
            {
                if (current.Data == value)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                    return;
                }
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Element Not Found");
            }
        }

        public int RemoveDuplicate()
        {
            int duplicatesRemoved = 0;
            Node current = Head;
            while (current != null)
            {
                Node nextItem = current;
                while (nextItem.Next != null)
                {
                    if (nextItem.Next.Data == current.Data)
                    {
                        nextItem.Next = nextItem.Next.Next;
                        duplicatesRemoved++;
                    }
                    else
                    {
                        nextItem = nextItem.Next;
                    }
                }
                current = current.Next;
            }
            return duplicatesRemoved;
        }

        public static Linked_List MergeSortedLists(Linked_List list1, Linked_List list2)
        {
            if (list1.Head == null) return list2;
            if (list2.Head == null) return list1;

            Node current1 = list1.Head;
            Node current2 = list2.Head;
            Linked_List mergedList = new Linked_List();

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    mergedList.AddEnd(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.AddEnd(current2.Data);
                    current2 = current2.Next;
                }
            }

            while (current1 != null)
            {
                mergedList.AddEnd(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.AddEnd(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }

        public int Length()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }
        public void RotateLeft(int k)
        {
            if (Head == null || k == 0)
            {
                return;
            }

            int length = Length();
            if (k > length) return;

            // Find the new head at position k
            Node current = Head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

            Node newHead = current.Next;
            current.Next = null;
            Tail.Next = Head;
            Head = newHead;
        }

    }
}
