using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Binary_Node<T> where T : IComparable
    {
        public T Value;
        public Binary_Node<T> Left, Right;

        public Binary_Node(T item)
        {
            Value = item;
            Left = null;
            Right = null;
        }
    }
}
