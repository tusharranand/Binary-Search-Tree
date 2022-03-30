using System;

namespace Binary_Search_Tree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");

            BST<int> Tree = new BST<int>(56);
            Tree.Insert(30);
            Tree.Insert(70);

            Tree.Display_Inorder();
            Tree.Display_Preorder();
            Tree.Display_Postorder();
        }
    }
}