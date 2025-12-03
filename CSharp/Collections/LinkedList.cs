using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new LinkedList<int>();
            for (int i = 1; i <= 9; i++)
            {
                lst.AddLast(i); // AddFirst, RemoveFirst, AddLast, RemoveLast
            }
            LinkedListNode<int> currentNode = lst.First;
            while (currentNode != null) 
            {
                if (currentNode.Value == 10) 
                {
                    break;
                }
                currentNode = currentNode.Next; // Next, Previous, Value
            }
            if (currentNode != null)
            {
                lst.Remove(currentNode);
            }
            foreach (var i in lst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}