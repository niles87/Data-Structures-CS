using System;
using Data_Structures.LinkedList;
using Data_Structures.Stacks;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linked list
            Console.WriteLine("start LinkedList\n");
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 1; i < 10; i++)
            {
                linkedList.Add(i * 2);
            }

            Console.WriteLine(linkedList);
            Console.WriteLine(linkedList.IndexOf(12));
            Console.WriteLine(linkedList.Contains(11));
            linkedList.RemoveAt(8);
            Console.WriteLine(linkedList);
            Console.WriteLine(linkedList.ViewFirst());
            Console.WriteLine(linkedList.ViewLast());
            linkedList.Clear();
            Console.WriteLine(linkedList);
            Console.WriteLine("\nEnd LinkedList");
            // End Linked List
            // Int Stack
            Console.WriteLine("Start Int Stack\n");
            Stack intStack = new Stack(5);

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine(intStack.Peek());
            intStack.Push(4);
            intStack.Push(5);
            Console.WriteLine(intStack.Size());

            while (!intStack.isEmpty())
            {
                Console.WriteLine(intStack.Pop());
            }

            Console.WriteLine(intStack.isEmpty());

            Console.WriteLine("\nEnd Int Stack");
            // End Int Stack
        }
    }
}
