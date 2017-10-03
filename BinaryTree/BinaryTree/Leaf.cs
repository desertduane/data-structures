using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Leaf
    {
        public int Data { get; set; }
        public Leaf Right { get; set; }
        public Leaf Left { get; set; }

        public Leaf(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
