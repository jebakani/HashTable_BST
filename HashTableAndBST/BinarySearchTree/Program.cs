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
            binarySearch.display(binarySearch.root);
        }
    }
}
