using challenges.Data_Structures.LinkedList;
using challenges.Data_Structures.StackandQueue;
using challenges.Reverse_Words;

namespace challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3 ,1,2,3};      
            //Console.WriteLine("Duplicates: " + string.Join(", ", Find_Duplicates.FindDuplicates(arr)));

            //int[] arr1 = { 5, 10, 15, 20 };
            //int[] arr2 = { 10, 15, 25 };
            //Console.WriteLine("Input: " + string.Join(", ", arr1)+ " and "+ string.Join(", ", arr2));

            //Console.WriteLine("Common Elements: " + string.Join(", ", Common_Elements.Common_Elements.CommonElements(arr1, arr2)));

            //string sentence = "csharp is programming language";
            //Console.WriteLine("The Input: " + sentence);
            //Console.WriteLine("The Output: " + Reverse_Words.Reverse_Words.ReverseWords(sentence));



            //Linked List 
            //Linked_List myList = new Linked_List();
            //myList.AddFirst(1);
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            //myList.AddEnd(4);
            //Console.WriteLine("Searching for not found item (5):");
            //myList.Include(5);
            //Console.WriteLine("Searching for (4):");
            //myList.Include(4);
            //Console.WriteLine("The List Before Remove (1):");
            //myList.PrintList();
            //myList.Remove(1);
            //Console.WriteLine();
            //Console.WriteLine("The List After Remove (1):");
            //myList.PrintList();


            //Linked - List - Remove - Duplicates

            //Linked_List myList = new Linked_List();
            //myList.AddFirst(1);
            //myList.AddFirst(4);
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            //myList.AddEnd(4);
            //Console.WriteLine($"Print Array Before Remove Duplicates");
            //myList.PrintList();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Array After Remove Duplicates ");
            //myList.RemoveDuplicate();
            //myList.PrintList();

            // Merge Sorted Linked Lists
            //Linked_List list1 = new Linked_List();
            //list1.AddEnd(1);
            //list1.AddEnd(3);
            //list1.AddEnd(5);

            //Linked_List list2 = new Linked_List();
            //list2.AddEnd(2);
            //list2.AddEnd(4);
            //list2.AddEnd(6);

            //Linked_List mergedList = Linked_List.MergeSortedLists(list1, list2);

            //Console.WriteLine("Merged List:");
            //Node current = mergedList.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Data);
            //    current = current.Next;
            //}

            //Stack
            Console.WriteLine("Data structure : Stack ");
            StructureAsStack stack = new StructureAsStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(" The top value before using pop method : " + stack.Peek());
            stack.Pop();
            Console.WriteLine(" The top value after using pop method : " + stack.Peek());
            //Queue
            Console.WriteLine("Data structure : Queue ");
            StructureAsQueue queue = new StructureAsQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(" The first value before using Dequeue method : " + queue.Peek());
            queue.Dequeue();
            Console.WriteLine(" The first value after using Dequeue method : " + queue.Peek());


        }

    }
}