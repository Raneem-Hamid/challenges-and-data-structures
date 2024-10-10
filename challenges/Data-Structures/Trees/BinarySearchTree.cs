using challenges.Data_Structures.LinkedList;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees
{
    public class BinarySearchTree
    {
        public TNode Root { get; set; }

       
        public void Add(int data)
        {
            if (Root == null)
            {
                Root = new TNode(data);
            }
            else
            {
                AddingProcess(Root, data);
            }
        }

        private void AddingProcess(TNode node, int data)
        {
            if (data > node.Data)
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(data);  
                }
                else
                {
                    AddingProcess(node.Right, data);  
                }
            }
            else
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(data);  
                }
                else
                {
                    AddingProcess(node.Left, data);  
                }
            }
        }



        public bool Contains(int data)
        {
            return IfContains(Root,data);
        }

        private bool IfContains(TNode node, int data) 
        {
            if (node == null)
                return false;

            if (node.Data == data)
            {
               
                
                return true;
            }
            else
            {

                if (data > node.Data)
                {
                    

                   return  IfContains(node.Right, data);
                }
                else
                {
                   
                    return IfContains(node.Left, data);
                }
                
            }
        }

        public void Remove (int data)
        {
            Root = RemovingProcess(Root, data);
        }

        private TNode RemovingProcess (TNode node , int data)
        {

            if (node == null)
                return null;

            if (node.Data == data)
            {
                if (node.Left == null)
                {
                    node = node.Right;   
                }
                else if (node.Right == null)
                {
                    node = node.Left;
                }
                else
                {
                    node.Data = MinValue(node.Right);
                    node.Right = RemovingProcess(node.Right, node.Data);
                }
            }
            else if (data > node.Data)
            {
               node.Right= RemovingProcess(node.Right, data);
            }
            else
            {
                node.Left= RemovingProcess(node.Left, data);
            }
            return node;

        }

        private int MinValue(TNode node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }


        
        public void PrintRightView()
        {
            int maxLevel = -1; 
            PrintRightViewRecursive(Root, 0, ref maxLevel);
            Console.WriteLine();
        }

        private void PrintRightViewRecursive(TNode node, int currentLevel, ref int maxLevel)
        {
           
            if (node == null)
                return;

            if (currentLevel > maxLevel)
            {
                Console.Write(node.Data + " ");
                maxLevel = currentLevel; 
            }

           
            PrintRightViewRecursive(node.Right, currentLevel + 1, ref maxLevel);
            PrintRightViewRecursive(node.Left, currentLevel + 1, ref maxLevel);
        }


        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            // Create an array to hold the count of nodes at each level
            int[] levelCounts = new int[100]; // Assuming a maximum of 100 levels
            int maxLevel = 0;

            // Start DFS traversal
            CountNodesAtLevels(Root, 0, levelCounts);

            // Find the level with the maximum nodes
            for (int i = 0; i < levelCounts.Length; i++)
            {
                if (levelCounts[i] > levelCounts[maxLevel])
                {
                    maxLevel = i;
                }
            }

            return maxLevel;
        }

        private void CountNodesAtLevels(TNode node, int level, int[] levelCounts)
        {
            if (node == null)
                return;

            // Increment the count for the current level
            levelCounts[level]++;

            // Traverse the left and right children
            CountNodesAtLevels(node.Left, level + 1, levelCounts);
            CountNodesAtLevels(node.Right, level + 1, levelCounts);
        }

        public int FindMinimumDepth()
        {
            return FindMinimumDepth(Root);
        }
        private int FindMinimumDepth(TNode node)
        {
            if (node == null)
            {
                return 0;
            }

            // Leaf node
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }

            // If left subtree is null, recurse on right subtree
            if (node.Left == null)
            {
                return FindMinimumDepth(node.Right) + 1;
            }

            // If right subtree is null, recurse on left subtree
            if (node.Right == null)
            {
                return FindMinimumDepth(node.Left) + 1;
            }

            // If both left and right children exist, return the minimum of both
            return Math.Min(FindMinimumDepth(node.Left), FindMinimumDepth(node.Right)) + 1;
        }
    }
}
