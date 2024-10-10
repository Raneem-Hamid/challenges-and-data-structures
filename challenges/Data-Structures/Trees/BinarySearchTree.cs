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

    }
}
