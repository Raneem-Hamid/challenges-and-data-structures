using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees.LargestLevelValue
{
    public class LargestLevelValue : BinarySearchTree
    {
        public List<int> GetLargestLevelValue()
        {
            List<int> largestValues = new List<int>();
            FindLargestLevelValue(Root, 0, largestValues);
            return largestValues;
        }
        private void FindLargestLevelValue(TNode node, int level, List<int> largestValues)
        {
            if (node == null)
                return;
            if (level == largestValues.Count)
            {
                largestValues.Add(node.Data);
            }
            else
            {
                largestValues[level] = Math.Max(largestValues[level], node.Data);
            }
            FindLargestLevelValue(node.Left, level + 1, largestValues);
            FindLargestLevelValue(node.Right, level + 1, largestValues);
        }
    }
}

