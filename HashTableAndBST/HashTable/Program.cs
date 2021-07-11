using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Implementation");
            Hash<string, int> hash = new Hash<string, int>(6);
            hash.AddNode("To", 1);
            hash.AddNode("be", 1);
            hash.AddNode("or", 1);
            hash.AddNode("not", 1);
            hash.AddNode("To", 1);
            hash.AddNode("be", 1);
            hash.display();
            Console.WriteLine("The frequency of To is {0}",hash.frequency("to"));
        }
    }
}
