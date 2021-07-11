using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Implementation");
            Hash<string, int> hash = new Hash<string, int>(10);
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = para.Split(" ");
            for(int i=0;i<words.Length;i++)
            {
                hash.AddNode(words[i],1);
            }
            hash.display();
            Console.WriteLine("The frequency of paranoid is {0}",hash.frequency("paranoid"));
        }
    }
}
