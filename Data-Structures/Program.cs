using System;
using Data_Structures.LinkedList;
using Data_Structures.Stacks;
using Data_Structures.Queues;

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
            // Start LinkedStack
            Console.WriteLine("Start Linked Stack\n");

            LinkedStack<int> linkedStack = new LinkedStack<int>(1);
            linkedStack.Push(2);
            linkedStack.Push(3);
            Console.WriteLine($"Size {linkedStack.Size()}");
            linkedStack.Push(4);
            linkedStack.Push(5);

            Console.WriteLine($"Pop {linkedStack.Pop()}");
            Console.WriteLine($"Pop {linkedStack.Pop()}");
            Console.WriteLine($"Pop {linkedStack.Peek()}");
            while (!linkedStack.IsEmpty())
                Console.WriteLine(linkedStack.Pop());
            Console.WriteLine($"Empty {linkedStack.IsEmpty()}");
            Console.WriteLine("\nEnd Linked Stack");
            // End Linked Stack
            // Start Int Queue
            Console.WriteLine("Start Int Queue\n");

            QueueInt iQ = new QueueInt(5);

            iQ.Enqueue(1);
            iQ.Enqueue(2);
            iQ.Enqueue(3);
            iQ.Enqueue(4);
            iQ.Enqueue(5);

            Console.WriteLine($"Dequeueing {iQ.Dequeue()}");
            Console.WriteLine($"Dequeueing {iQ.Dequeue()}");
            Console.WriteLine($"Dequeueing {iQ.Dequeue()}");
            Console.WriteLine($"is empty? {iQ.IsEmpty()}");

            while (!iQ.IsEmpty())
                Console.WriteLine($"Dequeueing {iQ.Dequeue()}");

            Console.WriteLine($"Is empty? {iQ.IsEmpty()}");
            Console.WriteLine("\nend Int queue");
            // End Int Queue
            // Start Linked List Queue
            Console.WriteLine("Start Queue\n");
            Queue<string> que = new Queue<string>("1");
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");
            que.Enqueue("5");

            Console.WriteLine($"Dequeue {que.Dequeue()}");
            Console.WriteLine($"Dequeue {que.Dequeue()}");
            Console.WriteLine($"Peek {que.ViewFirst()}");
            Console.WriteLine($"is empty? {que.IsEmpty()}");

            while (!que.IsEmpty())
                Console.WriteLine($"Dequeue {que.Dequeue()}");

            Console.WriteLine($"is empty? {que.IsEmpty()}");
            Console.WriteLine("\nend queue");
            //End Linked List Queue
            // Start Priority Queue
            Console.WriteLine("Starting Priority Queue\n");
            int[] arr = new int[5] { 5, 3, 14, 12, 16};
            PriorityQueue<int> pq = new(arr);

            Console.WriteLine($"Peek {pq.Peek()}");
            Console.WriteLine($"Dequeue {pq.Poll()}");
            Console.WriteLine($"Peek {pq.Peek()}");
            Console.WriteLine($"Dequeue {pq.Poll()}");
            Console.WriteLine($"Peek {pq.Peek()}");
            pq.Add(100);
            Console.WriteLine($"Peek {pq.Peek()}");
            pq.Add(23);
            Console.WriteLine($"Peek {pq.Peek()}");
            Console.WriteLine($"Contains 23 {pq.Contains(23)}");

            pq.EmptyQueue();
            Console.WriteLine($"Is Queue empty {pq.IsEmpty()}");

            Console.WriteLine("\nEnd Priority Queue");
            // End Priority Queue
        }
    }
}
