using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees
{
    public class BinaryTree : BinarySearchTree
    {
        public void PreOrder(TNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TNode node)
        {

            if (node == null) return;

           InOrder(node.Left);
            Console.WriteLine(node.Data);
            InOrder(node.Right);
        }

        public void PostOrder(TNode node)
        {

            if (node == null) return;

            PostOrder(node.Left);
           
            PostOrder(node.Right);
            Console.WriteLine(node.Data);
        }

        public void Print(TNode node, string indent = "", bool isLast = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + (isLast ? "└─" : "├─") + node.Data);
                indent += isLast ? "  " : "| ";
                Print(node.Left, indent, node.Right == null);
                Print(node.Right, indent, true);
            }
        }
    }
}
