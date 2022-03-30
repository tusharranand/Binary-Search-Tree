using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BST<T> where T : IComparable
    {

        Binary_Node<T> Head;
        Binary_Node<T> temp;
        public BST(T Key)
        {
            this.Head = new Binary_Node<T>(Key);
        }
        public void Insert(T Data)
        {
            temp = Head;
            Insert_R(Data);
        }
        public void Insert_R(T Data)
        {
            if (temp.Value.CompareTo(Data) > 0 && temp.Left == null)
            {
                Binary_Node<T> left = new Binary_Node<T>(Data);
                temp.Left = left;
            }
            else if (temp.Value.CompareTo(Data) > 0 && temp.Left != null)
            {
                temp = temp.Left;
                Insert_R(Data);
            }
            else if (temp.Value.CompareTo(Data) < 0 && temp.Right == null)
            {
                Binary_Node<T> right = new Binary_Node<T>(Data);
                temp.Right = right;
            }
            else if (temp.Value.CompareTo(Data) < 0 && temp.Right != null)
            {
                temp = temp.Right;
                Insert_R(Data);
            }
        }
        public void Display_Inorder()
        {
            Console.WriteLine("Displaying the Binary Search Tree InOrder");
            Display_Inorder(Head);
            Console.WriteLine("Binary Search Tree empty nothing to display.\n");
        }
        public void Display_Inorder(Binary_Node<T> node)
        {
            if (node.Left != null)
                Display_Inorder(node.Left);
            Console.WriteLine(node.Value);
            if (node.Right != null)
                Display_Inorder(node.Right);
        }
        public void Display_Preorder()
        {
            Console.WriteLine("Displaying the Binary Search Tree PreOrder");
            Display_Preorder(Head);
            Console.WriteLine("Binary Search Tree empty nothing to display.\n");
        }
        public void Display_Preorder(Binary_Node<T> node)
        {
            Console.WriteLine(node.Value);
            if (node.Left != null)
                Display_Preorder(node.Left);
            if (node.Right != null)
                Display_Preorder(node.Right);
        }
        public void Display_Postorder()
        {
            Console.WriteLine("Displaying the Binary Search Tree PostOrder");
            Display_Postorder(Head);
            Console.WriteLine("Binary Search Tree empty nothing to display.\n");
        }
        public void Display_Postorder(Binary_Node<T> node)
        {
            if (node.Left != null)
                Display_Postorder(node.Left);
            if (node.Right != null)
                Display_Postorder(node.Right);
            Console.WriteLine(node.Value);
        }
    }
}
