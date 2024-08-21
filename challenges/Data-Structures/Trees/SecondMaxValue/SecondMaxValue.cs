using challenges.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace challenges.Data_Structures.Trees.SecondMaxValue
{
    public class SecondMaxValue : BinarySearchTree
    {
        public int? GetSecondMax()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }
            return FindSecondMax(Root);
        }

        private int? FindSecondMax(TNode node)
        {
            TNode current = node;
            TNode parent = null;
            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }
            if (current.Left != null)
            {
                return FindMax(current.Left);
            }
            if (parent != null)
            {
                return parent.Data;
            }
            throw new InvalidOperationException("The tree doesn't have enough unique values.");
        }
        private int FindMax(TNode node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Data;
        }
    }
}

