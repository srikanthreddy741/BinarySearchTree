using BinarySearchTree;
using System;


namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Binary Search Tree Program");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            binarySearch.GetSize();
            Console.ReadKey();
        }
    }
    }

