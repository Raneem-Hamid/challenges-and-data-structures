using challenges.Data_Structures.LinkedList;
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

            Linked_List myList = new Linked_List();
            myList.AddFirst(1);
            myList.AddFirst(4);
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.AddEnd(4);
            Console.WriteLine($"Print Array Before Remove Duplicates");
            myList.PrintList();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Array After Remove Duplicates ");
            myList.RemoveDuplicate();
            myList.PrintList();
        }

    }
}