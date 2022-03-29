using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Binary_Node
    {
        public int Key;
        public Binary_Node Left, Right, Root;

        public Binary_Node(int item)
        {
            Key = item;
            Left = null;
            Right = null;
            Root = null;
        }
    }
}
