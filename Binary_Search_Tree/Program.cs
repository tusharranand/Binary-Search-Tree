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
            Binary_Node node_four = new Binary_Node(22);
            Binary_Node node_five = new Binary_Node(40);
            Binary_Node node_six = new Binary_Node(11);
            Binary_Node node_seven = new Binary_Node(3);
            Binary_Node node_eight = new Binary_Node(16);
            Binary_Node node_nine = new Binary_Node(60);
            Binary_Node node_ten = new Binary_Node(95);
            Binary_Node node_eleven = new Binary_Node(65);
            Binary_Node node_twelve = new Binary_Node(63);
            Binary_Node node_thirteen = new Binary_Node(67);


            BST Tree = new BST(node_one);                           //56
            Tree.Insert_Left(node_one, node_two);                   //30
            Tree.Insert_Right(node_one, node_three);                //70
            Tree.Insert_Left(node_two, node_four);                  //22
            Tree.Insert_Right(node_two, node_five);                 //40
            Tree.Insert_Left(node_four, node_six);                  //11
            Tree.Insert_Left(node_six, node_seven);                 //3
            Tree.Insert_Right(node_six, node_eight);                //16
            Tree.Insert_Left(node_three, node_nine);                //60
            Tree.Insert_Right(node_three, node_ten);                //95
            Tree.Insert_Right(node_nine, node_eleven);              //65
            Tree.Insert_Left(node_eleven, node_twelve);             //63
            Tree.Insert_Right(node_eleven, node_thirteen);          //67
        }
    }
}