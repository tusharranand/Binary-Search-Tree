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
            Tree.Insert(22);
            Tree.Insert(40);
            Tree.Insert(60);
            Tree.Insert(95);
            Tree.Insert(11);
            Tree.Insert(65);
            Tree.Insert(3);
            Tree.Insert(16);
            Tree.Insert(63);
            Tree.Insert(67);


            Tree.Display_Inorder();
            Tree.Display_Preorder();
            Tree.Display_Postorder();

            Console.Write("Enter a Value to search for: ");
            int Value = Convert.ToInt32(Console.ReadLine());
            if (Tree.Search(Value))
                Console.WriteLine(Value + " exists in the Binary Search Tree");
            else Console.WriteLine(Value + " doesn't exists in the Binary Search Tree");
        }
    }
}