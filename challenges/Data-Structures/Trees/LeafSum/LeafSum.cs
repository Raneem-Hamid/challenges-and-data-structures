using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees.LeafSum
{
    public class LeafSum : BinarySearchTree
    {
        public int GetLeafSum()
        {
        return  FindLeafSum(Root);
        }
        private int FindLeafSum(TNode node)
        {
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return node.Data;
            int leftLeafSum = FindLeafSum(node.Left);
            int rightLeafSum = FindLeafSum(node.Right);
            return leftLeafSum + rightLeafSum;
        }
    }
}
