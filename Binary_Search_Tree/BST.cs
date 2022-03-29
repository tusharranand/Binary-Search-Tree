using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BST
    {
        Binary_Node Root;

        public BST(Binary_Node node)
        {
            Root = node;
        }
        public void Insert_Default(Binary_Node Parent, Binary_Node node)
        {
            if (Parent.Left == null)
            {
                Console.WriteLine("Inserting to the left of root");
                Parent.Left = node;
                node.Root = Parent;
            }
            else
            {
                Console.WriteLine("Inserting to the right of root");
                Parent.Right = node;
                node.Root = Parent;
            }
        }
        public void Insert_Left(Binary_Node Parent, Binary_Node node)
        {
            Console.WriteLine("Inserting to the left of root");
            Parent.Left = node;
            node.Root = Root;
        }
        public void Insert_Right(Binary_Node Parent, Binary_Node node)
        {
            Console.WriteLine("Inserting to the right of root");
            Parent.Right = node;
            node.Root = Parent;
        }
    }
}
