using challenges.Data_Structures.LinkedList;
using challenges.Data_Structures.StackandQueue;
using challenges.Data_Structures.StackandQueue.DeleteMiddleElement;
using challenges.Data_Structures.StackandQueue.MinStack;
using challenges.Data_Structures.StackandQueue.ReverseStackUsingQueue;
using challenges.Data_Structures.Trees;
using challenges.Data_Structures.Trees.LargestLevelValue;
using challenges.Data_Structures.Trees.LeafSum;
using challenges.Data_Structures.Trees.MirrorTree;
using challenges.Data_Structures.Trees.SecondMaxValue;
using challenges.Reverse_Words;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Linq;

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
            //Console.WriteLine("Data structure : Stack ");
            //StructureAsStack stack = new StructureAsStack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //Console.WriteLine(" The top value before using pop method : " + stack.Peek());
            //stack.Pop();
            //Console.WriteLine(" The top value after using pop method : " + stack.Peek());
            //Queue
            //Console.WriteLine("Data structure : Queue ");
            //StructureAsQueue queue = new StructureAsQueue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //Console.WriteLine(" The first value before using Dequeue method : " + queue.Peek());
            //queue.Dequeue();
            //Console.WriteLine(" The first value after using Dequeue method : " + queue.Peek());


            //Reverse stack using Queue
            //Console.WriteLine("Reverse stack using Queue");
            //StackWithReverse stackWithReverse = new StackWithReverse();
            //stackWithReverse.Push(1);
            //stackWithReverse.Push(2);
            //stackWithReverse.Push(3);
            //stackWithReverse.Push(4);
            //stackWithReverse.Push(5);

            //Console.WriteLine(" The top value before using reverse method : " + stackWithReverse.Peek());

            //stackWithReverse.ReverseStack();
            //Console.WriteLine(" The top value after using reverse method : " + stackWithReverse.Peek());

            //stackWithReverse.Push(6);
            //stackWithReverse.Push(7);

            //Console.WriteLine(" The top value after adding 6 then 7 : " + stackWithReverse.Peek());
            //stackWithReverse.ReverseStack();
            //Console.WriteLine(" The top value after using reverse method : " + stackWithReverse.Peek());




            // Delete Middle Element of a Stack

            //var oddstack = new StackWithDeleteMiddle();
            //oddstack.Push(1);
            //oddstack.Push(2);
            //oddstack.Push(3);
            //oddstack.Push(4);
            //oddstack.Push(5);

            //Console.WriteLine("Odd Stack before deleting middle element:");
            //oddstack.PrintStack();

            //oddstack.DeleteMiddle();

            //Console.WriteLine("Odd Stack after deleting middle element:");
            //oddstack.PrintStack();


            //var evenstack = new StackWithDeleteMiddle();
            //evenstack.Push(1);
            //evenstack.Push(2);
            //evenstack.Push(3);
            //evenstack.Push(4);


            //Console.WriteLine("Even Stack before deleting middle element:");
            //evenstack.PrintStack();

            //evenstack.DeleteMiddle();

            //Console.WriteLine("Even Stack after deleting middle element:");
            //evenstack.PrintStack();

            //min stack

            //var stack = new MinStack();
            //stack.Push(15);
            //stack.Push(7);
            //stack.Push(12);
            //stack.Push(3);
            //Console.WriteLine("Print the contents of the stack :");
            //stack.PrintStack();
            //Console.WriteLine("The minimum element in the stack : " + stack.GetMin()); 
            //stack.Pop();
            //Console.WriteLine("Print the contents of the stack after using pop method :");
            //stack.PrintStack();
            //Console.WriteLine("The minimum element in the stack : " + stack.GetMin());
            //stack.Push(2);
            //Console.WriteLine("The minimum element in the stack after pushing (2) : " + stack.GetMin());
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //Console.WriteLine(stack.GetMin());


            // Tree implementation
            //BinaryTree tree = new BinaryTree();
            //tree.Add(15);
            //tree.Add(10);
            //tree.Add(20);
            //tree.Add(8);
            //tree.Add(12);
            //tree.Add(17);
            //tree.Add(25);
            //Console.WriteLine("\nTree Structure:");
            //tree.Print(tree.Root);
            //Console.WriteLine("Contains 12: " + tree.Contains(12));  
            //Console.WriteLine("Contains 30: " + tree.Contains(30));
            //Console.WriteLine("\nRemoving 10...");
            //tree.Remove(10);
            //Console.WriteLine("\nTree Structure after Removing 10:");
            //tree.Print(tree.Root);     
            //Console.WriteLine("\nPreOrder Traversal:");
            //tree.PreOrder(tree.Root);  
            //Console.WriteLine("\nInOrder Traversal:");
            //tree.InOrder(tree.Root);   
            //Console.WriteLine("\nPostOrder Traversal:");
            //tree.PostOrder(tree.Root); 

            //Mirror Tree

            //MirrorTree tree = new MirrorTree();
            //tree.Add(4);
            //tree.Add(8);
            //tree.Add(7);
            //tree.Add(12);
            //tree.Add(9);
            //Console.WriteLine("\nTree Structure before using mirror method:");
            //tree.Print(tree.Root);

            //List<int> originalInorder = tree.InorderTraversal();


            //Console.WriteLine("Inorder Traversal before using mirror method : " + string.Join(", ", originalInorder));

            //tree.Mirror();

            //Console.WriteLine("\nTree Structure after using mirror method:");
            //tree.Print(tree.Root);
            //List<int> mirroredInorder = tree.InorderTraversal();
            //Console.WriteLine("Inorder Traversal after using mirror method : " + string.Join(", ", mirroredInorder));



            //SecondMaxValue

            //SecondMaxValue tree = new SecondMaxValue();

            //tree.Add(4);
            //tree.Add(8);
            //tree.Add(7);
            //tree.Add(12);
            //tree.Add(9);
            //tree.Add(13);
            //Console.WriteLine("The Second Max Value IS : " + tree.GetSecondMax());


            //LeafSum

            //LeafSum tree = new LeafSum();
            //tree.Add(15);
            //tree.Add(10);
            //tree.Add(20);
            //tree.Add(25);
            //tree.Add(17);
            //tree.Add(12);
            //tree.Add(8);
            //Console.WriteLine("The total is : " + tree.GetLeafSum()); 

            // LargestLevelValue

            //LargestLevelValue tree = new LargestLevelValue();
            //tree.Add(15);
            //tree.Add(10);
            //tree.Add(20);
            //tree.Add(25);
            //tree.Add(17);
            //tree.Add(12);
            //tree.Add(8);

            //var largestValues = tree.GetLargestLevelValue();

            //Console.WriteLine("Largest values at each level:");
            //foreach (var value in largestValues)
            //{
            //    Console.WriteLine(value);
            //}

            //Rotate by k 
            //Linked_List list = new Linked_List();

            //// Add nodes to the linked list
            //list.AddFirst(1);
            //list.AddEnd(2);
            //list.AddEnd(3);
            //list.AddEnd(4);
            //list.AddEnd(5);
            //list.AddEnd(6);

            //Console.WriteLine("Original Linked List:");
            //list.PrintList();

            //// Rotate the linked list by k = 2
            //int k = 2;
            //Console.WriteLine($"\nRotating the list to the left by {k} positions...");
            //list.RotateLeft(k);

            //Console.WriteLine("\nRotated Linked List:");
            //list.PrintList();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //PrintRightView
            //BinarySearchTree bst = new BinarySearchTree();


            //bst.Add(50);
            //bst.Add(30);
            //bst.Add(70);
            //bst.Add(20);
            //bst.Add(40);
            //bst.Add(60);
            //bst.Add(80);


            //bst.PrintRightView();  


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Level with Maximum Number of Nodes

            //BinaryTree Btree = new BinaryTree();

            //Btree.Add(50);
            //Btree.Add(30);
            //Btree.Add(70);
            //Btree.Add(20);
            //Btree.Add(40);
            //Btree.Add(60);
            //Btree.Add(80);


            //int maxLevel = Btree.FindMaxLevelNodes();
            //Console.WriteLine($"The level with the maximum number of nodes is: {maxLevel}"); 


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Minimum Depth

            BinarySearchTree Btree = new BinarySearchTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);

            int minDepth = Btree.FindMinimumDepth();
            Console.WriteLine($"Minimum Depth: {minDepth}"); 
        }
    }
}

