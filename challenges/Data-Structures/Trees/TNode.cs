using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Data_Structures.Trees
{
    public class TNode
    {
        public int Data { get; set; }

        public TNode Left { get; set; }

        public TNode Right { get; set; }

        public TNode (int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
