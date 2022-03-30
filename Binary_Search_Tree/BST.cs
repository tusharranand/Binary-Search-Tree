using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BST
    {
        Binary_Node Head;

        public BST(Binary_Node node)
        {
            Head = node;
        }
        public void Insert_Default(Binary_Node Parent, Binary_Node node)
        {
            if (Parent.Left == null)
            {
                Console.WriteLine("Inserting {0} to the left of root {1}", node.Key, Parent.Key);
                Parent.Left = node;
                node.Root = Parent;
            }
            else
            {
                Console.WriteLine("Inserting {0} to the right of root {1}", node.Key, Parent.Key);
                Parent.Right = node;
                node.Root = Parent;
            }
        }
        public void Insert_Left(Binary_Node Parent, Binary_Node node)
        {
            Console.WriteLine("Inserting {0} to the left of root {1}", node.Key, Parent.Key);
            Parent.Left = node;
            node.Root = Parent;
        }
        public void Insert_Right(Binary_Node Parent, Binary_Node node)
        {
            Console.WriteLine("Inserting {0} to the right of root {1}", node.Key, Parent.Key);
            Parent.Right = node;
            node.Root = Parent;
        }
        public bool Search_Inorder(int Data)
        {
            Binary_Node temp = Head;
            temp = Left_Most(temp);
            while (temp.Root != null)
            {
                //if (temp.Key == Data)
                //    return true;
                //else if (temp.Root.Key == Data)
                //    return true;
                //else if (temp.Root.Right != null)
                //{
                //    if (temp.Root.Right.Key == Data)
                //        return true;
                //    else
                //    {
                //        temp = temp.Root.Right;
                //        if (temp.Left != null)
                //            temp = Left_Most(temp);
                //        else if (temp.Right != null)
                //        {
                //            temp = temp.Right;
                //            temp = Left_Most(temp);
                //        }
                //        else temp = temp.Root;
                //    }
                //}
            }
            if (temp.Key == Data)
                return true;
            return false;
        }
        public Binary_Node Left_Most(Binary_Node temp)
        {
            while (temp.Left != null)
            {
                temp = temp.Left;
            }
            return temp;
        }
    }
}
