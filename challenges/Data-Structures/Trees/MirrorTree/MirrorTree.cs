using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees.MirrorTree
{
    public class MirrorTree : BinaryTree
    {
        public void Mirror()
        {
            MirrorProcess(Root);
        }

        private void MirrorProcess(TNode node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                TNode Temp = node.Left;
                node.Left = node.Right;
                node.Right = Temp;
                MirrorProcess(node.Left);
                MirrorProcess(node.Right);
            }
        }
        public List<int> InorderTraversal()
        {
            var result = new List<int>();
            InOrderResult(Root , result);
            return result;
        }

        private void InOrderResult(TNode node , List<int> result)
        {
            if (node == null) return ;
            InOrderResult(node.Left , result);
            result.Add(node.Data);
            InOrderResult(node.Right, result);
            
        }
    }
}