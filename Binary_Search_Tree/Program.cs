using System;

namespace Binary_Search_Tree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");

            Binary_Node node_one = new Binary_Node(56);
            Binary_Node node_two = new Binary_Node(30);
            Binary_Node node_three = new Binary_Node(70);

            BST Tree = new BST(node_one);
            Tree.Insert_Left(node_one, node_two);
            Tree.Insert_Right(node_one, node_three);
        }
    }
}