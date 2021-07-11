using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            binarySearch.AddNode(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.AddNode(60);
            binarySearch.AddNode(3);
            binarySearch.AddNode(11);
            binarySearch.AddNode(22);
            binarySearch.AddNode(40);
            binarySearch.AddNode(65);
            binarySearch.AddNode(95);
            binarySearch.AddNode(63);
            binarySearch.AddNode(67);
            binarySearch.AddNode(16);
            binarySearch.display(binarySearch.root);
            Console.WriteLine("the number of node in the tree is :{0}",binarySearch.SizeOf(binarySearch.root));
            int search = binarySearch.SearchTree(1);
            if (search ==1)
            {
                Console.WriteLine("node is present");
            }
            else
            {
                Console.WriteLine("node is not present");
            }

        }
    }
}
